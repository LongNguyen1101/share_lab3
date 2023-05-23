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
    public partial class Task1Form : Form
    {
        public Task1Form()
        {
            InitializeComponent();
        }

        private void btnUDPClient_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                UDPClientForm frm = new UDPClientForm();
                frm.ShowDialog();
            });
            thread.Start();
        }

        private void btnUDPServer_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                UDPServerForm frm = new UDPServerForm();
                frm.ShowDialog();
            });
            thread.Start();
        }
    }
}
