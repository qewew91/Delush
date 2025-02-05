namespace Sir_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            string phrase = phraseTextBox.Text;
            string word = wordTextBox.Text;

            if (string.IsNullOrEmpty(phrase) || string.IsNullOrEmpty(word))
            {
                resultLabel.Text = "Vă rugăm să introduceți atât fraza cât și cuvântul!";
                return;
            }

            int numarAparitii = 0;
            int pozitie = 0;

            while ((pozitie = phrase.IndexOf(word, pozitie)) != -1)
            {
                numarAparitii++;
                pozitie += word.Length;  
            }

            resultLabel.Text = "Numărul de apariții ale cuvântului: " + numarAparitii.ToString();
        }
    }
}
