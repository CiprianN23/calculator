using System;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {

        string input = String.Empty;
        string operand1 = String.Empty;
        string operand2 = String.Empty;
        char operation;
        private double result = 0.0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += "9";
            this.textBox2.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += "8";
            this.textBox2.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += "7";
            this.textBox2.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += "6";
            this.textBox2.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += "5";
            this.textBox2.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += "4";
            this.textBox2.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += "3";
            this.textBox2.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += "2";
            this.textBox2.Text += input;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += "1";
            this.textBox2.Text += input;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += "0";
            this.textBox2.Text += input;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += ".";
            this.textBox2.Text += input;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            this.input = String.Empty;
            this.operand1 = String.Empty;
            this.operand2 = String.Empty;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = String.Empty;
        }

        private void star_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = String.Empty;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = String.Empty;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = String.Empty;
        }

        private void eqqual_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            this.textBox2.Text = "";
            this.input = String.Empty;
            this.operand1 = String.Empty;
            this.operand2 = String.Empty;

            if (operation == '+')
            {
                result = num1 + num2;
                textBox2.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox2.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox2.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox2.Text = result.ToString();
                }
                else
                {
                    textBox2.Text = "DIV/Zero!";
                }
            }
        }
    }
}
