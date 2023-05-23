using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public partial class TCPServerForm : Form
    {
        TcpListener server;
        private bool running = false;

        public TCPServerForm()
        {
            InitializeComponent();
            rtxtShow.ReadOnly = true;
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

        private void btnStart_Stop_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                server = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
                server.Start();
                show($"[{DateTime.Now}] Start listening on port: 8080");
                running = true;
                btnStart_Stop.Text = "Stop";

                Task.Run(() =>
                {
                    while (running)
                    {
                        try
                        {
                            TcpClient client = server.AcceptTcpClient();
                            string endPoint = client.Client.RemoteEndPoint.ToString();
                            show($"[{DateTime.Now}] {endPoint} has connected");
                            Task.Run(() => handleClient(client, endPoint));
                        }
                        catch
                        {
                            break;
                        }
                    }
                });
            }
            else
            {
                server.Stop();
                running = false;
                btnStart_Stop.Text = "Start";
                show($"[{DateTime.Now}] Server shutdown");
            }
        }

        private void handleClient(TcpClient client, string endPoint)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];

            while (running && client.Connected)
            {
                int byteReads = 0;

                try
                {
                    byteReads = stream.Read(buffer, 0, buffer.Length);
                }
                catch
                {
                    show($"[{DateTime.Now}] Error reading from client: {endPoint}");
                    break;
                }

                if (byteReads == 0)
                {
                    show($"[{DateTime.Now}] Client disconnected: {endPoint}");
                    break;
                }

                string message = Encoding.UTF8.GetString(buffer, 0, byteReads);
                show($"[{DateTime.Now}] {endPoint}: {message}");
            }
        }
    }
}
