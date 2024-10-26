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
    public partial class Form3 : Form
    {
        double x, y, z;
        string[] op = { "+", "-", "*", "/" };
        public Form3()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(op);
            comboBox1.Enabled = false;
            //  comboBox1.Items.Add('+');
            //comboBox1.Items.Add('+');
            //comboBox1.Items.Add('-');
            //comboBox1.Items.Add('*');
            //comboBox1.Items.Add('/');

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox2.TextChanged += textBox1_TextChanged;
            comboBox1.SelectedIndexChanged += calculate_Click;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndexChanged -= calculate_Click;
            comboBox1.SelectedItem = null;
            textBox1.Text = textBox2.Text = textBox3.Text=null;
            comboBox1.SelectedIndexChanged += calculate_Click;
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
            switch (comboBox1.SelectedIndex)
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
                default:f = false; break;
            }
            if (f)
            {
                textBox3.Text = z.ToString();
            }
            else
            {
                textBox3.Text = null;
                MessageBox.Show("Please select operation!");
                comboBox1.DroppedDown= true;
                comboBox1.Focus();
            }
        }
    }
}
