using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LAB3
{
    public partial class MultiTCPServerForm : Form
    {
        TcpListener server;
        private bool running = false;
        Dictionary<TcpClient, string> clients = new Dictionary<TcpClient, string>();
        Dictionary<string, string> participants = new Dictionary<string, string>();

        public MultiTCPServerForm()
        {
            InitializeComponent();
            rtxtShow.ReadOnly = true;
            txtIP.ReadOnly = true;
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

        private string getCurrIP()
        {
            var hostname = Dns.GetHostName();
            var addresses = Dns.GetHostAddresses(hostname);

            foreach (var address in addresses)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    return address.ToString();
                }
            }

            return "null";
        }

        private void btnStart_Stop_Click(object sender, EventArgs e)
        {
            if (!running)
            {

                server = new TcpListener(IPAddress.Parse(getCurrIP()), 8080);
                txtIP.Text = getCurrIP();
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
                            Task.Run(() => handleClient(client, endPoint));
                            Task.Run(() => broadcastParticipants());
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
                broadcastMessage("@Server is shutdown", null, null);
                server.Stop();
                running = false;
                btnStart_Stop.Text = "Start";

                show($"[{DateTime.Now}] Server is shutdown");
            }
        }

        private async void broadcastParticipants()
        {
            while (running)
            {
                string participantJson = JsonConvert.SerializeObject(participants);
                byte[] participantBytes = Encoding.UTF8.GetBytes("@participants/" + participantJson);

                foreach (TcpClient client in clients.Keys)
                {
                    client.GetStream().Write(participantBytes, 0, participantBytes.Length);
                }

                await Task.Delay(5000);
            }
        }

        private void handleClient(TcpClient client, string endPoint)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024 * 4096];
            string[] user = new string[2];

            byte[] sendMessage = Encoding.UTF8.GetBytes("Welcome to chatroom");
            client.GetStream().Write(sendMessage, 0, sendMessage.Length);

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
                    show($"[{DateTime.Now}] User {user[1]} has left the room");
                    clients.Remove(client);
                    participants.Remove(user[1]);
                    removeRow(endPoint);
                    broadcastMessage($"User {user[1]} has left the room", client, user[1]);
                    break;
                }

                string message = Encoding.UTF8.GetString(buffer, 0, byteReads);

                if (message.Contains("@userName: "))
                {
                    user = message.Split(' ');
                    appendDataGridView(user[1], endPoint);
                    clients[client] = endPoint;
                    participants[user[1]] = endPoint;

                    show($"[{DateTime.Now}] {endPoint} - User: {user[1]} has connected");

                    broadcastMessage($"User: {user[1]} has connected", client, user[1]);
                }
                else if (message.Contains("@private"))
                {
                    string[] privateUser = message.Split('\\');
                    string privateEndPoint = privateUser[1];
                    privateMessage(endPoint + '-' + message, privateEndPoint);
                }
                else
                {
                    show($"[{DateTime.Now}] {endPoint} - User: {user[1]}: {message}");

                    broadcastMessage($"{endPoint} - User: {user[1]}: {message}", client, user[1]);
                }
            }
        }
        private void privateMessage(string message, string privateClient)
        {
            foreach (TcpClient client in clients.Keys)
                if (clients[client].Equals(privateClient))
                {
                    try
                    {
                        byte[] sendMessage = Encoding.UTF8.GetBytes(message);
                        client.GetStream().Write(sendMessage, 0, sendMessage.Length);
                    }
                    catch
                    {

                    }
                }
        }
        private void broadcastMessage(string message, TcpClient client, string user)
        {
            foreach (TcpClient userClient in clients.Keys)
            {
                if (userClient != client)
                {
                    try
                    {
                        byte[] sendMessage = Encoding.UTF8.GetBytes(message);
                        userClient.GetStream().Write(sendMessage, 0, sendMessage.Length);
                    }
                    catch (Exception ex)
                    {
                        show($"[{DateTime.Now}] Error sending message to user {user[1]}: {ex.Message}");
                    }
                }
            }
        }

        private void appendDataGridView(string user, string endPoint)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => appendDataGridView(user, endPoint)));
            }
            else
            {
                dgvClients.Rows.Add(user, endPoint);
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
    }
}
