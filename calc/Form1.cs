using System.Collections.Generic;
using System.Data;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }


        private void Del_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void fullDelete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

        }

        private void mul_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void add_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void div_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void pnt_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }
       

        private void equal_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;
            try
            {
                object result = new DataTable().Compute(userInput, null);

                textBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input: " + ex.Message);
            }
        }
    }
}