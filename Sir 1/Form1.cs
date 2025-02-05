namespace Sir_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string phrase = phraseTextBox.Text;
            string word = wordTextBox.Text;

            // Verificăm dacă cuvântul există în frază
            int pozitie = phrase.IndexOf(word, StringComparison.OrdinalIgnoreCase);

            if (pozitie != -1)
            {
                // Dacă cuvântul este găsit, afișăm poziția în Label
                resultLabel.Text = "Poziția inițială a cuvântului: " + pozitie.ToString();
            }
            else
            {
                // Dacă cuvântul nu este găsit, afișăm mesajul corespunzător
                resultLabel.Text = "Cuvântul nu a fost găsit în frază.";
            }
        }
    }
}
