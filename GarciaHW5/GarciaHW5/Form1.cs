using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarciaHW5
{
    //Ismael Garcia 
    //Assignment 5
    //Present Value
    //Due Date 3-18-16

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Declare variables
        double future, interest, years, present;

        private double PresentValue(double futureCalc, double interestCalc, double yearCalc)
        { // Math Equation
            return (futureCalc / (Math.Pow((1 + interestCalc), (yearCalc))));
            
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                //assigns the text boxes
                
                interest = double.Parse(InterestTextBox.Text) / 100;
                future = double.Parse(futureTextBox.Text);
                years = double.Parse(numberTextBox.Text);

                present = PresentValue(future, interest, years);
                PresentLabel.Text = present.ToString("c");

            }
            catch
            { //display error message
                MessageBox.Show("Please Enter Numeric value","Error");
            }

            

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear the boxes
            futureTextBox.Clear();
            InterestTextBox.Clear();
            numberTextBox.Clear();
            PresentLabel.Text = "";

        }

        

        private void exitButton_Click(object sender, EventArgs e)
        {
            // this will close the program
            this.Close();
        }




        
    }
}
