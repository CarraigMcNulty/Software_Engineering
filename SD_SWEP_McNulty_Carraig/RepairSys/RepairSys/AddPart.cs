using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RepairSys
{
    public partial class frmAddPart : Form
    {
        public frmAddPart()
        {
            InitializeComponent();
        }

        frmMainMenu parent;
        public frmAddPart(frmMainMenu Parent)
        {
            parent = Parent;
            InitializeComponent();
        }

        private void frmAddPart_Load(object sender, EventArgs e)
        {
            txtPartID.Text = Parts.nextPartID().ToString("000");
            loadCombo();
        }

        public void loadCombo()
        {//load combo 
            DataSet ds = new DataSet();
            ds = Parts.getUnregisteredParts(ds);

            for (int i = 0; i < ds.Tables["Part_Type"].Rows.Count; i++)
                cboAddParts.Items.Add(ds.Tables[0].Rows[i][0].ToString());
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            if (validatePart(txtCost.Text, txtModelNo.Text))
            {

                //instantiate part Object
                Parts myPart = new Parts(txtModelNo.Text, double.Parse(txtCost.Text), cboAddParts.Text, Int32.Parse(txtPartID.Text));


                //INSERT part record into part table
                myPart.addPart();

                //Display Confirmation Message
                MessageBox.Show("Part " + cboAddParts.Text + " Registered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //reset UI
                txtCost.Clear();
                txtModelNo.Clear();
                txtPartID.Clear();

                txtPartID.Text = Parts.nextPartID().ToString();
            }
        }

        public Boolean validatePart(String cost, String model_no)
        {
            bool isValidModelNo = Parts.validateUniqueModelNo(txtModelNo.Text);
            Boolean isNotValid = false;

            if (txtCost.Text == "" || txtModelNo.Text == "" || cboAddParts.Equals(""))
            {

                MessageBox.Show("Part not Added! Please fill all fields provided", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return isNotValid;
            }

            else if (!isValidCost(cost))
            {
                MessageBox.Show("Part not Added! Please enter a numeric cost to two decimal places", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return isNotValid;
            }

            else if (!isValidModelNo)
            {

                MessageBox.Show("Part Model Already Exisits! Please Enter a unique Model Number", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return isNotValid;
            }

            else
            {
                isNotValid = true;
                return isNotValid;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            parent.Show();
        }


        public Boolean isValidCost(String cost)
        {
            Regex pattern = new Regex(@"^\d+\.\d{2}$");

            if (pattern.IsMatch(cost))
            {
                return true;
            }

            else { return false; }
        }

        private void cboAddPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPartDescription.Visible = true;
            lblPartDescription.Text = Parts.getPartDetail("Description", cboAddParts.Text);
        }
    }
}
