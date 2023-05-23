namespace LAB3
{
    partial class MultiTCPClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect_Disconnnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtxtShow = new System.Windows.Forms.RichTextBox();
            this.rtxtMessage = new System.Windows.Forms.RichTextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.lbIP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect_Disconnnect
            // 
            this.btnConnect_Disconnnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect_Disconnnect.Location = new System.Drawing.Point(1016, 586);
            this.btnConnect_Disconnnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect_Disconnnect.Name = "btnConnect_Disconnnect";
            this.btnConnect_Disconnnect.Size = new System.Drawing.Size(260, 47);
            this.btnConnect_Disconnnect.TabIndex = 3;
            this.btnConnect_Disconnnect.Text = "Connect";
            this.btnConnect_Disconnnect.UseVisualStyleBackColor = true;
            this.btnConnect_Disconnnect.Click += new System.EventHandler(this.btnConnect_Disconnnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(1016, 680);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(260, 62);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtxtShow
            // 
            this.rtxtShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtShow.Location = new System.Drawing.Point(11, 10);
            this.rtxtShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtShow.Name = "rtxtShow";
            this.rtxtShow.Size = new System.Drawing.Size(929, 641);
            this.rtxtShow.TabIndex = 4;
            this.rtxtShow.Text = "";
            // 
            // rtxtMessage
            // 
            this.rtxtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtMessage.Location = new System.Drawing.Point(268, 680);
            this.rtxtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtMessage.Name = "rtxtMessage";
            this.rtxtMessage.Size = new System.Drawing.Size(672, 62);
            this.rtxtMessage.TabIndex = 5;
            this.rtxtMessage.Text = "";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(11, 709);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(216, 36);
            this.txtUserName.TabIndex = 6;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(11, 664);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(137, 29);
            this.lbUserName.TabIndex = 7;
            this.lbUserName.Text = "User name";
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserName,
            this.colEndPoint});
            this.dgvClients.Location = new System.Drawing.Point(969, 10);
            this.dgvClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersWidth = 62;
            this.dgvClients.RowTemplate.Height = 28;
            this.dgvClients.Size = new System.Drawing.Size(348, 376);
            this.dgvClients.TabIndex = 8;
            this.dgvClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentClick);
            // 
            // colUserName
            // 
            this.colUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUserName.HeaderText = "User name";
            this.colUserName.MinimumWidth = 8;
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            // 
            // colEndPoint
            // 
            this.colEndPoint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEndPoint.HeaderText = "End point";
            this.colEndPoint.MinimumWidth = 8;
            this.colEndPoint.Name = "colEndPoint";
            this.colEndPoint.ReadOnly = true;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPAddress.Location = new System.Drawing.Point(1016, 498);
            this.txtIPAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(261, 36);
            this.txtIPAddress.TabIndex = 10;
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIP.Location = new System.Drawing.Point(1067, 439);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(136, 29);
            this.lbIP.TabIndex = 11;
            this.lbIP.Text = "IP Address";
            // 
            // MultiTCPClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 786);
            this.Controls.Add(this.lbIP);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.rtxtMessage);
            this.Controls.Add(this.rtxtShow);
            this.Controls.Add(this.btnConnect_Disconnnect);
            this.Controls.Add(this.btnSend);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MultiTCPClientForm";
            this.Text = "CLIENT";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect_Disconnnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtxtShow;
        private System.Windows.Forms.RichTextBox rtxtMessage;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndPoint;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label lbIP;
    }
}