namespace Varsta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                int age = int.Parse(ageTextBox.Text);

                int weight = 2 * age + 8;
                int height = 5 * age + 80;

                weightLabel.Text = "Greutatea este: " + weight.ToString() + " kg";
                heightLabel.Text = "Inălțimea este: " + height.ToString() + " cm";
            }
            catch (FormatException)
            {
                weightLabel.Text = "Eroare: Introduceți o vârstă validă!";
                heightLabel.Text = string.Empty;
            }
        }
    }
}
