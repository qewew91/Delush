using System.Text;

namespace ASCII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string textInitial = charTextBox.Text;

            if (string.IsNullOrEmpty(textInitial))
            {
                resultLabel.Text = "Introduceți caractere!";
                return;
            }

            StringBuilder ASCIIcodes = new StringBuilder();

            foreach (char c in textInitial)
            {
                ASCIIcodes.Append(((int)c).ToString() + " ");
            }

            resultLabel.Text = "Codurile ASCII sunt: " + ASCIIcodes.ToString();
        }
    }
}
