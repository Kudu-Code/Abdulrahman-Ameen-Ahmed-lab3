namespace homework3
{
    partial class Form1
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
            this.textnum1 = new System.Windows.Forms.TextBox();
            this.opbox1 = new System.Windows.Forms.TextBox();
            this.textnum2 = new System.Windows.Forms.TextBox();
            this.opbox2 = new System.Windows.Forms.TextBox();
            this.textnum3 = new System.Windows.Forms.TextBox();
            this.textresult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textnum1
            // 
            this.textnum1.Location = new System.Drawing.Point(26, 24);
            this.textnum1.Name = "textnum1";
            this.textnum1.Size = new System.Drawing.Size(100, 20);
            this.textnum1.TabIndex = 0;
            // 
            // opbox1
            // 
            this.opbox1.Location = new System.Drawing.Point(29, 69);
            this.opbox1.Name = "opbox1";
            this.opbox1.Size = new System.Drawing.Size(100, 20);
            this.opbox1.TabIndex = 1;
            this.opbox1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textnum2
            // 
            this.textnum2.Location = new System.Drawing.Point(29, 112);
            this.textnum2.Name = "textnum2";
            this.textnum2.Size = new System.Drawing.Size(100, 20);
            this.textnum2.TabIndex = 2;
            // 
            // opbox2
            // 
            this.opbox2.Location = new System.Drawing.Point(29, 157);
            this.opbox2.Name = "opbox2";
            this.opbox2.Size = new System.Drawing.Size(100, 20);
            this.opbox2.TabIndex = 3;
            // 
            // textnum3
            // 
            this.textnum3.Location = new System.Drawing.Point(29, 203);
            this.textnum3.Name = "textnum3";
            this.textnum3.Size = new System.Drawing.Size(100, 20);
            this.textnum3.TabIndex = 4;
            // 
            // textresult
            // 
            this.textresult.Enabled = false;
            this.textresult.Location = new System.Drawing.Point(29, 251);
            this.textresult.Name = "textresult";
            this.textresult.Size = new System.Drawing.Size(100, 20);
            this.textresult.TabIndex = 5;
            this.textresult.TextChanged += new System.EventHandler(this.textresult_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "num1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "operation1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "num2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "operation2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "num3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "result";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 358);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textresult);
            this.Controls.Add(this.textnum3);
            this.Controls.Add(this.opbox2);
            this.Controls.Add(this.textnum2);
            this.Controls.Add(this.opbox1);
            this.Controls.Add(this.textnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textnum1;
        private System.Windows.Forms.TextBox opbox1;
        private System.Windows.Forms.TextBox textnum2;
        private System.Windows.Forms.TextBox opbox2;
        private System.Windows.Forms.TextBox textnum3;
        private System.Windows.Forms.TextBox textresult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

