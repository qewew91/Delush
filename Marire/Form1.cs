namespace Marire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            centerButton();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            int width = plusButton.Size.Width;
            int height = plusButton.Size.Height;

            plusButton.Size = new Size((int) (width + .15f * width), (int) (height + height * .15f));

            centerButton();

            if (plusButton.Size.Width >= this.Size.Width || plusButton.Size.Height >= this.Size.Height)
            {
                this.Close();
                return;
            }

        }

        private void centerButton()
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            int buttonWidth = plusButton.Width;
            int buttonHeight = plusButton.Height;

            int centerX = (formWidth - buttonWidth) / 2;
            int centerY = (formHeight - buttonHeight) / 2;

            plusButton.Location = new Point(centerX, centerY);
        }
    }
}
