using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkPrice_Click(object sender, EventArgs e)
        {
            if (postcardButton.Checked)
            {
                pictureBox.Image = desktop.Properties.Resources.pocztowka;
                priceLabel.Text = "Cena: 1zł";
            }
            if (letterButton.Checked)
            {
                pictureBox.Image = desktop.Properties.Resources.list;
                priceLabel.Text = "Cena: 1,5zł";
            }
            if (packageButton.Checked)
            {
                pictureBox.Image = desktop.Properties.Resources.paczka;
                priceLabel.Text = "Cena: 10zł";
            }

        }
       
        bool checkForNumbers(String text)
        {

            for (int i = 0; i < text.Length; i++)
            {
                if (!Char.IsDigit(codeTextBox.Text[i]))
                {
                   
                    return true;
                }

            }

            return false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(codeTextBox.Text.Length != 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
            }
            else if (checkForNumbers(codeTextBox.Text))
            {
                MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr");
            }
            else
            {
                MessageBox.Show("Dane przesyłki zostały wprowadzone");
            }
            
            
        }
        
    }
}
