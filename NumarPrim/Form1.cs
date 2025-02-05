using System.Text;

namespace NumarPrim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsPrime(int numar)
        {
            if (numar <= 1) return false; 
            for (int i = 2; i <= Math.Sqrt(numar); i++) 
            {
                if (numar % i == 0) return false; 
            }
            return true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numar = int.Parse(textBox1.Text);

                StringBuilder primeNumbers = new StringBuilder();

                for (int i = 2; i <= numar; i++)
                {
                    if (IsPrime(i))
                    {
                        primeNumbers.Append(i + " "); 
                    }
                }

                resultLabel.Text = primeNumbers.Length > 0 ? primeNumbers.ToString() : "Nu există numere prime în acest interval.";
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduceți un număr valid!");
            }
        }
    }
}
