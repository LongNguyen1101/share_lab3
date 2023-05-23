using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LAB3
{
    public partial class MultiTCPClientForm : Form
    {
        private bool connect = false;
        NetworkStream stream;
        TcpClient client;
        Dictionary<string, string> users = new Dictionary<string, string>();

        public MultiTCPClientForm()
        {
            InitializeComponent();
        }

        private void show(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => show(message)));
            }
            else
            {
                rtxtShow.AppendText(message + Environment.NewLine);
            }
        }
        private void btnConnect_Disconnnect_Click(object sender, EventArgs e)
        {
            if (!connect)
            {
                if (string.IsNullOrEmpty(txtUserName.Text))
                {
                    MessageBox.Show("Please enter user name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    client = new TcpClient(txtIPAddress.Text, 8080);
                    btnConnect_Disconnnect.Text = "Disconnect";
                    connect = true;
                    stream = client.GetStream();
                    byte[] buffer = Encoding.UTF8.GetBytes("@userName: " + txtUserName.Text);
                    stream.Write(buffer, 0, buffer.Length);
                    Task.Run(() => receiveMessage());
                }
                catch (Exception ex)
                {
                    show($"[{DateTime.Now}] Error connecting to server: {ex.Message}");
                }
            }
            else
            {
                Disconnect();
            }
        }

        private void receiveMessage()
        {
            try
            {
                byte[] buffer = new byte[1024];
                while (connect)
                {
                    int byteReads = 0;

                    try
                    {
                        byteReads = stream.Read(buffer, 0, buffer.Length);
                    }
                    catch { }

                    if (byteReads == 0)
                    {
                        show($"[{DateTime.Now}] You have disconnect to server");
                        connect = false;
                        break;
                    }

                    string message = Encoding.UTF8.GetString(buffer, 0, byteReads);
                    if (message.Contains("@participants"))
                    {
                        Task.Run(() => showDataGridView(message));
                    }
                    else if (message == "@Server is shutdown")
                    {
                        string[] shutdownMessage = message.Split('@');
                        show($"[{DateTime.Now}] {shutdownMessage[1]}");
                        invokeDisconnect();
                    }
                    else if (message.Contains("@privatechatstart\\"))
                    {
                        string[] fromUser = message.Split('-');
                        PrivateChatForm privateChat = new PrivateChatForm(fromUser[0], client);
                        Task.Run(() => privateChat.ShowDialog());
                    }
                    else if (message.Contains("@private"))
                    {

                    }
                    else
                    {
                        show($"[{DateTime.Now}] server: {message}");
                    }
                }
            }
            catch (Exception ex)
            {
                show($"[{DateTime.Now}] Error receive message from server: {ex.Message}");
            }
        }

        private void invokeDisconnect()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => invokeDisconnect()));
            }
            else
            {
                dgvClients.Rows.Clear();
                Disconnect();
            }
        }

        private void Disconnect()
        {
            if (connect)
            {
                btnConnect_Disconnnect.Text = "Connect";
                connect = false;

                if (stream != null)
                {
                    stream.Close();
                    stream = null;
                }
                if (client != null)
                {
                    client.Close();
                    client = null;
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (connect)
            {
                try
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(rtxtMessage.Text);
                    stream.Write(buffer, 0, buffer.Length);
                    show($"[{DateTime.Now}] You: {rtxtMessage.Text}");
                    rtxtMessage.Clear();
                }
                catch (Exception ex)
                {
                    show($"Error sending message: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please connect to server!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void showDataGridView(string message)
        {
            string[] participants = message.Split('/');
            users = JsonConvert.DeserializeObject<Dictionary<string, string>>(participants[1]);
            appendDataGridView();
        }

        private void appendDataGridView()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => appendDataGridView()));
            }
            else
            {
                dgvClients.Rows.Clear();
                foreach (string participant in users.Keys)
                {
                    if (participant != txtUserName.Text)
                    {
                        dgvClients.Rows.Add(participant, users[participant]);
                    }
                }
            }
        }

        private void removeRow(string endPoint)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => removeRow(endPoint)));
            }
            else
            {
                foreach (DataGridViewRow row in dgvClients.Rows)
                {
                    if (dgvClients.Rows.Count > 1)
                    {
                        if (row.Cells["colEndPoint"].Value.ToString() == endPoint)
                        {
                            dgvClients.Rows.Remove(row);
                            break;
                        }
                    }
                }
            }
        }
        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvClients.Rows[e.RowIndex];
                string endPoint = row.Cells["colEndPoint"].Value.ToString();
                string userName = row.Cells["colUserName"].Value.ToString();

                if (!string.IsNullOrEmpty(endPoint) && !string.IsNullOrEmpty(userName))
                {
                    byte[] buffer = Encoding.UTF8.GetBytes($"@privatechatstart\\{endPoint}");
                    stream.Write(buffer, 0, buffer.Length);
                    PrivateChatForm privateChat = new PrivateChatForm(endPoint, client);
                    Task.Run(() => privateChat.ShowDialog());
                }
            }
        }
    }
}
