namespace Logare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void validationButton_Click(object sender, EventArgs e)
        {
            string name = "user";
            string password = "parola123";

            string userName = nameTextBox.Text;
            string userPassword = passwordTextBox.Text;

            if (userName == name && userPassword == password)
            {
                resultTextBox.Text = "Logare reușită!";
                this.Text = "LOGARE - " + userName;
            }
            else
            {
                resultTextBox.Text = "Logare eșuată! Verifică datele.";
            }
        }
    }
}
