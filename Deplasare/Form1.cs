namespace Deplasare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void moveForm(string to)
        {
            int currentX = this.Location.X;
            int currentY = this.Location.Y;

            float moveX = currentX * .2f;
            float moveY = currentY * .2f;

            switch(to)
            {
                case "up":
                    this.Location = new Point(currentX, (int)(currentY - moveY));
                    break;
                case "down":
                    this.Location = new Point(currentX, (int)(currentY + moveY));
                    break;
                case "left":
                    this.Location = new Point((int)(currentX - moveX), currentY);
                    break;
                case "right":
                    this.Location = new Point((int)(currentX + moveX), currentY);
                    break;
            }
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            moveForm("right");
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            moveForm("left");
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            moveForm("up");
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            moveForm("down");
        }
    }
}
