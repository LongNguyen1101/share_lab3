namespace LAB3
{
    partial class TCPClientForm
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
            this.rtxtMessage = new System.Windows.Forms.RichTextBox();
            this.btnConnect_Disconnnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.rtxtMessage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnConnect_Disconnnect);
            this.splitContainer1.Panel2.Controls.Add(this.btnSend);
            this.splitContainer1.Size = new System.Drawing.Size(1166, 527);
            this.splitContainer1.SplitterDistance = 889;
            this.splitContainer1.TabIndex = 0;
            // 
            // rtxtMessage
            // 
            this.rtxtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtMessage.Location = new System.Drawing.Point(0, 0);
            this.rtxtMessage.Name = "rtxtMessage";
            this.rtxtMessage.Size = new System.Drawing.Size(889, 527);
            this.rtxtMessage.TabIndex = 0;
            this.rtxtMessage.Text = "";
            // 
            // btnConnect_Disconnnect
            // 
            this.btnConnect_Disconnnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect_Disconnnect.Location = new System.Drawing.Point(34, 283);
            this.btnConnect_Disconnnect.Name = "btnConnect_Disconnnect";
            this.btnConnect_Disconnnect.Size = new System.Drawing.Size(210, 77);
            this.btnConnect_Disconnnect.TabIndex = 1;
            this.btnConnect_Disconnnect.Text = "Connect";
            this.btnConnect_Disconnnect.UseVisualStyleBackColor = true;
            this.btnConnect_Disconnnect.Click += new System.EventHandler(this.btnConnect_Disconnnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(34, 404);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(210, 77);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // TCPClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 527);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TCPClientForm";
            this.Text = "TCP CLIENT";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtxtMessage;
        private System.Windows.Forms.Button btnConnect_Disconnnect;
        private System.Windows.Forms.Button btnSend;
    }
}