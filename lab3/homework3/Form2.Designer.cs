namespace homework3
{
    partial class sender
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
            this.yellow = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.device2 = new System.Windows.Forms.Label();
            this.device1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yellow
            // 
            this.yellow.Location = new System.Drawing.Point(276, 49);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(75, 23);
            this.yellow.TabIndex = 0;
            this.yellow.Text = "yellow";
            this.yellow.UseVisualStyleBackColor = true;
            this.yellow.Click += new System.EventHandler(this.yellow_Click);
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(149, 49);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(75, 23);
            this.green.TabIndex = 1;
            this.green.Text = "green";
            this.green.UseVisualStyleBackColor = true;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(12, 49);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(75, 23);
            this.red.TabIndex = 2;
            this.red.Text = "red";
            this.red.UseVisualStyleBackColor = true;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // device2
            // 
            this.device2.AutoSize = true;
            this.device2.Location = new System.Drawing.Point(253, 13);
            this.device2.Name = "device2";
            this.device2.Size = new System.Drawing.Size(47, 13);
            this.device2.TabIndex = 4;
            this.device2.Text = "device 2";
            this.device2.Click += new System.EventHandler(this.label1_Click);
            // 
            // device1
            // 
            this.device1.AutoSize = true;
            this.device1.Location = new System.Drawing.Point(84, 13);
            this.device1.Name = "device1";
            this.device1.Size = new System.Drawing.Size(47, 13);
            this.device1.TabIndex = 5;
            this.device1.Text = "device 1";
            this.device1.Click += new System.EventHandler(this.label2_Click);
            // 
            // sender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 170);
            this.Controls.Add(this.device1);
            this.Controls.Add(this.device2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.red);
            this.Controls.Add(this.green);
            this.Controls.Add(this.yellow);
            this.Name = "sender";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yellow;
        private System.Windows.Forms.Button green;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label device2;
        private System.Windows.Forms.Label device1;
    }
}