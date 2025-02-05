namespace CopyPaste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void copyButtonRight_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Clipboard.SetText(textBox1.Text);
                textBox2.Text = Clipboard.GetText();
                textBox1.Text = "";
            }
        }

        private void copyButtonLeft_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                Clipboard.SetText(textBox2.Text);
                textBox1.Text = Clipboard.GetText();
                textBox2.Text = "";
            }
        }
    }
}
