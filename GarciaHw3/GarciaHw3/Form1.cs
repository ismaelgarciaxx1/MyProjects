using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarciaHw3
    //Ismael Garcia
    //Homework 3
    //Due Date 3/4/16

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // Declare varibales, two string , inteagers

            string workshop , location;
            int days = 0, totalCost, registrationcost = 0, lodgingcost, lodgingFee = 0 ;




            try
            {

                workshop = WorkshopListBox.SelectedItem.ToString();
                location = LocationListBox.SelectedItem.ToString();

                if (workshop == "Handling Stress" && location == "Austin")
                {
                    days = 3;
                    lodgingFee = 150;
                    registrationcost = 1000;

                    // formula for to calculate
                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;


                    
                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");

                }
                else if (workshop == "Time Management" && location == "Chicago")
                {
                    days = 3;
                    lodgingFee = 225;
                    registrationcost = 800;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "Handling Stress" && location == "Chicago")
                {
                    days = 3;
                    lodgingFee = 225;
                    registrationcost = 1000;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "Handling Stress" && location == "Dallas")
                {
                    days = 3;
                    lodgingFee = 174;
                    registrationcost = 1000;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "Handling Stress" && location == "Orlando")
                {
                    days = 3;
                    lodgingFee = 300;
                    registrationcost = 1000;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "Handling Stress" && location == "Phoenix")
                {
                    days = 3;
                    lodgingFee = 175;
                    registrationcost = 1000;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "Handling Stress" && location == "Raleigh")
                {
                    days = 3;
                    lodgingFee = 150;
                    registrationcost = 1000;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "Time Management" && location == "Austin")
                {
                    days = 3;
                    lodgingFee = 150;
                    registrationcost = 800;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "Time Management" && location == "Dallas")
                {
                    days = 3;
                    lodgingFee = 174;
                    registrationcost = 800;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "Time Management" && location == "Orlando")
                {
                    days = 3;
                    lodgingFee = 300;
                    registrationcost = 800;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "Time Management" && location == "Phoenix")
                {
                    days = 3;
                    lodgingFee = 175;
                    registrationcost = 800;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "Time Management" && location == "Raleigh")
                {
                    days = 3;
                    lodgingFee = 150;
                    registrationcost = 800;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "Supervision Skills" && location == "Austin")
                {
                    days = 3;
                    lodgingFee = 150;
                    registrationcost = 1500;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "Supervision Skills" && location == "Chicago")
                {
                    days = 3;
                    lodgingFee = 225;
                    registrationcost = 1500;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if(workshop == "Supervision Skills" && location == "Dallas")
                {
                    days = 3;
                    lodgingFee = 174;
                    registrationcost = 1500;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "Supervision Skills" && location == "Orlando")
                {
                    days = 3;
                    lodgingFee = 300;
                    registrationcost = 1500;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "Supervision Skills" && location == "Phoenix")
                {
                    days = 3;
                    lodgingFee = 175;
                    registrationcost = 1500;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if(workshop == "Supervision Skills" && location == "Raleigh")
                {
                    days = 3;
                    lodgingFee = 150;
                    registrationcost = 1500;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "Negotiation" && location == "Austin")
                {
                    days = 5;
                    lodgingFee = 150;
                    registrationcost = 1300;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "Negotiation" && location == "Chicago")
                {
                    days = 5;
                    lodgingFee = 225;
                    registrationcost = 1300;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "Negotiation" && location == "Dallas")
                {
                    days = 5;
                    lodgingFee = 174;
                    registrationcost = 1300;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "Negotiation" && location == "Orlando")
                {
                    days = 5;
                    lodgingFee = 300;
                    registrationcost = 1300;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "Negotiation" && location == "Phoenix")
                {
                    days = 5;
                    lodgingFee = 175;
                    registrationcost = 1300;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "Negotiation" && location == "Raleigh")
                {
                    days = 5;
                    lodgingFee = 150;
                    registrationcost = 1300;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "How to Interview" && location == "Austin")
                {
                    days = 1;
                    lodgingFee = 150;
                    registrationcost = 500;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "How to Interview" && location == "Chicago")
                {
                    days = 1;
                    lodgingFee = 225;
                    registrationcost = 500;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "How to Interview" && location == "Dallas")
                {
                    days = 1;
                    lodgingFee = 174;
                    registrationcost = 500;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "How to Interview" && location == "Orlando")
                {
                    days = 1;
                    lodgingFee = 300;
                    registrationcost = 500;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "How to Interview" && location == "Phoenix")
                {
                    days = 1;
                    lodgingFee = 175;
                    registrationcost = 500;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
                else if (workshop == "How to Interview" && location == "Raleigh")
                {
                    days = 1;
                    lodgingFee = 150;
                    registrationcost = 500;


                    lodgingcost = days * lodgingFee;
                    totalCost = registrationcost + lodgingcost;

                    lodgingLabel.Text = lodgingcost.ToString("c0");
                    registrationLabel.Text = registrationcost.ToString("c0");
                    totalLabel.Text = totalCost.ToString("c0");
                }
            }
            catch
            {  // this will show an error message if list boxes are not selected
                MessageBox.Show("Please Select From Both List Boxes", "Error");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        { // this will clear the text boxes
            lodgingLabel.Text = "";
            registrationLabel.Text = "";
            totalLabel.Text = "";

        }
    }
}
