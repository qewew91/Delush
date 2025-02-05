using System.Diagnostics;

namespace DeplasareSageti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int moveLabelX = moveLabel.Location.X;
            int moveLabelY = moveLabel.Location.Y;
            int width = this.Size.Width;
            int height = this.Size.Height;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    moveLabel.Location = new Point((int)(moveLabelX - moveLabelX * .15f), moveLabelY);
                    break;
                case Keys.Right:
                    moveLabel.Location = new Point((int)(moveLabelX + moveLabelX * .15f), moveLabelY);
                    break;
                case Keys.Up:
                    moveLabel.Location = new Point(moveLabelX, (int)(moveLabelY - moveLabelY * .15f));
                    break;
                case Keys.Down:
                    moveLabel.Location = new Point(moveLabelX, (int)(moveLabelY + moveLabelY * .15f));
                    break;
                default:
                    Debug.WriteLine("didnt press");
                    break;
            }

            if (moveLabel.Location.X <= 0)
            {
                moveLabel.Location = new Point(width - moveLabel.Width, moveLabelY);
            }
            if (moveLabel.Location.X >= width)
            {
                moveLabel.Location = new Point(0, moveLabelY);
            }
            if (moveLabel.Location.Y <= 0)
            {
                moveLabel.Location = new Point(moveLabelX, height + moveLabel.Height);
            }
            if (moveLabel.Location.Y >= height)
            {
                moveLabel.Location = new Point(moveLabelX, 0);
            }
        }
    }
}
