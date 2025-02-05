namespace Transforma
{
    public partial class Form1 : Form
    {
        private string textBoxText = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void lowerCaseButton_Click(object sender, EventArgs e)
        {
            if (textBoxText == "")
            {
                textBoxText = textBox.Text;
            }
            textBox.Text = textBox.Text.ToLower();
        }

        private void upperCaseButton_Click(object sender, EventArgs e)
        {
            if (textBoxText == "")
            {
                textBoxText = textBox.Text;
            }
            textBox.Text = textBox.Text.ToUpper();
        }

        private void normalButton_Click(object sender, EventArgs e)
        {
            textBox.Text = textBoxText;
        }
    }
}
