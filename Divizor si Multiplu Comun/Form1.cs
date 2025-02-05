namespace Divizor_si_Multiplu_Comun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private int LCM(int a, int b)
        {
            return Math.Abs(a * b) / GCD(a, b);
        }


        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numar1 = int.Parse(textBox1.Text);
                int numar2 = int.Parse(textBox2.Text);

                int gcd = GCD(numar1, numar2);

                int lcm = LCM(numar1, numar2);

                resultLabel.Text = $"Cel mai mare divizor comun (GCD): {gcd}\nCel mai mic multiplu comun (LCM): {lcm}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduceți valori valide pentru numerele întregi!");
            }
        }
    }
}
