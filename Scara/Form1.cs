namespace Scara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            button1.Size = new Size(30, 80);
            button2.Size = new Size(30, 80);
            button3.Size = new Size(30, 80);
            button4.Size = new Size(30, 80);
            button5.Size = new Size(30, 80);

            button1.Location = new Point(0, this.ClientSize.Height - 80);
            button2.Location = new Point(button1.Location.X + 30, button1.Location.Y - 80);
            button3.Location = new Point(button2.Location.X + 30, button2.Location.Y - 80);
            button4.Location = new Point(button3.Location.X + 30, button3.Location.Y - 80);
            button5.Location = new Point(button4.Location.X + 30, button4.Location.Y - 80);
        }
    }
}
