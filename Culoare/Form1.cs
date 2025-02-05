namespace Culoare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void blackButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void whiteButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
