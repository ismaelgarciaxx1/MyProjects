using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarciaHW7
{
    //Ismael Garcia
    //Assignment 7
    //Due Date 4/8/16
    //Vending Machine

        //structure
    struct Drinks
    {
        public string drinkName;
        public decimal drinkCost;
        public int drinkCount;
    }

    public partial class Form1 : Form
    {

        Drinks cola = new Drinks();
        Drinks creamSoda = new Drinks();
        Drinks grapeSoda = new Drinks();
        Drinks lemonLime = new Drinks();
        Drinks rootBeer = new Drinks();


        private void CreateDrinks()
        {
            
            cola = new Drinks();
            creamSoda = new Drinks();
            grapeSoda = new Drinks();
            lemonLime = new Drinks();
            rootBeer = new Drinks();

            //setting the amount of drinks avaliable
            cola.drinkCount = 20;
            creamSoda.drinkCount = 20;
            grapeSoda.drinkCount = 20;
            lemonLime.drinkCount = 20;
            rootBeer.drinkCount = 20;

            //setting the price of the drinks
            cola.drinkCost = 1.00m;
            creamSoda.drinkCost = 1.50m;
            grapeSoda.drinkCost = 1.50m;
            lemonLime.drinkCost = 1.00m;
            rootBeer.drinkCost = 1.00m;

            //setting the names of the drinks
            cola.drinkName = "cola";
            creamSoda.drinkName = "Cream Soda";
            grapeSoda.drinkName = "Grape Soda";
            lemonLime.drinkName = "Lemon Lime";
            rootBeer.drinkName = "Root Beer";

        }
        //declare variable
        decimal total;

        

        public Form1()
        {
            InitializeComponent();
        }

        

        private void exitButton_Click(object sender, EventArgs e)
        {
            //this will close the program
            this.Close();
        }

        private void cokePictureBox_Click(object sender, EventArgs e)
        { 
            
            if (cola.drinkCount > 0)
            {
                // this will display the total of colas sold in the total label
                totalLabel.Text = (total += cola.drinkCost).ToString("C");
                //this will subtract one from the amount of drinks left
                cola.drinkCount--;
                //this displays the amount of drinks left
                colaLeftLabel.Text = cola.drinkCount.ToString();

            }
            else
            {
                //this message will display when the amount of drinks reaches zero
                MessageBox.Show("Sorry out of cola");
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this will load the void i created when the program starts
            CreateDrinks();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (creamSoda.drinkCount > 0)
            {
                // this will display and add the total of drinks sold in the total label
                totalLabel.Text = (total += creamSoda.drinkCost).ToString("C");
                //subtracts one from the amount of drinks left
                creamSoda.drinkCount--;
                //display the amount of drinks left
                creamLeftLabel.Text = creamSoda.drinkCount.ToString();
            }
            else
            {
                //this message will show when the amount of drinks reaches zero
                MessageBox.Show("Sorry out of cream soda");
            }
        }

        private void grapPictureBox_Click(object sender, EventArgs e)
        {
            if (grapeSoda.drinkCount > 0)
            {
                // this will display and add the total of drinks sold in the total label
                totalLabel.Text = (total += grapeSoda.drinkCost).ToString("C");
                //subtracts one from the amount of drinks left
                grapeSoda.drinkCount--;
                //display the amount of drinks left
                grapeLeftLabel.Text = grapeSoda.drinkCount.ToString();
            }
            else
            {
                //this message will show when the amount of drinks reaches zero
                MessageBox.Show("Sorry out of Grape Soda");
            }
        }

        private void LemonPictureBox_Click(object sender, EventArgs e)
        {
            if (lemonLime.drinkCount > 0)
            {
                // this will display and add the total of drinks sold in the total label
                totalLabel.Text = (total += lemonLime.drinkCost).ToString("C");
                //subtracts one from the amount of drinks left
                lemonLime.drinkCount--;
                //display the amount of drinks left
                lemonLeftLabel.Text = lemonLime.drinkCount.ToString();
            }
            else
            {
                //this message will show when the amount of drinks reaches zero
                MessageBox.Show("Sorry out of Lemon Lime");
            }
        }

        private void rootPictureBox_Click(object sender, EventArgs e)
        {
            if (rootBeer.drinkCount > 0)
            {
                // this will display and add the total of drinks sold in the total label
                totalLabel.Text = (total += rootBeer.drinkCost).ToString("C");
                //subtracts one from the amount of drinks left
                rootBeer.drinkCount--;
                //display the amount of drinks left
                rootLeftLabel.Text = rootBeer.drinkCount.ToString();
            }
            else
            {
                //this message will show when the amount of drinks reaches zero
                MessageBox.Show("Sorry out of Root Beer");
            }
        }
    }
}
