namespace Replace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            string phrase = phraseTextBox.Text;
            string wordToReplace = replaceTextBox.Text;
            string newWord = toReplaceTextBox.Text;

            if (string.IsNullOrEmpty(phrase) || string.IsNullOrEmpty(wordToReplace) || string.IsNullOrEmpty(newWord))
            {
                resultLabel.Text = "Vă rugăm să completați toate câmpurile!";
                return;
            }

            string frazaInlocuita = phrase.Replace(wordToReplace, newWord);

            resultLabel.Text = "Fraza după înlocuire: " + frazaInlocuita;
        }
    }
}
