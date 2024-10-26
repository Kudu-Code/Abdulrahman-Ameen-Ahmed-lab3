using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework3
{
    public partial class Exercise : Form
    {
        double x, y, z;
        string[] op = { "+", "-", "*", "/" };
        public Exercise()
        {
            InitializeComponent();
            listBox1.Items.AddRange(op);
            listBox1.Enabled = false;
            calculate.Enabled = false;
        }

        private void Exercise_Load(object sender, EventArgs e)
        {

            textBox2.TextChanged += textBox1_TextChanged;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            calculate.Enabled = listBox1.Enabled = (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBox1.Text = "";
                textBox1.Focus();
                return;
            }
            try
            {
                y = Convert.ToDouble(textBox2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBox2.Text = "";
                textBox2.Focus();
                return;
            }
            bool f = true;
            switch (listBox1.SelectedIndex)
            {
                case 0: z = x + y; break;
                case 1: z = x - y; break;
                case 2: z = x * y; break;
                case 3:
                    if (y != 0)
                    {
                        z = x / y;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Can't divide by Zero");
                        f = false;
                        textBox3.Text = null;
                        break;
                    }
                default: f = false; 
                    break;
            }
            if (f)
            {
                textBox3.Text = z.ToString();
            }
            else
            {
                textBox3.Text = null;
                MessageBox.Show("Please select operation!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndexChanged -= listBox1_SelectedIndexChanged;
            listBox1.ClearSelected();
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculate_Click(null,null);
        }
    }
}
