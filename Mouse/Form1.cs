namespace Mouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crCrossButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
        }

        private void crHelpButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Help;
        }

        private void crNoDropButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.No;
        }
    }
}
