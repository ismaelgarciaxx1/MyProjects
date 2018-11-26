using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarciaHW9
{
    //Ismael Garcia
    //Preferred Customer
    //Due Date 4/22/16

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
          // declare variables
        string name, address,phoneNumber, mail;
        bool customerMailingList;
        double amount;

       

        private void submitButton_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            nameLabel.Text = name;

            address = addressTextBox.Text;
            addressLabel.Text = address;

            phoneNumber = phoneTextBox.Text;
            phoneLabel.Text = phoneNumber;

            mail = mailTextBox.Text;

            //bool for mailing option
            if ( mail == "y")
            {
                customerMailingList = true;
                mailLabel.Text = "Yes";
            }
            else if(mail == "n")
            {
                customerMailingList = false;
                mailLabel.Text = "No";
            }

            //display the amount spend typed in the text box
            amount = double.Parse(spendTextBox.Text);
            amountLabel.Text = amount.ToString();

            PreferredCustomer preCust = new PreferredCustomer(customerMailingList, name, address, phoneNumber);
            //this will get the discount
            preCust.setcustAmount(amount);
            discountLabel.Text = preCust.getDiscount().ToString();
        }

       

        private void exitButton_Click(object sender, EventArgs e)
        {
            //this will close the program
            this.Close();
        }
    }
}
