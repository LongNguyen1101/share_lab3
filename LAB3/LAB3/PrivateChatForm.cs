using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public partial class PrivateChatForm : Form
    {
        private NetworkStream stream;
        private TcpClient client;
        private string endPoint;
        private string userName;
        private string fromEndPoint;
        public PrivateChatForm(string endPoint, TcpClient _client)
        {
            InitializeComponent();
            this.endPoint = endPoint;
            client = _client;
            stream = client.GetStream();
            // Kết nối tới client có địa chỉ IP và cổng được chỉ định
            //client = new TcpClient();
            //client.Connect(endPoint.Split(':')[0], int.Parse(endPoint.Split(':')[1]));
            //stream = client.GetStream();

            // Gửi tin nhắn cho client khác để thông báo việc bắt đầu cuộc trò chuyện riêng tư
            //byte[] buffer = Encoding.UTF8.GetBytes($"@privatechatstart\\{endPoint}");
            //stream.Write(buffer, 0, buffer.Length);

            Thread thread = new Thread(() => receiveMessage());
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        void Show(string msg)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Show(msg)));
            }
            else
            {
                rtbMessage.AppendText(msg + Environment.NewLine);
            }    
        }
        void ShowImage()
        {
            if (InvokeRequired) 
            {
                Invoke(new Action(() => ShowImage()));
            }
            else
            {
                rtbMessage.AppendText(Environment.NewLine);
                rtbMessage.SelectionLength = 0;
                rtbMessage.SelectionStart = rtbMessage.TextLength;
                rtbMessage.Paste();
                rtbMessage.AppendText(Environment.NewLine);
            }    
        }
        private void receiveMessage()
        {
            try
            {
                byte[] buffer = new byte[1024 * 4096];
                while (true)
                {
                    int byteReads = stream.Read(buffer, 0, buffer.Length);
                    if (byteReads == 0)
                    {
                        MessageBox.Show($"[{DateTime.Now}] {userName} đã ngắt kết nối.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                    string message = Encoding.UTF8.GetString(buffer, 0, byteReads);
                    //if (message.Contains("@privatechatstart"))
                    //{
                     //   string[] arr = message.Split(':');
                     //   if (arr.Length == 2)
                     //   {
                     //       rtbMessage.Text += $"Đang trò chuyện riêng với {arr[1]}";
                     //   }
                    //}
                    //else 
                    if (message.Contains("@private\\"))
                    {
                        string[] fromUser = new string[4];
                        fromUser = message.Split(new char[] { '-', '\\' });
                        Show($"[{DateTime.Now}] From {fromUser[0]}: {fromUser[3]}");
                    }
                    else if (message.Contains("@privateImage\\"))
                    {
                        string[] fromUser = new string[4];
                        fromUser = message.Split(new char[] { '-', '\\' });
                        var imageData = Convert.FromBase64String(fromUser[3]);
                        using (var ms = new MemoryStream(imageData))
                        {
                            Image image = Image.FromStream(ms);
                            Clipboard.SetImage(image);
                            Show($"[{DateTime.Now}] From {fromUser[0]}: Đã nhận được file từ {fromUser[0]}");
                            ShowImage();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.UTF8.GetBytes("@private\\" + endPoint + "\\" + rtbSendMessage.Text);
            stream.Write(buffer, 0, buffer.Length);
            Show($"[{DateTime.Now}] You: {rtbSendMessage.Text}");
            rtbSendMessage.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image|*.png;*.jpg|Text|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(ofd.FileName);
                    if (fileExtension == ".png" || fileExtension == ".jpg")
                    {
                        byte[] data = File.ReadAllBytes(ofd.FileName);
                        var base64s = Convert.ToBase64String(data);
                        byte[] buffer = Encoding.UTF8.GetBytes("@privateImage\\" + endPoint + "\\" + base64s);
                        stream.Write(buffer, 0, buffer.Length);
                        using (var ms = new MemoryStream(data))
                        {
                            Image image = Image.FromStream(ms);
                            Clipboard.SetImage(image);
                            Show($"[{DateTime.Now}] You:");
                            ShowImage();
                        }
                    }
                    else
                    {
                        StreamReader sr = new StreamReader(ofd.FileName);
                        string msg = sr.ReadToEnd();
                        byte[] buffer = Encoding.UTF8.GetBytes("@private\\" + endPoint + "\\" +
                            $"Đã nhận file từ {endPoint}\n" + msg);
                        stream.Write(buffer, 0, buffer.Length );
                        Show($"[{DateTime.Now}] You: {msg}");
                    }    
                }
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
