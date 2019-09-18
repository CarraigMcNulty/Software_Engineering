using System;
using System.Data;
using System.Windows.Forms;

namespace RepairSys
{
    public partial class frmCommenceRepair : Form
    {
        public frmCommenceRepair()
        {
            InitializeComponent();
        }

        frmMainMenu parent;
        public frmCommenceRepair(frmMainMenu Parent)
        {
            parent = Parent;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            parent.Show();
        }

        private void frmCommenceRepair_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Repair.filterRepairs(ds, "Estimated");
            grdListRepairs.DataSource = ds.Tables["repairlist"];

            grdListRepairs.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radNo.Checked)
            {
                MessageBox.Show("Error! Please confirm that the customer has agreed to pay the full amount of the repair cost  ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                radNo.Focus();
            }

            if (radYes.Checked)
            {
                DialogResult dialogResult = MessageBox.Show(" Please confirm that the user has agreed to pay the repair cost in full", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dialogResult == DialogResult.Yes)
                {
                    int rowindex = grdListRepairs.CurrentCell.RowIndex;
                    int repid = Convert.ToInt32(grdListRepairs.Rows[rowindex].Cells[0].Value.ToString());
                    double amountPaid = 00.00;

                    if (Payment.isExistingPayment(repid))
                    {
                        double paid = Payment.retrieverepCost(repid);
                        amountPaid = Convert.ToDouble(grdListRepairs.Rows[rowindex].Cells[1].Value) - paid;
                        pnlExistingPayment.Visible = true;
                    }

                    else
                    {
                        amountPaid = Convert.ToDouble(grdListRepairs.Rows[rowindex].Cells[1].Value.ToString());
                    }

                    Repair.sendInvoice(lblCustEmail.Text, "Processing","0");
                    MessageBox.Show("Repair status changed to Processing \n\nCustomer has been emailed", "Processing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Repair.updateRepairStatus(repid, "Processing");

                    Payment newPayment = new Payment(Payment.nextPaymentID(), repid, amountPaid);
                    newPayment.addPayments();

                    DataSet ds = new DataSet();
                    ds = Repair.filterRepairs(ds, "Estimated");

                    grdRepairParts.DataSource = null;
                    grdListRepairs.DataSource = ds.Tables["repairlist"];
                    radNo.Checked = true;
                    txtDesc.Text = "";
                    lblCustEmail.Text = "";
                    lblExistingPayment.Visible = false;


                }

            }
        }

        //if a repair has been revised this method will execute
        private void grdListRepairs_SelectionChanged(object sender, EventArgs e)
        {
            //if (grdListRepairs.CurrentCell == null)
            //{
            //    return;
            //}

            int rowindex = grdListRepairs.CurrentCell.RowIndex;
            int repid = Convert.ToInt32(grdListRepairs.Rows[rowindex].Cells[0].Value.ToString());
            double amountPaid = 00.00;

            if (Payment.isExistingPayment(repid))
            {
                double paidToDate = Payment.retrieverepCost(repid);
                amountPaid = Convert.ToDouble(grdListRepairs.Rows[rowindex].Cells[1].Value) - paidToDate;
                amountPaid = Math.Round(amountPaid, 2);
                lblAmountPaid.Text = paidToDate.ToString();
                lblExistingPayment.Visible = true;
                lblPaymenTitle.Visible = true;
                pnlExistingPayment.Visible = true;
            }

            else
            {
                pnlExistingPayment.Visible = false;
                lblPaymenTitle.Visible = false;
            }

            lblExistingPayment.Text = amountPaid.ToString();
        }

        private void grdListRepairs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowindex = grdListRepairs.CurrentCell.RowIndex;
                int id = Convert.ToInt32(grdListRepairs.Rows[rowindex].Cells[0].Value.ToString());

      

                txtDesc.Text = Repair.getDescription(id);
                lblCustEmail.Text = Repair.getEmail(id);

                lblCustEmail.Visible = true;
                lblEmailTitle.Visible = true;
                pnlConfirmation.Visible = true;
                radNo.Checked = true;

                DataSet ds = new DataSet();
                ds = RepairParts.getRepairParts(ds,id);
                grdRepairParts.DataSource = ds.Tables["repair_parts"];
            }
        }
    }
}
