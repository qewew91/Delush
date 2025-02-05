namespace Combinari
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
                int n = int.Parse(nTextBox.Text);
                int m = int.Parse(mTextBox.Text);
                if (n < 0 || m < 0 || m > n)
                {
                    MessageBox.Show("Invalid input: Ensure n >= r >= 0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int result = Factorial(n) / (Factorial(m) * Factorial(n - m));
                resultLabel.Text = $"C({n}, {m}) = {result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input! Please enter valid integers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int Factorial(int num)
        {
            if (num == 0 || num == 1)
                return 1;
            int fact = 1;
            for (int i = 2; i <= num; i++)
                fact *= i;
            return fact;
        }
    }
}
