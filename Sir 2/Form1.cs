namespace Sir_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void excludeTextBox_Click(object sender, EventArgs e)
        {
            string phrase = phraseTextBox.Text;
            string word = wordTextBox.Text;

            if (phrase.Contains(word))
            {
                string rezultat = phrase.Replace(word, "");

                resultLabel.Text = "Fraza după excludere: " + rezultat;
            }
            else
            {
                resultLabel.Text = "Cuvântul nu a fost găsit în frază.";
            }
        }
    }
}
