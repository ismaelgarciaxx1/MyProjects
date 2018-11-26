using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarciaHW10
{
    //Ismael Garcia
    //Assignment 10
    //Due Date 4-29-16
    //Database
    
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.populationDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'populationDataSet.City' table. You can move, or remove it, as needed.
            cityTableAdapter.Fill(this.populationDataSet.City);

        }

        private void cityButton_Click(object sender, EventArgs e)
        {
            //this will display by city name
            this.cityTableAdapter.FillByCity(this.populationDataSet.City);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this will display population by descending order
            this.cityTableAdapter.FillByPopulation(this.populationDataSet.City);
        }

        private void populatonAscendingButton_Click(object sender, EventArgs e)
        {
            //this will display population by ascending order
            this.cityTableAdapter.FillByPopulationAsc(this.populationDataSet.City);
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            int total;

            total = (int)this.cityTableAdapter.Total();

            MessageBox.Show("Total Population is: " + total.ToString("n0"));
        }

        private void avgButton_Click(object sender, EventArgs e)
        {
            decimal average;

            average = (decimal)this.cityTableAdapter.Average();

            MessageBox.Show("Average Population is: " + average.ToString("n"));
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            int max;

            max = (int)this.cityTableAdapter.Max();

            MessageBox.Show("Highest Population is: " + max.ToString("n0"));

        }

        private void minButton_Click(object sender, EventArgs e)
        {
            int min;

            min = (int)this.cityTableAdapter.MIN();

            MessageBox.Show("Lowest Population is: " + min.ToString("n0"));
        }
    }
}
