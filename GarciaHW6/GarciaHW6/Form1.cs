using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GarciaHW6
{
    //Ismael Garcia
    //Assignment 6
    //Due 4/1/16
    //Population information

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // declaring variables 
        decimal average;
        int total, times, increase, i, poptotal, min;
        const int SIZE = 41;
        int[] Population = new int[SIZE];



        private void calcButton_Click(object sender, EventArgs e)
        {   // get the information out of the text file
            try
            {
                StreamReader inputPopulation;
                inputPopulation = File.OpenText("USPopulation.txt");

                while (!inputPopulation.EndOfStream)
                {

                    Population[times] = Int32.Parse(inputPopulation.ReadLine());
                    InfoListBox.Items.Add(Population[times]);

                    times++;
                }

                inputPopulation.Close();

                // the formula to find the average

                total = Population.Sum();
                average = total / SIZE;

                averageLabel.Text = average.ToString("n0");

               poptotal = Population.Count();

                for(i = 1; i < poptotal; i++)
                {   // show the increase of the years in the list box
                    increase = Population[i] - Population[i - 1];
                    IncreaseListBox.Items.Add(increase + "       " + (1950 + i).ToString());
                }
                
                var numbers = IncreaseListBox.Items.Cast<object>().Select(obj => Convert.ToString(obj));

                string min = numbers.Min();
                string max = numbers.Max();
                greatestLabel.Text = max.ToString();
                lowestLabel.Text = min.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void exitButton_Click(object sender, EventArgs e)
        {// this will close the program
            this.Close();
        }
    }
}
