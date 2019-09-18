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
    public partial class frmEstimate_cost : Form
    {
        DataTable repairParts;
        string titletext = "Estimate Cost Rep Id: ";

        public frmEstimate_cost()
        {
            InitializeComponent();

        }

        frmMainMenu parent;
        public frmEstimate_cost(frmMainMenu Parent)
        {
            parent = Parent;
            InitializeComponent();
            loadCombo();

            DataSet ds = new DataSet();
            ds = Repair.getRepairStatus(ds, "Pending");
            grdListRepair.DataSource = ds.Tables["status_List"];
        }

        private void frmEstimate_cost_Load(object sender, EventArgs e)
        {
            grdListRepair.ClearSelection();
            btnSelectRepair.Visible = false;
            pnlRepDesc.Visible = false;
            grpSelectParts.Enabled = false;

            if (grdListRepair.RowCount <= 0)
            {
                grdListRepair.Dispose();
            }
        }

        private void grdListRepair_SelectionChanged(object sender, EventArgs e)
        {


            if (grdListRepair.CurrentCell != null)
            {

                txtRepairDesc.Visible = true;
                
                int rowindex = grdListRepair.CurrentCell.RowIndex;

                int id = Convert.ToInt32(grdListRepair.Rows[rowindex].Cells[0].Value.ToString());

                txtRepairDesc.Text = Repair.getDescription(id);
                lblCustEmail.Text = Repair.getEmail(id);
            }

            else
            {
                txtRepairDesc.Text = "";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            parent.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblCostNum.Text = "0";
            lblEstimateTitle.Text = titletext;
            grpSelectRepair.Enabled = true;
            grpSelectParts.Enabled = false;
            cboListParts.Items.Clear();
            cboListParts.SelectedIndex = -1;
            grdShowParts.DataSource = null;
            grdAddedParts.DataSource = null;
            cboListParts.SelectedIndex = -1;
            grdListRepair.Enabled = true;
          

            DataSet ds = new DataSet();
            ds = Repair.getRepairStatus(ds, "Pending");
            grdListRepair.DataSource = ds.Tables["status_List"];
        }

        private void btnSelectRepair_Click(object sender, EventArgs e)
        {
            if (grdListRepair.SelectedRows.Count > 0)
            {
                lblEstimateTitle.Visible = true;
                grpSelectParts.Enabled = true;
                grpSelectRepair.Enabled = false;
                repairParts = RepairTableData.createTable();
                lblEstimateTitle.Text += txtRepID.Text;
                grdListRepair.DataSource = null;
                grpSelectParts.Enabled = true;
               
            }
        }

        private void grdListRepair_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = grdListRepair.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtRepID.Text = row.Cells[0].Value.ToString();
                pnlRepDesc.Visible = true;
                btnSelectRepair.Visible = true;
                
            }
        }

        private void grdShowParts_SelectionChanged(object sender, EventArgs e)
        {
            numQuantity.Value = 1;
        }

        private void btnEstimateCost_Click(object sender, EventArgs e)
        {

            if (grdAddedParts.RowCount > 0)
            {
                DataGridViewRow selectedPart = grdAddedParts.Rows[grdAddedParts.CurrentCell.RowIndex];
                RepairParts myRepairParts = new RepairParts();

                myRepairParts.setRepID(Convert.ToInt32(txtRepID.Text));
                myRepairParts.deleteRepairParts();

                foreach (DataRow row in repairParts.Rows)
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
                Repair.sendInvoice(lblCustEmail.Text,"Estimated","0");

                MessageBox.Show("Parts added to Repair: " + txtRepID.Text + "\n Customer has been notified by email", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                pnlRepDesc.Visible = false;
                grdAddedParts.DataSource = null;
                grdShowParts.DataSource = null;
                pnlQuantity.Visible = false;
                grpSelectParts.Enabled = false;
                grpSelectRepair.Enabled = true;
                cboListParts.SelectedIndex = -1;
                grdShowParts.DataSource = null;
                lblCostNum.Text = "";
                txtRepID.Text = "";
                lblEstimateTitle.Text = titletext;
                pnlAddedParts.Visible = false;
                grdListRepair.DataSource = null;
                lblCustEmail.Text = "";
                grdListRepair.Visible = true;
                btnSelectRepair.Visible = false;
                

                DataSet dsReload = new DataSet();
                dsReload = Repair.getRepairStatus(dsReload, "Pending");
                grdListRepair.DataSource = dsReload.Tables["status_List"];

                if (grdListRepair.RowCount <= 0)
                {
                    grdListRepair.Dispose();
                }

            }
        }

        private void cboSelectPartSelectedIndexChanged(object sender, EventArgs e)
        {
            numQuantity.Value = 1;
            DataSet ds = new DataSet();
            ds = Parts.getListPartType(ds, cboListParts.Text);
            grdShowParts.DataSource = ds.Tables["part_TypeList"];
        }

        public void loadCombo()
        {
            DataSet ds = new DataSet();
            ds = Parts.getRegisteredParts(ds);

            for (int i = 0; i < ds.Tables["Parts"].Rows.Count; i++)
                cboListParts.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0'));
        }

        private void btnAddtoRepair_Click(object sender, EventArgs e)
        {
            if (grdShowParts.CurrentCell != null)
            {
                int quantity = Convert.ToInt32(numQuantity.Value);

                pnlAddedParts.Visible = true;
                btnEstimateCost.Visible = true;

                grdAddedParts.DataSource = RepairTableData.createTableRow(grdAddedParts, grdShowParts, repairParts, quantity);
                lblCostNum.Text = RepairTableData.calculateRepairCost(repairParts);
                pnlAddedParts.Enabled = true;
            }
        }

        private void grdListRepair_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            btnSelectRepair.Visible = false;
            pnlRepDesc.Visible = false;
        }

        private void btnRemovePart_Click(object sender, EventArgs e)
        {
            if (grdAddedParts != null)
            {
                RepairTableData.removeRepairPart(grdAddedParts, grdShowParts, repairParts);
                lblCostNum.Text = RepairTableData.calculateRepairCost(repairParts);
            }

            if (grdAddedParts.RowCount == 0)
            {
                pnlAddedParts.Visible = false;
                btnEstimateCost.Visible = false;
                pnlAddedParts.Enabled = false;
            }

        }

        private void grdShowParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlQuantity.Visible = true;
        }
    }
}
