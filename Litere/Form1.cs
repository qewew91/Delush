using System.Text;

namespace Litere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void excludeButton_Click(object sender, EventArgs e)
        {
            string initialText = arrayTextBox.Text;

            if (string.IsNullOrEmpty(initialText))
            {
                resultLabel.Text = "Introduceți un șir de caractere!";
                return;
            }

            StringBuilder textWithoutDigits = new StringBuilder();

            foreach (char c in initialText)
            {
                if (!Char.IsDigit(c))  
                {
                    textWithoutDigits.Append(c);  
                }
            }

            resultLabel.Text = "Șirul fără cifre este: " + textWithoutDigits.ToString();
        }
    }
}
