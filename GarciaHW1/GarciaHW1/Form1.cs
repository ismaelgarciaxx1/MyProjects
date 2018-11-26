using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarciaHW1
{  //Ismael Garcia
    // Homework 1
    // Card Identifier
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AcePictureBox_Click(object sender, EventArgs e)
        {
            //This should display the ace of diamonds 
            NameLabel.Text = "Ace of Diamonds";
        }

        private void KingBox_Click(object sender, EventArgs e)
        {
            //This should display the King of diamonds
            NameLabel.Text = "King of Diamonds";
        }

        private void QueenBox_Click(object sender, EventArgs e)
        {
            //This should display the Queen of diamonds
            NameLabel.Text = "Queen of Diamonds";
        }

        private void JackBox_Click(object sender, EventArgs e)
        {
            //This should display the Jack of diamonds
            NameLabel.Text = "Jack of Diamonds";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //This should display the Ten of diamonds
            NameLabel.Text = "Ten of Diamonds";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //This should close the application
            this.Close();
        }
    }
}
