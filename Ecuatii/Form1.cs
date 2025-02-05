namespace Ecuatii
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
                double a = double.Parse(aTextBox.Text);
                double b = double.Parse(bTextBox.Text);
                double c = string.IsNullOrEmpty(cTextBox.Text) ? 0 : double.Parse(cTextBox.Text);

                if (c == 0)
                {
                    if (a != 0)
                    {
                        double linearSolution = -b / a;
                        linearLabel.Text = "Soluția ecuației liniare este: x = " + linearSolution;
                    }
                    else
                    {
                        linearLabel.Text = "Ecuația nu are soluție (a nu poate fi 0).";
                    }
                }

                if (c != 0)
                {
                    double discriminant = b * b - 4 * a * c;

                    if (discriminant > 0)
                    {
                        double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                        quadraticLabel.Text = "Soluțiile ecuației de gradul 2 sunt: x1 = " + x1 + " și x2 = " + x2;
                    }
                    else if (discriminant == 0)
                    {
                        double x = -b / (2 * a);
                        quadraticLabel.Text = "Soluția unică a ecuației de gradul 2 este: x = " + x;
                    }
                    else
                    {
                        quadraticLabel.Text = "Ecuația de gradul 2 nu are soluții reale.";
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduceti coeficienti validi!");
            }
        }
    }
}
