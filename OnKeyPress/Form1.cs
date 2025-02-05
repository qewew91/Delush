namespace OnKeyPress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'q' || e.KeyChar == 'Q')
            {
                textBox1.Text = textBox1.Text + textBox1.Text;
            }
            else if (e.KeyChar == 'w' || e.KeyChar == 'W')
            {
                textBox1.Text = textBox1.Text + textBox1.Text + textBox1.Text;
            }
            else if (e.KeyChar == 'e' || e.KeyChar == 'E')
            {
                textBox1.Clear();
            }
            else if (e.KeyChar == 'r' || e.KeyChar == 'R')
            {
                this.Text = textBox1.Text;
            }
        }
    }
}
