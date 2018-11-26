using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarciaHW8
{
    public partial class Info : Form
    {

        public Info(string name, string email, string phonenumbers)
        {
            InitializeComponent();

            nameLabel.Text = name;
            emailLabel.Text = email;
            phoneLabel.Text = phonenumbers;
            
        }

            
        

        private void Info_Load(object sender, EventArgs e)
        {
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
