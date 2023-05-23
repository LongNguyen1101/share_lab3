namespace LAB3
{
    partial class MultiTCPServerForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtxtShow = new System.Windows.Forms.RichTextBox();
            this.lbIP = new System.Windows.Forms.Label();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbListen = new System.Windows.Forms.Label();
            this.btnStart_Stop = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtxtShow);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtIP);
            this.splitContainer1.Panel2.Controls.Add(this.lbIP);
            this.splitContainer1.Panel2.Controls.Add(this.dgvClients);
            this.splitContainer1.Panel2.Controls.Add(this.lbListen);
            this.splitContainer1.Panel2.Controls.Add(this.btnStart_Stop);
            this.splitContainer1.Size = new System.Drawing.Size(1483, 970);
            this.splitContainer1.SplitterDistance = 1040;
            this.splitContainer1.TabIndex = 1;
            // 
            // rtxtShow
            // 
            this.rtxtShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtShow.Location = new System.Drawing.Point(0, 0);
            this.rtxtShow.Name = "rtxtShow";
            this.rtxtShow.Size = new System.Drawing.Size(1040, 970);
            this.rtxtShow.TabIndex = 0;
            this.rtxtShow.Text = "";
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIP.Location = new System.Drawing.Point(142, 632);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(162, 36);
            this.lbIP.TabIndex = 3;
            this.lbIP.Text = "IP Address";
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserName,
            this.colEndPoint});
            this.dgvClients.Location = new System.Drawing.Point(12, 0);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersWidth = 62;
            this.dgvClients.RowTemplate.Height = 28;
            this.dgvClients.Size = new System.Drawing.Size(427, 585);
            this.dgvClients.TabIndex = 2;
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
            // lbListen
            // 
            this.lbListen.AutoSize = true;
            this.lbListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListen.Location = new System.Drawing.Point(169, 780);
            this.lbListen.Name = "lbListen";
            this.lbListen.Size = new System.Drawing.Size(95, 36);
            this.lbListen.TabIndex = 1;
            this.lbListen.Text = "Listen";
            // 
            // btnStart_Stop
            // 
            this.btnStart_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart_Stop.Location = new System.Drawing.Point(80, 842);
            this.btnStart_Stop.Name = "btnStart_Stop";
            this.btnStart_Stop.Size = new System.Drawing.Size(271, 83);
            this.btnStart_Stop.TabIndex = 0;
            this.btnStart_Stop.Text = "Start";
            this.btnStart_Stop.UseVisualStyleBackColor = true;
            this.btnStart_Stop.Click += new System.EventHandler(this.btnStart_Stop_Click);
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(80, 685);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(270, 41);
            this.txtIP.TabIndex = 4;
            // 
            // MultiTCPServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 970);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MultiTCPServerForm";
            this.Text = "SERVER";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtxtShow;
        private System.Windows.Forms.Label lbListen;
        private System.Windows.Forms.Button btnStart_Stop;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndPoint;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.TextBox txtIP;
    }
}