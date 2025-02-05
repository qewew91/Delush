namespace Cuvant_maxim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void determineButton_Click(object sender, EventArgs e)
        {
            string textInitial = wordsTextBox.Text;

            if (string.IsNullOrEmpty(textInitial))
            {
                resultLabel.Text = "Introduceți un șir de cuvinte!";
                return;
            }

            string[] words = textInitial.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                resultLabel.Text = "Introduceți cel puțin un cuvânt!";
                return;
            }

            string longestWord = words[0];

            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            resultLabel.Text = "Cel mai lung cuvânt este: " + longestWord;
        }
    }
}
