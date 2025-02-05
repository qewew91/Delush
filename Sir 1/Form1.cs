﻿namespace Sir_1
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

            int pozitie = phrase.IndexOf(word, StringComparison.OrdinalIgnoreCase);

            if (pozitie != -1)
            {
                resultLabel.Text = "Poziția inițială a cuvântului: " + pozitie.ToString();
            }
            else
            {
                resultLabel.Text = "Cuvântul nu a fost găsit în frază.";
            }
        }
    }
}
