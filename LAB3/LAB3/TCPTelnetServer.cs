using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public partial class TCPTelnetServer : Form
    {
        Thread thread;

        public TCPTelnetServer()
        {
            InitializeComponent();
        }
        void Listen()
        {
            Socket clientSocket;
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint IPepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listener.Bind(IPepServer);
            listener.Listen(-1);
            Show("Telnet is running on 127.0.0.1:8080");
            clientSocket = listener.Accept();
            Show("New client connected");
            byte[] buffer = new byte[1024];
            while (clientSocket.Connected)
            {
                string text = string.Empty;
                do
                {
                    clientSocket.Receive(buffer);
                    text += Encoding.UTF8.GetString(buffer);
                } while (text[text.Length - 1] == '\n');
                Show(text);
            }
            listener.Close();
        }
        void Show(string msg)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Show(msg)));
            }
            else
            {
                rtbMessage.Text += msg + Environment.NewLine;
            }
        }
        private void btnListen_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(Listen));
            thread.Start();
        }
    }
}
