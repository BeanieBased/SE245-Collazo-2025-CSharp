using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MidTermCorrectThistime;
using Validation;

namespace MidTerm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void subButton_Click(object sender, EventArgs e)
        {
            Customer temp = new Customer();

            temp.Fname = FnameTextBox.Text;
            temp.Mname = MnameTextBox.Text;
            temp.Lname = LnameTextBox.Text;
            temp.Street1 = street1TextBox.Text;
            temp.Street2 = street2TextBox.Text;
            temp.City = cityTextBox.Text;
            temp.State = stateTextBox.Text;
            temp.Zip = zipTextBox.Text;
            temp.Phone = phoneTextBox.Text;
            temp.Email = emailTextBox.Text;


            //Person2

            temp.CellPhone = cellPhoneTextBox.Text;
            temp.InstagramURL = instagramURLBox.Text;


            //Customer
            temp.CustomerSince = customerSinceBox.Value;
            temp.TotalPurchases = (double)totalPurchBox.Value;
            temp.DiscountMember = memberBox.Checked;
            temp.RewardsEarned = (int)rewardsBox.Value;

            feedbackBox.Text = temp.feedbackClass;
        }
    }
}
