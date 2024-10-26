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
    public partial class sender : Form
    {
        public sender()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            green.Click += yellow_Click;
            red.Click += yellow_Click;
            device1.Click += yellow_Click;
            device2.Click += yellow_Click;
        }

        private void yellow_Click(object sender, EventArgs e)
        {
            if (sender == yellow)
            {
                button1.Text = yellow.Text;
                button1.BackColor = Color.Yellow;
            }
            else if (sender == green)
            {
                button1.Text = green.Text;
                button1.BackColor = Color.Green;
            }
            else if (sender == red)
            {
                button1.Text = red.Text;
                button1.BackColor = Color.Red; }
            else if (sender == device1)
            {
                button1.BackColor = Color.Empty;
                button1.Text = device1.Text;
            }
            else if (sender == device2)
            {
                button1.BackColor = Color.Empty;
                button1.Text = device2.Text;
            }
        }

        private void green_Click(object sender, EventArgs e)
        {
            
        }

        private void red_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
