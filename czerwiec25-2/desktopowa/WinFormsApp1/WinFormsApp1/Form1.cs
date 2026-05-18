using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(keyValueText.Text, out int key)) key = 0;

            encyptedText.Text = encryptString(inputText.Text, key);
        }

        string encryptString(string input, int key)
        {
            input = input.ToLower();
            key = key % 26;
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    output.Append(' ');
                    continue;
                }

                if (input[i] + key > 'z')
                {
                    output.Append((char)(input[i] + key - 26));
                }
                else if (input[i] + key < 'a')
                {
                    output.Append((char)(input[i] + key + 26));
                }
                else
                {
                    output.Append((char)(input[i] + key));
                }
            }
            return output.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using FileDialog fileDialog = new SaveFileDialog();
            fileDialog.ShowDialog();
            File.WriteAllText(fileDialog.FileName, encyptedText.Text);
        }
    }
}
