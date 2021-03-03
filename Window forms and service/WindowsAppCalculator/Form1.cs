using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsAppCalculator
{
    public partial class Form1 : Form
    {
        int num1, num2, result;
        public Form1()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"\d+") && Regex.IsMatch(textBox2.Text, @"\d+"))
            {
                num1 = int.Parse(textBox1.Text);
                num2 = int.Parse(textBox2.Text);
                result = num1 + num2;
                MessageBox.Show(result.ToString());
            }

            else
            {
                MessageBox.Show("Invalid Inputs");
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"\d+") && Regex.IsMatch(textBox2.Text, @"\d+"))
            {
               
                num1 = int.Parse(textBox1.Text);
                num2 = int.Parse(textBox2.Text);
                result = num1 - num2;
                MessageBox.Show(result.ToString());
            }
            else
            {
                MessageBox.Show("Invalid Inputs");
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"\d+") && Regex.IsMatch(textBox2.Text, @"\d+"))
            {
                num1 = int.Parse(textBox1.Text);
                num2 = int.Parse(textBox2.Text);
                result = num1 * num2;
                MessageBox.Show(result.ToString());
            }
            else
            {
                MessageBox.Show("Invalid Inputs");
            }
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"\d+") && Regex.IsMatch(textBox2.Text, @"\d+"))
            {

                num1 = int.Parse(textBox1.Text);
                num2 = int.Parse(textBox2.Text);
                result = num1 / num2;
                MessageBox.Show(result.ToString());
            }

            else
            {
                MessageBox.Show("Invalid Inputs");
            }
        }
       


   
    }
}
