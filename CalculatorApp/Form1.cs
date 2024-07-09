using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private string currentInput = string.Empty;
        private string operation = string.Empty;
        private double firstNumber, secondNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (textBox_Result.Text == "0")
                textBox_Result.Clear();

            currentInput += button.Text;
            textBox_Result.Text = currentInput;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (double.TryParse(textBox_Result.Text, out firstNumber))
            {
                operation = button.Text;
                currentInput = string.Empty;
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_Result.Text, out secondNumber))
            {
                switch (operation)
                {
                    case "+":
                        textBox_Result.Text = (firstNumber + secondNumber).ToString();
                        break;
                    case "-":
                        textBox_Result.Text = (firstNumber - secondNumber).ToString();
                        break;
                    case "*":
                        textBox_Result.Text = (firstNumber * secondNumber).ToString();
                        break;
                    case "/":
                        if (secondNumber != 0)
                            textBox_Result.Text = (firstNumber / secondNumber).ToString();
                        else
                            textBox_Result.Text = "Error";
                        break;
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            currentInput = string.Empty;
            operation = string.Empty;
        }
    }
}
