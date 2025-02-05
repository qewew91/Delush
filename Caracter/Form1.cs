namespace Caracter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void excludeATextBox_TextChanged(object sender, EventArgs e)
        {
            string input = excludeATextBox.Text;
            excludeATextBox.Text = input.Replace("a", "");
            doubleATextBox.Text = input.Replace("a", "aa");
            tripleATextBox.Text = input.Replace("a", "aaa");
        }
    }
}
