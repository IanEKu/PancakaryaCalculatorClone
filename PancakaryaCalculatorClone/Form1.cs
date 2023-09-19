using System;
using System.Linq;

namespace PancakaryaCalculatorClone
{
    public partial class Form1 : Form
    {
        public static string num1 = "";
        public static string operation = "";
        public static string num2 = "";
        public static string calcResult = "";

        public Form1()
        {
            InitializeComponent();
        }

        public void clear()
        {
            topLabel.Text = "";
            num1 = "";
            num2 = "";
            operation = "";
        }

        public void setText()
        {
            if (calcResult != "")
            {
                topLabel.Text = num1 + " " + operation + " " + num2;
                resultLabel.Text = calcResult;
                return;
            }

            if (operation != "" && num2 != "")
            {
                resultLabel.Text = num2;
                return;
            }


            if (operation != "")
            {
                topLabel.Text = num1 + " " + operation;
                resultLabel.Text = "";
                return;
            }

            if (resultLabel.Text == num1)
            {
                return;
            }

            resultLabel.Text = num1;
        }

        public void operationHandler(string Operation)
        {
            if (calcResult != "")
            {
                num1 = calcResult;
                operation = Operation;
                calcResult = "";
                setText();
                return;
            }

            if (num1 == "")
            {
                return;
            }

            if (operation != "")
            {
                calculate();
                clear();
                num1 = calcResult;
                operation = Operation;
                calcResult = "";
                setText();
            }

            operation = Operation;
            setText();
        }

        public void numberButtonHandler(string number)
        {
            if (num2.Length == 16)
            {
                setText();
                return;
            }

            if (number == ",")
            {
                if (topLabel.Text != "" && !num2.Contains(","))
                {
                    num2 = (num2 == "") ? $"0{number}" : num2 + number;
                }
                else if (topLabel.Text == "" && !num1.Contains(","))
                {
                    num1 = (num1 == "") ? $"0{number}" : num1 + number;
                }
                setText();
                return;
            }

            if (operation != "")
            {
                num2 = (num2 == "0") ? number : num2 + number;
                setText();
                return;
            }

            if (num1.Length == 16)
            {
                setText();
                return;
            }

            num1 = (num1 == "0") ? number : num1 + number;
            calcResult = "";
            setText();
        }

        public void calculate()
        {
            if (operation == "")
            {
                MessageBox.Show("Do some math!");
                return;
            }
            double number1 = Convert.ToDouble(num1.Replace(",", "."));
            double number2 = Convert.ToDouble(num2.Replace(",", "."));

            if (number2 == 0 && operation == "/")
            {
                resultLabel.Text = "Can't divide by 0!";
                clear();
                return;
            }

            switch (operation)
            {
                case "X":
                    calcResult = (number1 * number2).ToString();
                    break;
                case "/":
                    calcResult = (number1 / number2).ToString().Replace(".", ",");
                    break;
                case "+":
                    calcResult = (number1 + number2).ToString();
                    break;
                case "-":
                    calcResult = (number1 - number2).ToString();
                    break;
                case "%":
                    calcResult = (number1 % number2).ToString();
                    break;
                default:
                    break;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            numberButtonHandler("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            numberButtonHandler("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            numberButtonHandler("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            numberButtonHandler("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            numberButtonHandler("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            numberButtonHandler("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            numberButtonHandler("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            numberButtonHandler("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            numberButtonHandler("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            numberButtonHandler("9");
        }

        private void modus_Click(object sender, EventArgs e)
        {
            operationHandler("%");
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operationHandler("/");
        }

        private void times_Click(object sender, EventArgs e)
        {
            operationHandler("X");
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operationHandler("-");
        }

        private void add_Click(object sender, EventArgs e)
        {
            operationHandler("+");
        }

        private void count_Click(object sender, EventArgs e)
        {
            calculate();
            resultLabel.Text = calcResult;
            Data.historyList.Add(num1 + " " + operation + " " + num2 + " = " + calcResult);
            setText();
            clear();
        }

        private void clearEntry_Click(object sender, EventArgs e)
        {
            if (topLabel.Text != "")
            {
                num2 = "";
                setText();
            }
            else
            {
                num1 = "";
                setText();
            }
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "0";
            clear();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (calcResult != "")
            {
                calcResult = "";
                resultLabel.Text = "0";
                return;
            }

            if (topLabel.Text != "")
            {
                if (num2.Length > 1)
                {
                    num2 = num2.Remove(num2.Length - 1);
                    setText();
                }
                else
                {
                    num2 = "0";
                    setText();
                }
            }
            else
            {
                if (num1.Length > 1)
                {
                    num1 = num1.Remove(num1.Length - 1);
                    setText();
                }
                else
                {
                    num1 = "0";
                    setText();
                }
            }
        }

        private void plusmin_Click(object sender, EventArgs e)
        {
            if (topLabel.Text != "")
            {
                if (num2.StartsWith("-"))
                {
                    num2 = num2.Remove(0, 1);
                    setText();
                }
                else
                {
                    num2 = "-" + num2;
                    setText();
                }
            }
            else
            {
                if (num1.StartsWith("-"))
                {
                    num1 = num1.Remove(0, 1);
                    setText();
                }
                else
                {
                    num1 = "-" + num1;
                    setText();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void history_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.ShowDialog();
        }

        private void information_Click(object sender, EventArgs e)
        {
            InformationForm informationForm = new InformationForm();
            informationForm.ShowDialog();
        }

        private void comma_Click(object sender, EventArgs e)
        {
            numberButtonHandler(",");
        }
    }
}