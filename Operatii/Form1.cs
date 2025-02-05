namespace Operatii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = defaultButton;
            this.CancelButton = cancelButton;
        }

        private void defaultButton_Click(object sender, EventArgs e)
        {
            defaultButton.Text = "Am tastat enter";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
