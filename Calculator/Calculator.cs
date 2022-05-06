namespace Calculator
{
    using System;
    using System.Windows.Forms;

    public partial class Calculator : Form
    {
        // Initialize variables
        double operandOne = double.NaN;
        double operandTwo = double.NaN;
        string operation = string.Empty;
        double result;

        public Calculator()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // Remove the last value that was added
            var text = this.InputTextBox.Text;
            try
            {
                this.InputTextBox.Text = text.Remove(text.Length - 1, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input a number");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Reset text box and variables
            this.InputTextBox.Clear();
            operandOne = double.NaN;
            operandTwo = double.NaN;
            operation = string.Empty;
            result = double.NaN;
        }

        private void Number_Click(object sender, EventArgs e)
        {
            // When a number or decimal button is clicked, add that value to the text box
            Button number = (Button)sender;
            var text = this.InputTextBox.Text;
            if (text.Split('.').Length > 2)
            {
                MessageBox.Show("There is already a decimal");
                this.InputTextBox.Text = text + number.Text;
                this.InputTextBox.Text = text.Remove(text.Length - 1, 1);
            }
            else
            {
                this.InputTextBox.Text = text + number.Text;
            }
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            // When an operation is clicked, save the operation and first operand, then reset the text box
            Button button = (Button)sender;
            operation = button.Text;

            try
            {
                operandOne = Convert.ToDouble(this.InputTextBox.Text);
                this.InputTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input a number");
            }
        }

        private void SingleOperation_Click(object sender, EventArgs e)
        {
            // When an operation that requires only one operand is clicked, calculate the result and return it immediately
            Button button = (Button)sender;
            double localResult;
            double value = Convert.ToDouble(this.InputTextBox.Text);

            if (button.Text == "sqrt")
            {
                localResult = Math.Sqrt(value);
                this.InputTextBox.Text = Convert.ToString(localResult);
            }
            else if (button.Text == "1/X")
            {
                localResult = 1 / value;
                this.InputTextBox.Text = Convert.ToString(localResult);
            }
            else if (button.Text == "+/-")
            {
                localResult = value * -1;
                this.InputTextBox.Text = Convert.ToString(localResult);
            }
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            // When the equals is clicked, return the result of the operation on the two operands
            try
            {
                operandTwo = Convert.ToDouble(this.InputTextBox.Text);

                if (operation == "/")
                {
                    try
                    {
                        result = operandOne / operandTwo;
                        this.InputTextBox.Text = Convert.ToString(result);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot divide by 0");
                    }
                }
                else if (operation == "*")
                {
                    result = operandOne * operandTwo;
                    this.InputTextBox.Text = Convert.ToString(result);
                }
                else if (operation == "-")
                {
                    result = operandOne - operandTwo;
                    this.InputTextBox.Text = Convert.ToString(result);
                }
                else if (operation == "+")
                {
                    result = operandOne + operandTwo;
                    this.InputTextBox.Text = Convert.ToString(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input a number");
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            // Add number and decimal button clicks to event handler
            this.DecimalButton.Click += Number_Click;
            this.ZeroButton.Click += Number_Click;
            this.OneButton.Click += Number_Click;
            this.TwoButton.Click += Number_Click;
            this.ThreeButton.Click += Number_Click;
            this.FourButton.Click += Number_Click;
            this.FiveButton.Click += Number_Click;
            this.SixButton.Click += Number_Click;
            this.SevenButton.Click += Number_Click;
            this.EightButton.Click += Number_Click;
            this.NineButton.Click += Number_Click;

            // Add operations button clicks to event handler
            this.DivideButton.Click += Operation_Click;
            this.MultiplyButton.Click += Operation_Click;
            this.MinusButton.Click += Operation_Click;
            this.SignButton.Click += Operation_Click;
            this.PlusButton.Click += Operation_Click;

            // Add single operations button clicks to event handler
            this.SqrtButton.Click += SingleOperation_Click;
            this.ReciprocalButton.Click += SingleOperation_Click;
            this.SignButton.Click += SingleOperation_Click;
        }
    }
}
