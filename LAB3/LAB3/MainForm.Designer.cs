namespace LAB3
{
    partial class MainForm
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
            this.btnTask1 = new System.Windows.Forms.Button();
            this.btnTask4 = new System.Windows.Forms.Button();
            this.btnTask3 = new System.Windows.Forms.Button();
            this.btnTask2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTask1
            // 
            this.btnTask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask1.Location = new System.Drawing.Point(35, 50);
            this.btnTask1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTask1.Name = "btnTask1";
            this.btnTask1.Size = new System.Drawing.Size(271, 108);
            this.btnTask1.TabIndex = 0;
            this.btnTask1.Text = "Task 1";
            this.btnTask1.UseVisualStyleBackColor = true;
            this.btnTask1.Click += new System.EventHandler(this.btnTask1_Click);
            // 
            // btnTask4
            // 
            this.btnTask4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask4.Location = new System.Drawing.Point(375, 192);
            this.btnTask4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTask4.Name = "btnTask4";
            this.btnTask4.Size = new System.Drawing.Size(271, 108);
            this.btnTask4.TabIndex = 2;
            this.btnTask4.Text = "Task 4";
            this.btnTask4.UseVisualStyleBackColor = true;
            this.btnTask4.Click += new System.EventHandler(this.btnTask4_Click);
            // 
            // btnTask3
            // 
            this.btnTask3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask3.Location = new System.Drawing.Point(375, 50);
            this.btnTask3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTask3.Name = "btnTask3";
            this.btnTask3.Size = new System.Drawing.Size(271, 108);
            this.btnTask3.TabIndex = 3;
            this.btnTask3.Text = "Task 3";
            this.btnTask3.UseVisualStyleBackColor = true;
            this.btnTask3.Click += new System.EventHandler(this.btnTask3_Click);
            // 
            // btnTask2
            // 
            this.btnTask2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask2.Location = new System.Drawing.Point(35, 192);
            this.btnTask2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTask2.Name = "btnTask2";
            this.btnTask2.Size = new System.Drawing.Size(271, 108);
            this.btnTask2.TabIndex = 4;
            this.btnTask2.Text = "Task 2";
            this.btnTask2.UseVisualStyleBackColor = true;
            this.btnTask2.Click += new System.EventHandler(this.btnTask2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 375);
            this.Controls.Add(this.btnTask2);
            this.Controls.Add(this.btnTask3);
            this.Controls.Add(this.btnTask4);
            this.Controls.Add(this.btnTask1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = " LAB 3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTask1;
        private System.Windows.Forms.Button btnTask4;
        private System.Windows.Forms.Button btnTask3;
        private System.Windows.Forms.Button btnTask2;
    }
}

