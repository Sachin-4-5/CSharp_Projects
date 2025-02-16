using System.Net.Quic;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //Global variables
        private decimal firstValue = 0.0m;
        private decimal secondValue = 0.0m;
        private decimal result = 0.0m;
        private string operators = "+";

        public Form1()
        {
            InitializeComponent();
        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "0";
            }
            else
            {
                TxtBox.Text += "0";
            }
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!TxtBox.Text.Contains("."))
            {
                TxtBox.Text += ".";
            }
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "1";
            }
            else
            {
                TxtBox.Text += "1";
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "2";
            }
            else
            {
                TxtBox.Text += "2";
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "3";
            }
            else
            {
                TxtBox.Text += "3";
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "4";
            }
            else
            {
                TxtBox.Text += "4";
            }
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "5";
            }
            else
            {
                TxtBox.Text += "5";
            }
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "6";
            }
            else
            {
                TxtBox.Text += "6";
            }
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "7";
            }
            else
            {
                TxtBox.Text += "7";
            }
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "8";
            }
            else
            {
                TxtBox.Text += "8";
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "9";
            }
            else
            {
                TxtBox.Text += "9";
            }
        }

        private void MinusPlusBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text.Contains("-"))
            {
                TxtBox.Text = TxtBox.Text.Trim('-');
            }
            else
            {
                TxtBox.Text = "-" + TxtBox.Text;
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "-";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "+";
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "/";
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "*";
        }

        private void ModuloBtn_Click(object sender, EventArgs e)
        {
            firstValue = decimal.Parse(TxtBox.Text);
            TxtBox.Clear();
            operators = "%";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    secondValue = decimal.Parse(TxtBox.Text);
                    result = firstValue - secondValue;
                    TxtBox.Text = result.ToString();
                    break;

                case "+":
                    secondValue = decimal.Parse(TxtBox.Text);
                    result = firstValue + secondValue;
                    TxtBox.Text = result.ToString();
                    break;

                case "*":
                    secondValue = decimal.Parse(TxtBox.Text);
                    result = firstValue * secondValue;
                    TxtBox.Text = result.ToString();
                    break;

                case "/":
                    secondValue = decimal.Parse(TxtBox.Text);
                    result = firstValue / secondValue;
                    TxtBox.Text = result.ToString();
                    break;

                case "%":
                    secondValue = decimal.Parse(TxtBox.Text);
                    result = firstValue % secondValue;
                    TxtBox.Text = result.ToString();
                    break;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            firstValue = 0.0m;
            secondValue = 0.0m;
            TxtBox.Text = "0";
        }
    }
}
