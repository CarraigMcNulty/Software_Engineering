using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairSys
{
    public partial class frmListRepairs : Form
    {
        public frmListRepairs()
        {
            InitializeComponent();
        }

        String buttonSelected = "";
        

        frmMainMenu parent;
        public frmListRepairs(frmMainMenu Parent)
        {
            parent = Parent;
            InitializeComponent();
        }

        private void frmListRepairs_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Repair.listRepairs(ds);
            grdListRepairs.DataSource = ds.Tables["repairlist"];
        }

        private void btnPendingFilter_Click(object sender, EventArgs e)
        {
            
            isPressed(btnPendingFilter, btnEstimated,  btnProcessing, btnCompleted);

            DataSet ds = new DataSet();
            ds = Repair.filterRepairs(ds, buttonSelected);
            
            grdListRepairs.DataSource = ds.Tables["repairlist"];
        }


        private void btnEstimated_Click(object sender, EventArgs e)
        {
            grdListRepairs.DataSource = null;
            DataSet ds = new DataSet();
            isPressed(btnEstimated,btnPendingFilter, btnProcessing,btnCompleted);
            
            ds = Repair.filterRepairs(ds, buttonSelected);
            grdListRepairs.DataSource = ds.Tables["repairlist"];
        }

        private void btnProcessing_Click(object sender, EventArgs e)
        {
            grdListRepairs.DataSource = null;

            isPressed(btnProcessing, btnPendingFilter, btnCompleted, btnEstimated);

            DataSet ds = new DataSet();
            ds = Repair.filterRepairs(ds, buttonSelected);

            grdListRepairs.DataSource = ds.Tables["repairlist"];
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            grdListRepairs.DataSource = null;
            isPressed(btnCompleted, btnPendingFilter, btnProcessing, btnEstimated);

            DataSet ds = new DataSet();
            ds = Repair.filterRepairs(ds, buttonSelected);
            grdListRepairs.DataSource = ds.Tables["repairlist"];


        }

        private void Clear_Click(object sender, EventArgs e)
        {
            btnPendingFilter.Enabled = true;
            btnProcessing.Enabled = true;
            btnEstimated.Enabled = true;
            btnCompleted.Enabled = true;
            pnlRepDetails.Visible = false;
            lblCustEmail.Visible = false;
            lblEmailtitle.Visible = false;
            txtRepairDesc.Visible = false;
            lblRepDesc.Visible = false;
            grdListRepairs.DataSource = null;
            txtRepairDesc.Text = "";

            DataSet ds = new DataSet();
            ds = Repair.listRepairs(ds);
            grdListRepairs.DataSource = ds.Tables["repairlist"]; 
            
        }

        private void grdListParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            int rowindex = grdListRepairs.CurrentCell.RowIndex;
            int id = Convert.ToInt32(grdListRepairs.Rows[rowindex].Cells[0].Value.ToString());

            txtRepairDesc.Text = Repair.getDescription(id);
            lblCustEmail.Text = Repair.getEmail(id);

            pnlRepDetails.Visible = true;
            lblCustEmail.Visible = true;
            lblEmailtitle.Visible = true;
            txtRepairDesc.Visible = true;
            lblRepDesc.Visible = true;
        }

        private void btnCloseList_Click(object sender, EventArgs e)
        {
            this.Dispose();
            parent.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (grdListRepairs.DataSource != null)
            {
                prntListRep.AllowSomePages = true;

                // Show the help button.
                prntListRep.ShowHelp = true;

                // Set the Document property to the PrintDocument for 
                // which the PrintPage Event has been handled. To display the
                // dialog, either this property or the PrinterSettings property 
                // must be set 
                prntListRep.Document = prntDocListRepairs;

                Margins margins = new Margins(100, 0, 100, 0);
                // prntDocListParts.DefaultPageSettings.Margins = margins;
                prntDocListRepairs.OriginAtMargins = true;

                DialogResult result = prntListRep.ShowDialog();

                // If the result is OK then print the document.
                if (result == DialogResult.OK)
                {
                    prntDocListRepairs.DefaultPageSettings.Landscape = true;
                    prntDocListRepairs.Print();
                }
            }

        }

        //taken from https://social.msdn.microsoft.com/Forums/vstudio/en-US/b8bcf81c-fe03-451b-965d-0757bfad1e4f/how-do-i-print-out-a-datagridview?forum=csharpgeneral
        private void prntListRepairs_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int columnPosition = 0;
            int rowPosition = 25;

            // run function to draw headers
            DrawHeader(new Font(this.Font, FontStyle.Bold), e.Graphics, ref columnPosition, ref rowPosition); // runs the DrawHeader function

            rowPosition += 35; // sets the distance below the header text and the next black line (ruler)

            // run function to draw each row
            DrawGridBody(e.Graphics, ref columnPosition, ref rowPosition);
        }

        private int DrawHeader(Font boldFont, Graphics g, ref int columnPosition, ref int rowPosition)
        {
            foreach (DataGridViewColumn dc in grdListRepairs.Columns)
            {

                //MessageBox.Show("dc = " + dc);

                g.DrawString(dc.HeaderText, boldFont, Brushes.Black, (float)columnPosition, (float)rowPosition);

                if (dc.Index == 6)
                {
                    columnPosition += dc.Width + 45;


                }

                else
                    columnPosition += dc.Width + 5; // adds to colPos. value the width value of the column + 5.
            }

            return columnPosition;
        }

        private void DrawGridBody(Graphics g, ref int columnPosition, ref int rowPosition)
        {
            if (grdListRepairs.DataSource != null)
            {
                // loop through each row and draw the data to the graphics surface.
                foreach (DataRow dr in ((DataTable)grdListRepairs.DataSource).Rows)
                {
                    columnPosition = 0;

                    // draw a line to separate the rows 
                    g.DrawLine(Pens.Black, new Point(-3000, rowPosition), new Point(3000, rowPosition));

                    // loop through each column in the row, and draw the individual data item
                    foreach (DataGridViewColumn dc in grdListRepairs.Columns)
                    {
                        // draw string in the column
                        string text = dr[dc.DataPropertyName].ToString();
                        g.DrawString(text, this.Font, Brushes.Black, (float)columnPosition, (float)rowPosition + 10f); // the last number (10f) sets the space between the black line (ruler) and the text below it.

                        if (dc.Index == 6)
                        {
                            columnPosition += dc.Width + 45;


                        }

                        else
                            columnPosition += dc.Width + 5;

                    }
                    // go to the next row position
                    rowPosition = rowPosition + 35; // this sets the space between the row text and the black line below it (ruler).
                }
            }
        }

        private void grdListRepairs_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        public String isPressed(Button enabledBtn, Button otherbtn1, Button otherbtn2, Button otherbtn3)
        {
            if (grdListRepairs.RowCount > 0)
            {
                grdListRepairs.DataSource = null;
            }

            buttonSelected = enabledBtn.Text;

            enabledBtn.Enabled = false;
            otherbtn1.Enabled = true;
            otherbtn2.Enabled = true;
            otherbtn3.Enabled = true;
            grdListRepairs.Focus();

            return buttonSelected;
        }
    }
}
