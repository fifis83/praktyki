using desktopowa.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktopowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void numeberTextBox_Leave(object sender, EventArgs e)
        {
            if(numberTextBox.Text == "444")
            {
                photoPictureBox.Image = null;
                fingerprintPictureBox.Image = null;
            }
            else
            {
                //Nie mam pojęcia jak inaczej to zrobić
                if(numberTextBox.Text == "000")
                {
                    photoPictureBox.Image = desktopowa.Properties.Resources._000_zdjecie;
                    fingerprintPictureBox.Image = desktopowa.Properties.Resources._000_odcisk;
                }
                else if (numberTextBox.Text == "111")
                {
                    photoPictureBox.Image = desktopowa.Properties.Resources._111_zdjecie;
                    fingerprintPictureBox.Image = desktopowa.Properties.Resources._111_odcisk;
                }
                else if (numberTextBox.Text == "222")
                {
                    photoPictureBox.Image = desktopowa.Properties.Resources._222_zdjecie;
                    fingerprintPictureBox.Image = desktopowa.Properties.Resources._222_odcisk;
                }
                else if (numberTextBox.Text == "333")
                {
                    photoPictureBox.Image = desktopowa.Properties.Resources._333_zdjecie;
                    fingerprintPictureBox.Image = desktopowa.Properties.Resources._333_odcisk;
                }
                else if (numberTextBox.Text == "555")
                {
                    photoPictureBox.Image = desktopowa.Properties.Resources._555_zdjecie;
                    fingerprintPictureBox.Image = desktopowa.Properties.Resources._555_odcisk_;
                }
                else if (numberTextBox.Text == "666")
                {
                    photoPictureBox.Image = desktopowa.Properties.Resources._666_zdjecie;
                    fingerprintPictureBox.Image = desktopowa.Properties.Resources._666_odcisk;
                }
            }
            
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text == "" || lastNameTextBox.Text == "")
            {
                MessageBox.Show("Wprwoadź dane");

            }
            else
            {
                string color = "";
                if (blueEyesButton.Checked) 
                {
                    color = "niebieski";
                }
                else if (greenEyesButton.Checked)
                {
                    color = "zielone";
                }
                else if (hazelEyesButton.Checked)
                {
                    color = "piwne";
                }
                MessageBox.Show(nameTextBox.Text + " " + lastNameTextBox.Text + " kolor oczu " + color);
            }
        }
    }
}
