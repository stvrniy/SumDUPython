using System;
using System.Windows.Forms;

namespace laba8forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Обробник зміни тексту для textBox1
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Обробник зміни тексту для textBox2
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Calculate('+');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculate('-');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculate('*');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculate('/');
        }

        private void Calculate(char operation)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            MessageBox.Show("Ділення на нуль неможливе!");
                        break;
                }

                label1.Text = "Результат: " + result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні числа.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Обробка події кліка на мітку label1
            // Ви можете написати відповідний код для обробки цієї події тут
        }
    }
}
