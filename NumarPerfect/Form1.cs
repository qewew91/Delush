namespace NumarPerfect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBox1.Text);
                int sum = SumOfDivisors(num);

                if (sum == num)
                {
                    resultLabel.Text = $"{num} este un număr perfect.";
                }
                else if (sum > num)
                {
                    resultLabel.Text = $"{num} este un număr supraperfect.";
                }
                else
                {
                    resultLabel.Text = $"{num} este un număr imperfect.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input! Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
