namespace Ghici_Numarul
{
    public partial class Form1 : Form
    {
        private int generatedNumber;

        public Form1()
        {
            InitializeComponent();
            GenerateNumber();
        }

        private void GenerateNumber()
        {
            Random random = new Random();
            generatedNumber = random.Next(0, 10);
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            try
            {
                int guessedNumber = int.Parse(guessedNumberTextBox.Text);

                if (guessedNumber == generatedNumber)
                {
                    resultLabel.Text = "Felicitări! Ai ghicit numărul!";
                }
                else
                {
                    resultLabel.Text = "Numărul generat a fost: " + generatedNumber.ToString();
                }

                GenerateNumber();
            }
            catch (FormatException)
            {
                resultLabel.Text = "Eroare: Introduceți un număr între 0 și 9!";
            }
        }
    }
}
