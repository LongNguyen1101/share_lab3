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

namespace LAB3
{
    public partial class UDPServerForm : Form
    {
        public UDPServerForm()
        {
            InitializeComponent();
        }
        void Receive()
        {
            try
            {
                UdpClient udpServer = new UdpClient(Int32.Parse(tbPort.Text));
                Task.Run(() =>
                {
                    while (true)
                    {
                        IPEndPoint RemoteIPep = new IPEndPoint(IPAddress.Any, 0);
                        byte[] data = udpServer.Receive(ref RemoteIPep);
                        string msg = Encoding.UTF8.GetString(data);
                        string fullMsg = RemoteIPep.Address.ToString() + ": " + msg;
                        if (InvokeRequired)
                        {
                            Invoke(new Action(() => rtbMessage.Text += fullMsg + '\n'));
                        }
                        else
                            rtbMessage.Text += fullMsg + '\n';
                    }
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnListen_Click(object sender, EventArgs e)
        {
            Receive();
        }
    }
}