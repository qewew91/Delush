namespace Inversul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            string initialText = wordsTextBox.Text;

            if (string.IsNullOrEmpty(initialText))
            {
                resultLabel.Text = "Introduceți un șir de cuvinte!";
                return;
            }

            string[] words = initialText.Split(' ');

            string modifiedText = "";

            foreach (string word in words)
            {
                string cuvantInversat = ReverseString(word);
                modifiedText += cuvantInversat + " ";  
            }

            modifiedText = modifiedText.Trim();

            resultLabel.Text = "Șirul cu cuvintele inversate: " + modifiedText;
        }

        private string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
