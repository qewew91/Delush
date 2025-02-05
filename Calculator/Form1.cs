namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int firstOperand = int.Parse(firstOperandTextBox.Text);
                int secondOperand = int.Parse(secondOperandTextBox.Text);
                string @operator = operationTextBox.Text;

                int result = 0;
                bool validOperation = true;

                switch (@operator)
                {
                    case "+":
                        result = firstOperand + secondOperand;
                        break;

                    case "-":
                        result = firstOperand - secondOperand;
                        break;

                    case "*":
                        result = firstOperand * secondOperand;
                        break;

                    case "/":
                        if (secondOperand != 0)
                        {
                            result = firstOperand / secondOperand;
                        }
                        else
                        {
                            resultLabel.Text = "Eroare: Împărțire la 0!";
                            validOperation = false;
                        }
                        break;

                    case "%":
                        if (secondOperand != 0)
                        {
                            result = firstOperand % secondOperand;
                        }
                        else
                        {
                            resultLabel.Text = "Eroare: Împărțire la 0!";
                            validOperation = false;
                        }
                        break;

                    default:
                        resultLabel.Text = "Operator invalid!";
                        validOperation = false;
                        break;
                }

                if (validOperation)
                {
                    resultLabel.Text = "Rezultatul este: " + result.ToString();
                }
            }
            catch (FormatException)
            {
                resultLabel.Text = "Eroare: Introduceți doar numere întregi!";
            }
        }
    }
}
