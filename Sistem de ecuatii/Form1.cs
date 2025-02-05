namespace Sistem_de_ecuatii
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
                double a1 = double.Parse(textBox1.Text);
                double b1 = double.Parse(textBox2.Text);
                double c1 = double.Parse(textBox3.Text);
                double a2 = double.Parse(textBox4.Text);
                double b2 = double.Parse(textBox5.Text);
                double c2 = double.Parse(textBox6.Text);

                double det_d = a1 * b2 - a2 * b1; 
                double det_x = c1 * b2 - c2 * b1; 
                double det_y = a1 * c2 - a2 * c1; 

                if (det_d == 0)
                {
                    xLabel.Text = "Sistemul nu are soluții unice.";
                    yLabel.Text = "";
                }
                else
                {
                    double x = det_x / det_d;
                    double y = det_y / det_d;

                    xLabel.Text = "x = " + x;
                    yLabel.Text = "y = " + y;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduceți coeficienti validi!");
            }
        }
    }
}
