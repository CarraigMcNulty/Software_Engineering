using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairSys
{
    public partial class frmLogRepair : Form
    {
        public frmLogRepair()
        {
            InitializeComponent();
        }

        frmMainMenu parent;
        public frmLogRepair(frmMainMenu Parent)
        {
            parent = Parent;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            parent.Show();
        }

        private void frmLogRepair_Load(object sender, EventArgs e)
        {
            txtRepairID.Text = Repair.nextRepairID().ToString("000");
           
        }

        private void btnLogRepair_Click(object sender, EventArgs e)
        {
          
            if(isValidEntry(txtEmail.Text , txtPhone_No.Text))
            { 

            //instantiate part Object
            Repair myRepair = new Repair(ValidateText(txtForename.Text), ValidateText(txtSurname.Text), txtPhone_No.Text, ValidateText(txtRepDescription.Text), Int32.Parse(txtRepairID.Text),txtEmail.Text.ToLower());

            //INSERT part record into part table
            myRepair.logRepair();

            //Display Confirmation Message
            MessageBox.Show("Repair "+txtRepairID.Text + "  logged \n\n The repair staus has been set to Pending\n\n" + "Customer Name: "+txtForename.Text + " "+ txtSurname.Text +"\n\nCustomer has been notified by email. ", "Log Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Repair.sendInvoice(txtEmail.Text, "Logged", "0");

            //reset UI
            txtForename.Clear();
            txtEmail.Clear();
            txtPhone_No.Clear();
            txtRepDescription.Clear();
            txtSurname.Clear();
            txtRepairID.Text = Repair.nextRepairID().ToString();
            }

          
        }

        private string ValidateText(string text)
        {
            string escapeText = "";

            foreach (char letter in  text)
            {
                if (letter == '\'')
                {
                    escapeText += "''";
                }

                else
                escapeText += letter;   
            }
            return escapeText;
        }

        public bool isValidEntry(String inStr , String phoneNo)
        {
            int validPhoneNo = 0;
        

            if (txtForename.Text == "" || txtPhone_No.Text == "" || txtSurname.Equals("") || txtRepDescription.Text == "" || txtEmail.Text == "")
            {

                MessageBox.Show("Please fill all fields provided", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            else if (!Regex.IsMatch(inStr, @"^[A-Z0-9._++-]+@[A-Z0-9.-]+\.[A-Z]{2,}$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                MessageBox.Show("Please enter a valid email", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }


            else if (!Int32.TryParse(phoneNo, out validPhoneNo))
            { 
                MessageBox.Show("Please enter a valid phone number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone_No.Focus();
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}
