using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public partial class Task2Form : Form
    {
        public Task2Form()
        {
            InitializeComponent();
        }

        private void btnTCPTelnetServer_Click(object sender, EventArgs e)
        {
            TCPTelnetServer tcpServer = new TCPTelnetServer();
            tcpServer.Show();
        }
    }
}
