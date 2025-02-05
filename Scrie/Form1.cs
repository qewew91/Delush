namespace Scrie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void allowButton_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void forbidButton_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }
    }
}
