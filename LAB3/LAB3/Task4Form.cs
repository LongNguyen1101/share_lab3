using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public partial class Task4Form : Form
    {
        MultiTCPServerForm server = new MultiTCPServerForm();
        Thread serverThread;
        Thread clientThread;

        public Task4Form()
        {
            InitializeComponent();
        }

        private void openServer()
        {
            try
            {
                server.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Server is already open!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openClient()
        {
            try
            {
                MultiTCPClientForm client = new MultiTCPClientForm();
                client.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error open client form!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenServer_Click(object sender, EventArgs e)
        {
            if (!server.IsDisposed)
            {
                serverThread = new Thread(new ThreadStart(openServer));
                serverThread.Start();
            }
        }

        private void btnOpenClient_Click(object sender, EventArgs e)
        {
            clientThread = new Thread(new ThreadStart(openClient));
            clientThread.Start();
        }

    }
}
