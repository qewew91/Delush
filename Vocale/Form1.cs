namespace Vocale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text.ToLower(); 

            int vocalCount = 0;

            foreach (char c in text)
            {
                if ("aeiouy".Contains(c))
                {
                    vocalCount++;
                }
            }

            this.Text = $"Număr de vocale: {vocalCount}";
        }
    }
}
