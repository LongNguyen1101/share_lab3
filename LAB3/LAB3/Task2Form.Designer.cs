﻿namespace LAB3
{
    partial class Task2Form
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
            this.btnTCPTelnetServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTCPTelnetServer
            // 
            this.btnTCPTelnetServer.Location = new System.Drawing.Point(94, 69);
            this.btnTCPTelnetServer.Name = "btnTCPTelnetServer";
            this.btnTCPTelnetServer.Size = new System.Drawing.Size(163, 92);
            this.btnTCPTelnetServer.TabIndex = 0;
            this.btnTCPTelnetServer.Text = "TCP Telnet Server";
            this.btnTCPTelnetServer.UseVisualStyleBackColor = true;
            this.btnTCPTelnetServer.Click += new System.EventHandler(this.btnTCPTelnetServer_Click);
            // 
            // Task2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 263);
            this.Controls.Add(this.btnTCPTelnetServer);
            this.Name = "Task2Form";
            this.Text = "Task 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTCPTelnetServer;
    }
}