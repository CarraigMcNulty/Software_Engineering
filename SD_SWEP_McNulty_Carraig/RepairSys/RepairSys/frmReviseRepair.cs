using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairSys
{
    public partial class frmReviseRepair : Form
    {
        DataSet ds = new DataSet();
        string titletext = "Estimate Cost Rep Id: ";

        public frmReviseRepair()
        {
            InitializeComponent();
        }

        frmMainMenu parent;
        public frmReviseRepair(frmMainMenu Parent)
        {
            parent = Parent;
            InitializeComponent();

            grpSelectParts.Visible = false;
        }

        private void frmReviseRepair_Load(object sender, EventArgs e)
        {
        }

        private void rdoEstimated_Click(object sender, EventArgs e)
        {
            grdListRepair.Visible = true;
            DataSet ds = new DataSet();
            ds = Repair.filterRepairs(ds, "Estimated");
            grdListRepair.DataSource = ds.Tables["repairlist"];
            grdListRepair.ClearSelection();

            if (grdListRepair.RowCount < 0)
                grdListRepair.Visible = false;
        }

        private void rdoProcessing_CheckedChanged(object sender, EventArgs e)
        {
            grdListRepair.DataSource = null;
            grdListRepair.Visible = true;

            DataSet ds = new DataSet();
            ds = Repair.filterRepairs(ds, "Estimated");
            grdListRepair.DataSource = ds.Tables["repairlist"];

            grdListRepair.ClearSelection();

            if (grdListRepair.RowCount < 0)
            {
                grdListRepair.Visible = false;
            }
        }

        private void rdoEstimated_CheckedChanged(object sender, EventArgs e)
        {
            grdListRepair.DataSource = null;

            DataSet ds = new DataSet();
            ds = Repair.filterRepairs(ds, "Processing");
            grdListRepair.DataSource = ds.Tables["repairlist"];

            grdListRepair.ClearSelection();

            if (grdListRepair.RowCount <= 0)
            {
                grdListRepair.Dispose();
            }
        }

        private void rdoProcessing_Click(object sender, EventArgs e)
        {
            grdListRepair.DataSource = null;

            DataSet ds = new DataSet();
            ds = Repair.filterRepairs(ds, "Processing");
            grdListRepair.DataSource = ds.Tables["repairlist"];

            grdListRepair.ClearSelection();

            if (grdListRepair.RowCount <= 0)
            {
                grdListRepair.Visible = false;
            }
        }

        private void grdListRepair_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && grdListRepair.CurrentCell != null)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = grdListRepair.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtRepID.Text = row.Cells[0].Value.ToString();

                int rowindex = grdListRepair.CurrentCell.RowIndex;
                int id = Convert.ToInt32(grdListRepair.Rows[rowindex].Cells[0].Value.ToString());
                txtRepairDesc.Text = Repair.getDescription(id);
                lblCustEmail.Text = Repair.getEmail(id);

                pnlRepDesc.Visible = true;
                btnSelectRepair.Visible = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            parent.Show();
        }

        private void btnSelectRepair_Click(object sender, EventArgs e)
        {
            if (grdListRepair.SelectedRows.Count > 0)
            {
                lblEstimateTitle.Visible = true;
                grpSelectRepair.Visible = false;
                //pnlAddedParts[label10,base .Visible = true;
                grpSelectParts.Visible = true;
                //repairParts = RepairTableData.createTable();
                lblEstimateTitle.Text += txtRepID.Text;
                loadCombo();
            }
        }

        public void loadCombo()
        {
            DataSet ds = new DataSet();
            ds = Parts.getRegisteredParts(ds);

            for (int i = 0; i < ds.Tables["Parts"].Rows.Count; i++)
                cboListParts.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0'));
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            grdAddedParts.DataSource = null;
            grpSelectRepair.Visible = true;

            DataSet dsReloadRepair = new DataSet();
            dsReloadRepair = Repair.filterRepairs(dsReloadRepair, "Estimated");
            grdListRepair.DataSource = dsReloadRepair.Tables["repairlist"];

            pnlQuantity.Visible = false;
            lblCostNum.Text = "0";
            lblEstimateTitle.Text = titletext;
            grpSelectRepair.Enabled = true;
            grpSelectParts.Enabled = false;
            cboListParts.SelectedIndex = -1;
            ds.Clear();
            cboListParts.Items.Clear();
        }

        private void cboListParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            numQuantity.Value = 1;
            DataSet ds = new DataSet();
            ds = Parts.getListPartType(ds, cboListParts.Text);
            grdShowParts.DataSource = ds.Tables["Repair_Parts"];
        }

        private void grdShowParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlQuantity.Visible = true;
        }

        private void btnRemovePart_Click(object sender, EventArgs e)
        {
            if (grdAddedParts != null)
            {
                RepairTableData.removeRepairPart(grdAddedParts, grdShowParts, ds.Tables["Repair_Parts"]);
                lblCostNum.Text = RepairTableData.calculateRepairCost(ds.Tables["Repair_Parts"]);
            }

            if (grdAddedParts.RowCount == 0)
            {
                pnlAddedParts.Visible = false;
                btnReviseRepair.Visible = false;
            }
        }

        private void btnEstimateCost_Click(object sender, EventArgs e)
        {
            if (grdAddedParts.RowCount > 0)
            {
                DataGridViewRow selectedPart = grdAddedParts.Rows[grdAddedParts.CurrentCell.RowIndex];
                //instantiate part Object
                RepairParts myRepairParts = new RepairParts();

                myRepairParts.setRepID(Convert.ToInt32(txtRepID.Text));

                myRepairParts.deleteRepairParts();

                foreach (DataRow row in ds.Tables["Repair_Parts"].Rows)
                {
                    int pId = Convert.ToInt32(row[0]);
                    int quantity = Convert.ToInt32(row[2]);

                    myRepairParts.setPartID(pId);
                    myRepairParts.setQuantity(quantity);
                    myRepairParts.addToRepairParts();
                    grdListRepair.ClearSelection();
                }

                Repair.updateRepairCost(myRepairParts.getRepairID(), Convert.ToDouble(lblCostNum.Text));
                Repair.updateRepairStatus(myRepairParts.getRepairID(), "Estimated");

                MessageBox.Show("Parts added to Repair: " + txtRepID.Text + "\n Customer has been notified by email", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblEstimateTitle.Visible = false;
                pnlRepDesc.Visible = false;
                grdAddedParts.DataSource = null;
                grdShowParts.DataSource = null;
                grdListRepair.DataSource = null;
                pnlQuantity.Visible = false;
                grpSelectParts.Visible = false;
                grpSelectRepair.Visible = true;
                btnSelectRepair.Visible = false;
                cboListParts.SelectedIndex = -1;
                grdShowParts.DataSource = null;
                lblCostNum.Text = "";
                txtRepID.Text = "";
                lblEstimateTitle.Text = titletext;
                pnlAddedParts.Visible = false;
            }
        }

        private void btnSelectRepair_Click_1(object sender, EventArgs e)
        {
            if (grdListRepair.SelectedRows.Count > 0)
            {
                lblEstimateTitle.Visible = true;
                grpSelectParts.Enabled = true;
                grpSelectRepair.Enabled = false;
                lblEstimateTitle.Text += txtRepID.Text;
                grdListRepair.DataSource = null;

                loadCombo();
                grdAddedParts.DataSource = null;

                ds = RepairParts.getRepairParts(ds, Convert.ToInt32(txtRepID.Text));
                grdAddedParts.DataSource = ds.Tables["Repair_Parts"];
                lblCostNum.Text = RepairTableData.calculateRepairCost(ds.Tables["Repair_Parts"]);

                
                grpSelectParts.Visible = true;
            }
        }

        private void btnEstimateCost_Click_1(object sender, EventArgs e)
        {

            if (grdAddedParts.RowCount > 0)
            {
                DataGridViewRow selectedPart = grdAddedParts.Rows[grdAddedParts.CurrentCell.RowIndex];
                //instantiate part Object
                RepairParts myRepairParts = new RepairParts();

                myRepairParts.setRepID(Convert.ToInt32(txtRepID.Text));

                myRepairParts.deleteRepairParts();
                foreach (DataRow row in ds.Tables["Repair_Parts"].Rows)
                {
                    int pId = Convert.ToInt32(row[0]);
                    int quantity = Convert.ToInt32(row[2]);

                    myRepairParts.setPartID(pId);
                    myRepairParts.setQuantity(quantity);
                    myRepairParts.addToRepairParts();
                    grdListRepair.ClearSelection();
                }

                Repair.updateRepairCost(myRepairParts.getRepairID(), Convert.ToDouble(lblCostNum.Text));
                Repair.updateRepairStatus(myRepairParts.getRepairID(), "Estimated");


                
                Repair.sendInvoice(lblCustEmail.Text,"Revised",lblCostNum.Text);

                MessageBox.Show("Parts added to Repair: " + txtRepID.Text + "\n Customer has been notified by email", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblEstimateTitle.Visible = false;
                pnlRepDesc.Visible = false;
                grdAddedParts.DataSource = null;
                grdShowParts.DataSource = null;
                grdListRepair.DataSource = null;
                pnlQuantity.Visible = false;
                grpSelectParts.Enabled = false;
                grpSelectRepair.Enabled = true;
                btnSelectRepair.Visible = false;
                grpSelectRepair.Visible = true;
                lblCostNum.Text = "";
                ds = null;
                lblEstimateTitle.Text = titletext;
                rdoEstimated.Checked = false;
                rdoProcessing.Checked = false;
                btnReviseRepair.Visible = false;
            }

            DialogResult dialogResult = MessageBox.Show(" Would you like to change the description of the selected repair?", "Repair Description", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.Yes)
            {
                updaeRepDesc(this, txtRepairDesc.Text);
            }

            txtRepID.Text = "";
        }

        private void updaeRepDesc(frmReviseRepair Parent, String txtRepairDesc)
        {
            frmupRepDesc listRepairs = new frmupRepDesc(this, txtRepairDesc, txtRepID.Text);
            listRepairs.StartPosition = FormStartPosition.CenterScreen;
            listRepairs.Show();
        }

        private void grdListRepair_SelectionChanged_1(object sender, EventArgs e)
        {
            if (grdListRepair.CurrentCell != null && txtRepID.Text != "")
            {
                int rowindex = grdListRepair.CurrentCell.RowIndex;
                int id = Convert.ToInt32(grdListRepair.Rows[rowindex].Cells[0].Value.ToString());

                txtRepairDesc.Visible = true;
                txtRepairDesc.Text = Repair.getDescription(id);
            }

            else
            {
                txtRepairDesc.Text = "";
            }
        }

        private void cboListParts_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            numQuantity.Value = 1;
            DataSet dsListAvailableParts = new DataSet();
            dsListAvailableParts = Parts.getListPartType(dsListAvailableParts, cboListParts.Text);
            grdShowParts.DataSource = dsListAvailableParts.Tables["part_TypeList"];
        }

        private void btnAddtoRepair_Click_1(object sender, EventArgs e)
        {
            if (grdShowParts.CurrentCell != null)
            {
                int quantity = Convert.ToInt32(numQuantity.Value);
                pnlAddedParts.Visible = true;
                btnReviseRepair.Visible = true;

                grdAddedParts.DataSource = RepairTableData.createTableRow(grdAddedParts, grdShowParts, ds.Tables["Repair_Parts"], quantity);
                lblCostNum.Text = RepairTableData.calculateRepairCost(ds.Tables["Repair_Parts"]);
                pnlAddedParts.Enabled = true;
                btnReviseRepair.Visible = true;
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            parent.Show();
        }
    }
}
