using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public partial class TCPClientForm : Form
    {
        private bool connect = false;
        NetworkStream stream;
        TcpClient client;

        public TCPClientForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Disconnnect_Click(object sender, EventArgs e)
        {
            if (!connect)
            {
                try
                {
                    client = new TcpClient("127.0.0.1", 8080);
                    stream = client.GetStream();
                    btnConnect_Disconnnect.Text = "Disconnect";
                    connect = true;
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"Error connecting to server: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
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
                    rtxtMessage.Clear();
                }
                catch ( Exception ex )
                {
                    MessageBox.Show($"Error sending message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please connect to server!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
 