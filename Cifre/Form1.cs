namespace Cifre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CounyButton_Click(object sender, EventArgs e)
        {
            string numbers = numberTextBox.Text;

            if (string.IsNullOrEmpty(numbers) || !IsValidDigits(numbers))
            {
                resultLabel.Text = "Introduceți doar cifre!";
                return;
            }

            Dictionary<char, int> numbersFrequency = new Dictionary<char, int>();

            foreach (char number in numbers)
            {
                if (numbersFrequency.ContainsKey(number))
                {
                    numbersFrequency[number]++;
                }
                else
                {
                    numbersFrequency[number] = 1;
                }
            }

            char biggestNumber = '\0', smallestNumber = '\0';
            int maxNumOfAppearances = 0, minNumOfAppearances = int.MaxValue;

            foreach (var entry in numbersFrequency)
            {
                if (entry.Value > maxNumOfAppearances)
                {
                    maxNumOfAppearances = entry.Value;
                    biggestNumber = entry.Key;
                }

                if (entry.Value < minNumOfAppearances)
                {
                    minNumOfAppearances = entry.Value;
                    smallestNumber = entry.Key;
                }
            }

            resultLabel.Text = $"Cifra care apare cel mai des: {biggestNumber} ({maxNumOfAppearances} apariții)\n" +
                               $"Cifra care apare cel mai rar: {smallestNumber} ({minNumOfAppearances} apariții)\n" +
                               "Frecvența fiecărei cifre:\n";

            foreach (var entry in numbersFrequency)
            {
                resultLabel.Text += $"{entry.Key}: {entry.Value} apariții\n";
            }
        }

        private bool IsValidDigits(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
