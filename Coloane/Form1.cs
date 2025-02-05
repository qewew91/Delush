namespace Coloane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            textBox1.Location = new System.Drawing.Point(50, 50);
            textBox2.Location = new System.Drawing.Point(50, 100);
            textBox3.Location = new System.Drawing.Point(50, 150);
            textBox4.Location = new System.Drawing.Point(50, 200);

            button1.Location = new System.Drawing.Point(200, 50);
            button2.Location = new System.Drawing.Point(200, 100);
            button3.Location = new System.Drawing.Point(200, 150);
            button4.Location = new System.Drawing.Point(200, 200);
        }
    }
}
