namespace Triunghi
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
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);

                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    MessageBox.Show("Valorile introduse nu formează un triunghi valid.");
                    return;
                }

                double perimeter = a + b + c;

                double semiPerimeter = perimeter / 2;

                double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));

                string triangleType;
                double longestSide = Math.Max(a, Math.Max(b, c));
                if (Math.Abs(a * a + b * b - c * c) < 0.001 || Math.Abs(a * a + c * c - b * b) < 0.001 || Math.Abs(b * b + c * c - a * a) < 0.001)
                {
                    triangleType = "Dreptunghic";
                }
                else if (a * a + b * b > c * c && a * a + c * c > b * b && b * b + c * c > a * a)
                {
                    triangleType = "Ascuțit";
                }
                else
                {
                    triangleType = "Obtuz";
                }

                triangleTypeLabel.Text = "Tipul triunghiului: " + triangleType;
                areaLabel.Text = "Aria triunghiului: " + area.ToString("F2");
                perimeterLabel.Text = "Perimetrul triunghiului: " + perimeter.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduceți valori valide pentru laturi!");
            }
        }
    }
}
