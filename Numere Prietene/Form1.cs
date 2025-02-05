namespace Numere_Prietene
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void determineButton_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                if (AreFriendlyNumbers(num1, num2))
                {
                    resultLabel.Text = $"{num1} și {num2} sunt numere prietene.";
                }
                else
                {
                    resultLabel.Text = $"{num1} și {num2} nu sunt numere prietene.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input! Please enter valid integers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AreFriendlyNumbers(int a, int b)
        {
            return SumOfDivisors(a) == b && SumOfDivisors(b) == a;
        }

        private int SumOfDivisors(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
