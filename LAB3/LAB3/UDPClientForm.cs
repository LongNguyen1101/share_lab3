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
    public partial class UDPClientForm : Form
    {
        public UDPClientForm()
        {
            InitializeComponent();
        }
        void Send(string msg)
        {
            using (UdpClient udpClient = new UdpClient())
            {
                try
                {
                    udpClient.Connect(IPAddress.Parse(tbIP.Text), Int32.Parse(tbPort.Text));
                    byte[] data = Encoding.UTF8.GetBytes(msg);
                    udpClient.Send(data, data.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            Send(rtbMessage.Text);
        }
    }
}
