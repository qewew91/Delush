using System.Diagnostics;

namespace IncrementareDecrementare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void incrementButton_Click(object sender, EventArgs e)
        {
            int title = int.Parse(this.Text);
            title++;
            this.Text = title.ToString();
        }

        private void decrementButton_Click(object sender, EventArgs e)
        {
            int title = int.Parse(this.Text);
            title--;
            this.Text = title.ToString();
        }
    }
}
