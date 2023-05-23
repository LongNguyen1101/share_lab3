namespace LAB3
{
    partial class Task1Form
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
            this.btnUDPClient = new System.Windows.Forms.Button();
            this.btnUDPServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUDPClient
            // 
            this.btnUDPClient.Location = new System.Drawing.Point(56, 57);
            this.btnUDPClient.Name = "btnUDPClient";
            this.btnUDPClient.Size = new System.Drawing.Size(117, 64);
            this.btnUDPClient.TabIndex = 0;
            this.btnUDPClient.Text = "UDP Client";
            this.btnUDPClient.UseVisualStyleBackColor = true;
            this.btnUDPClient.Click += new System.EventHandler(this.btnUDPClient_Click);
            // 
            // btnUDPServer
            // 
            this.btnUDPServer.Location = new System.Drawing.Point(231, 57);
            this.btnUDPServer.Name = "btnUDPServer";
            this.btnUDPServer.Size = new System.Drawing.Size(117, 64);
            this.btnUDPServer.TabIndex = 1;
            this.btnUDPServer.Text = "UDP Server";
            this.btnUDPServer.UseVisualStyleBackColor = true;
            this.btnUDPServer.Click += new System.EventHandler(this.btnUDPServer_Click);
            // 
            // Task1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 197);
            this.Controls.Add(this.btnUDPServer);
            this.Controls.Add(this.btnUDPClient);
            this.Name = "Task1Form";
            this.Text = "Task 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUDPClient;
        private System.Windows.Forms.Button btnUDPServer;
    }
}