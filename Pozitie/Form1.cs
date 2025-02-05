namespace Pozitie
{
    public partial class Form1 : Form
    {

        private Point moveTo;
        int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        int screenHeight = Screen.PrimaryScreen.Bounds.Height;


        public Form1()
        {
            InitializeComponent();
        }

        private void leftUpperCornerButton_Click(object sender, EventArgs e)
        {
            moveTo = new Point(0, 0);
        }

        private void rightUpperCornerButton_Click(object sender, EventArgs e)
        {
            moveTo = new Point(screenWidth - this.Width, 0);
        }

        private void centerButton_Click(object sender, EventArgs e)
        {
            moveTo = new Point((screenWidth - this.Width) / 2, (screenHeight - this.Height) / 2);
        }

        private void rightLowerCornerButton_Click(object sender, EventArgs e)
        {
            moveTo = new Point(screenWidth - this.Width, screenHeight - this.Height);
        }

        private void leftLowerCornerButton_Click(object sender, EventArgs e)
        {
            moveTo = new Point(0, screenHeight - this.Height);
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            this.DesktopLocation = moveTo;
        }
    }
}
