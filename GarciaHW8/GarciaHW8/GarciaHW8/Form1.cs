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

namespace GarciaHW8
{
    //Ismael Garcia
    //Assignment 8
    //due 4/15/16
    //Person Entry

    public partial class MainForm : Form
    {
        List<PersonEntry> personList = new List<PersonEntry>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void readFile()
        {
            try
            {
               
                StreamReader inputFile;
                string line;

                char[] delim = {','};

                //this will open the file
                inputFile = File.OpenText("People.txt");

                //this loop will add until the end of the file
                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();

                    //this will assign tokens
                    string[] tokens = line.Split(delim);

                    var entry = new PersonEntry(tokens[0], tokens[1], tokens[2]);

                    personList.Add(entry);

                }

            }
            catch (Exception ex)
            {
                //display an error message
                MessageBox.Show(ex.Message);
            }
            
        }

        private void DisplayInfo(int i)
        {
            //Get the index of the selected item
            Info myInfo = new Info(personList[i].name, personList[i].email, personList[i].phoneNumbers);
            //display the info form
            myInfo.ShowDialog();
        }

        private void Display()
        {
           foreach (PersonEntry entry in personList)
            {   //this would add the names in the listbox
                peopleListBox.Items.Add(entry.name);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //this will close the program
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //read and dispaly the information when program loads
            readFile();
            Display();
        }

        private void peopleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display the correct info
            DisplayInfo(peopleListBox.SelectedIndex);
        }
    }
}
