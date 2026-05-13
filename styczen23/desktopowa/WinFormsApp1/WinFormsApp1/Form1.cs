using Microsoft.VisualBasic.FileIO;
using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string lowerCaseLetters = "abcdefghijklmnopqrstuwvxyz";
        string allLetters = "abcdefghijklmnopqrstuwvxyzQWERTYUIOPASDFGHJKLZXCVBNM";
        string numbers = "1234567890";
        string specialChars = "!@#$%^&*()_+-=";

        string password = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Dane praconika: {nameInput.Text} {surnameInput.Text} {occupationComboBox.Text} Hasło: {password}");
        }

        private void genPassBtn_Click(object sender, EventArgs e)
        {
            int passLength = int.Parse(charsNrInput.Text);
            StringBuilder newPass = new StringBuilder();
            Random rand = new Random();

            for (int i = 0; i < passLength; i++)
            {
                if (upperLowerCaseCheckbox.Checked)
                {
                    newPass.Append(allLetters[rand.Next(allLetters.Length)]);
                }
                else
                {
                    newPass.Append(lowerCaseLetters[rand.Next(lowerCaseLetters.Length)]);
                }
            }

            if (numbersCheckbox.Checked)
            {
                newPass[0] = numbers[rand.Next(numbers.Length)];
            }

            if (specialCharsChekbox.Checked)
            {
                newPass[1] = specialChars[rand.Next(specialChars.Length)];
            }

            password = newPass.ToString();
            MessageBox.Show(password);
        }
    }
}
