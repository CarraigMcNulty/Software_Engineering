using System;
using System.Data;
using System.Windows.Forms;

namespace RepairSys
{
    public partial class frmCompleteRepair : Form
    {
        public frmCompleteRepair()
        {
            InitializeComponent();
        }

        frmMainMenu parent;
        public frmCompleteRepair(frmMainMenu Parent)
        {
            parent = Parent;
            InitializeComponent();
        }
        private void frmCompleteRepair_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Repair.filterRepairs(ds, "Processing");
            grdListRepairs.DataSource = ds.Tables["repairlist"];
            grdListRepairs.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to complete this repair? This process is irreversable", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if( txtDesc.Text != "")
            { 

                if (dialogResult == DialogResult.Yes )
                {
                    //retrieves the row index of the selected cell
                    int rowindex = grdListRepairs.CurrentCell.RowIndex;

                    //retrive the repair id froma the cell of the selected rowindex
                    int RepairId = Convert.ToInt32(grdListRepairs.Rows[rowindex].Cells[0].Value.ToString());
                
                    //Update the repair to the specified status
                    MessageBox.Show("Repair Completed" + "\n\n Customer has been emailed", "Completed", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Repair.updateRepairStatus(RepairId, "Completed");
                    Repair.sendInvoice(lblCustEmail.Text, "Completed","0");
                    Repair.setCompletionDate(RepairId);

                    DataSet ds = new DataSet();
                    ds = Repair.filterRepairs(ds, "Processing");
                    grdListRepairs.DataSource = ds.Tables["repairlist"];

                    grdListRepairs.ClearSelection();
                    txtDesc.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            parent.Show();
        }

        private void grdListRepairs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblCustEmail.Visible = true;
                //retrieves the row index of the selected cell
                int rowindex = grdListRepairs.CurrentCell.RowIndex;

                //retrive the repair id froma the cell of the selected rowindex
                int RepairId = Convert.ToInt32(grdListRepairs.Rows[rowindex].Cells[0].Value.ToString());

                txtDesc.Text = Repair.getDescription(RepairId);
                lblCustEmail.Text = Repair.getEmail(RepairId);
            }
        }
    }
}
