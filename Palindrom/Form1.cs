namespace Palindrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string cuvant = textBox1.Text;

            if (string.IsNullOrEmpty(cuvant))
            {
                resultLabel.Text = "Vă rugăm să introduceți un cuvânt!";
                return;
            }

            string cuvantInversat = ReverseString(cuvant);

            if (cuvant.Equals(cuvantInversat, StringComparison.OrdinalIgnoreCase))
            {
                resultLabel.Text = "Cuvântul este palindrom!";
            }
            else
            {
                resultLabel.Text = "Cuvântul nu este palindrom.";
            }
        }

        private string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

