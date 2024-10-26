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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double operation(double num1,double num2,string op)
        {
            switch(op)
            {
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                default:
                    return double.NaN;
            }
        }
        void show_focus(TextBox box)
        {
            MessageBox.Show("wrong operation");
            box.Focus();
        }
bool  priority(string op)
        {
            return op == "*" || op == "/";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;
            string op1=opbox1.Text, op2=opbox2.Text;
            string intermdiate_result = "";
            string final_result = "";
            if(double.TryParse(textnum1.Text,out num1)&&
                double.TryParse(textnum2.Text,out num2)&&
                double.TryParse(textnum3.Text,out num3))
            {
             if(priority(op1))
                { 
                     intermdiate_result = operation(num1, num2, op1).ToString();
                     if (intermdiate_result == "NaN")
                            {
                                show_focus(opbox1);
                                return;
                            }
                            final_result = operation(Convert.ToDouble(intermdiate_result),
                                num3, op2).ToString();
                            if (final_result == "NaN")
                            {
                                show_focus(opbox2);
                                return;
                            }
                    textresult.Text = final_result;
                }

                else
                {
                    intermdiate_result = operation(num2, num3, op2).ToString();
                    if (intermdiate_result == "NaN")
                    {
                        show_focus(opbox2);
                        return;
                    }
                    final_result = operation(Convert.ToDouble(intermdiate_result),
                        num1, op1).ToString();
                    if (final_result == "NaN")
                    {
                        show_focus(opbox1);
                        return;
                    }
                    textresult.Text = final_result;
                }

            }
            else
            {
                MessageBox.Show("please enter correct numbers");
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textresult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
