using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarciaHW2
    // Ismael Garcia
    // Assignment 2
    // Due 2-19-16
    // Permit Revenue

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        { 
            //This will close the program
            this.Close();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {   
            try {

                Decimal westcom, eastcom, southcom, totalrev;
                const int westRev = 140, eastRev = 118, southRev = 118;

               
                westcom = Decimal.Parse(westTextBox.Text);
                eastcom = Decimal.Parse(eastTextBox.Text);
                southcom = Decimal.Parse(southTextBox.Text);

                // This will display the the total of each in the label box
                westLabel.Text = (westcom * westRev).ToString("c0");
                eastLabel.Text = (eastcom * eastRev).ToString("c0");
                southLabel.Text = (southcom * southRev).ToString("c0");

                // this is the calculation of total revenue
                totalrev = (westcom * westRev) + (eastcom * eastRev) + (southcom * southRev);

                // this will display the total revenue in the total label box
                totalLabel.Text = totalrev.ToString("c0");
            }
            catch
            {
                // this will display an error if something other than a number is entered
                MessageBox.Show("use numeric values only", "Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // this will clear the text and label boxes
            westTextBox.Text = "";
            eastTextBox.Text = "";
            southTextBox.Text = "";
            westLabel.Text = "";
            eastLabel.Text = "";
            southLabel.Text = "";
            totalLabel.Text = "";


        }
    }
}
