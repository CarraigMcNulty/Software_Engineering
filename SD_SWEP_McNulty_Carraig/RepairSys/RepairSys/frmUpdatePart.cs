
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RepairSys
{
    public partial class frmUpdatePart : Form
    {
        public frmUpdatePart()
        {
            InitializeComponent();
        }

        frmMainMenu parent;
        public frmUpdatePart(frmMainMenu Parent)
        {
            parent = Parent;
            InitializeComponent();
        }

        private void frmUpdatePart_Load(object sender, EventArgs e)
        {
            loadUpdateCombo();
            loadCombo();
        }

        private void cboListParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Parts.getListPartType(ds, cboSelectPart.Text);
            grdUpdatePart.DataSource = ds.Tables["part_TypeList"];
        }

        public void loadCombo()
        {//load combo with stockNo and Description for all stock DataSet ds = new DataSet(); ds = Stock.getStock(ds);
            DataSet ds = new DataSet();
            ds = Parts.getRegisteredParts(ds);

            for (int i = 0; i < ds.Tables["Parts"].Rows.Count; i++)
                cboSelectPart.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0'));
        }

        public void loadUpdateCombo()
        {//load combo with stockNo and Description for all stock DataSet ds = new DataSet(); ds = Stock.getStock(ds);
            DataSet ds = new DataSet();
            ds = Parts.getUnregisteredParts(ds);

            for (int i = 0; i < ds.Tables["Part_Type"].Rows.Count; i++)
                cboUpdatePart.Items.Add(ds.Tables[0].Rows[i][0].ToString());
        }


        private void btnUpdatePart_Click(object sender, EventArgs e)
        {

            if (grdUpdatePart.DataSource == null)
            {
                MessageBox.Show("Please select a Part", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtupdateModelNo.Text == "" || txtUpdateUnitPrice.Text == "" || cboUpdatePart.Equals(""))
            {
                MessageBox.Show("Part not Added! Please fill all fields provided", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //validation
            else if (!isValidPartCost(txtUpdateUnitPrice.Text))
                MessageBox.Show("Error! Invalid Cost Please enter a Decimal value", "add", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (txtupdateModelNo.Text != "")
            {
                if (txtUpdateUnitPrice.Text != "")
                {
                    decimal cost;
                    bool isNumerical = decimal.TryParse(txtUpdateUnitPrice.Text, out cost);
                    if (isNumerical == true)
                    {
                        if (cboUpdatePart.Text != "")
                        {

                            //instantiate Stock Object
                            Parts myPart = new Parts();
                            myPart.setCostPrice(Convert.ToDouble(txtUpdateUnitPrice.Text));
                            myPart.setPartModelNo(txtupdateModelNo.Text);
                            myPart.setPartType(cboUpdatePart.Text);

                            //INSERT Stock record into stock table
                            myPart.updPart(Convert.ToInt32(txtPartId.Text));

                            MessageBox.Show("Success! Part Updated", "Success! ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //reset UI
                            txtUpdateUnitPrice.Clear();
                            txtupdateModelNo.Clear();
                            txtPartId.Clear();
                            cboSelectPart.Items.Clear();
                            loadCombo();
                            grdUpdatePart.DataSource = null;
                            cboUpdatePart.SelectedIndex = -1;
                            cboSelectPart.SelectedIndex = -1;
                        }

                    }

                }


            }

            else
                MessageBox.Show("Error! All Update Fields must be filled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cboSelectPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Parts.getListPartType(ds, cboSelectPart.Text);
            grdUpdatePart.DataSource = ds.Tables["part_TypeList"];
        }

        private void grdUpdatePart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = grdUpdatePart.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtPartId.Text = row.Cells[0].Value.ToString();
                txtupdateModelNo.Text = row.Cells[1].Value.ToString();
                cboUpdatePart.Text = row.Cells[2].Value.ToString();
                txtUpdateUnitPrice.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            parent.Show();
        }

        public Boolean isValidPartCost(String cost)
        {
            Regex pattern = new Regex(@"^\d+\.\d{2}$");

            if (pattern.IsMatch(cost))
            {
                return true;
            }

            else { return false; }
        }
    }

}
