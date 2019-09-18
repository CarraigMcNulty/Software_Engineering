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
    public partial class frmListParts : Form
    {
        public frmListParts()
        {
            InitializeComponent();
        }

        frmMainMenu parent;
        public frmListParts(frmMainMenu Parent)
        {
            parent = Parent;
            InitializeComponent();
        }

        private void frmListPart_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Parts.getListParts(ds);
            grdListParts.DataSource = ds.Tables["ListParts"];
            loadCombo();
        }


        public void loadCombo()
        {
            DataSet ds = new DataSet();
            ds = Parts.getRegisteredParts(ds);

            for (int i = 0; i < ds.Tables["Parts"].Rows.Count; i++)
                cboListParts.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0'));
        }

        private void cboListParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Parts.getListPartType(ds, cboListParts.Text);
            grdListParts.DataSource = ds.Tables["part_TypeList"];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            parent.Show();
        }


        private void btnprint_Click(object sender, EventArgs e)
        {
            if (grdListParts.DataSource != null)
            {
                prntListParts.AllowSomePages = true;

                // Show the help button.
                prntListParts.ShowHelp = true;

                // Set the Document property to the PrintDocument for 
                // which the PrintPage Event has been handled. To display the
                // dialog, either this property or the PrinterSettings property 
                // must be set 
                prntListParts.Document = prntDocListParts;

                Margins margins = new Margins(100, 0, 100, 0);
               // prntDocListParts.DefaultPageSettings.Margins = margins;
                prntDocListParts.OriginAtMargins = true;

                DialogResult result = prntListParts.ShowDialog();

                // If the result is OK then print the document.
                if (result == DialogResult.OK)
                {
                    prntDocListParts.Print();
                }
            }
        }

        //taken from https://social.msdn.microsoft.com/Forums/vstudio/en-US/b8bcf81c-fe03-451b-965d-0757bfad1e4f/how-do-i-print-out-a-datagridview?forum=csharpgeneral
        private void prntListParts_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
            foreach (DataGridViewColumn dc in grdListParts.Columns)
            {

                //MessageBox.Show("dc = " + dc);

                g.DrawString(dc.HeaderText, boldFont, Brushes.Black, (float)columnPosition, (float)rowPosition);

                if (dc.Index == 1)
                {
                    columnPosition += 295;
                }

                else
                columnPosition += dc.Width + 5; // adds to colPos. value the width value of the column + 5.
            }

            return columnPosition;
        }

        private void DrawGridBody(Graphics g, ref int columnPosition, ref int rowPosition)
        {
            if (grdListParts.DataSource != null)
            {
                // loop through each row and draw the data to the graphics surface.
                foreach (DataRow dr in ((DataTable)grdListParts.DataSource).Rows)
                {
                    columnPosition = 0;

                    // draw a line to separate the rows 
                    g.DrawLine(Pens.Black, new Point(-3000, rowPosition), new Point(3000, rowPosition));

                    // loop through each column in the row, and draw the individual data item
                    foreach (DataGridViewColumn dc in grdListParts.Columns)
                    {
                        // draw string in the column
                        string text = dr[dc.DataPropertyName].ToString();
                        g.DrawString(text, this.Font, Brushes.Black, (float)columnPosition, (float)rowPosition + 10f); // the last number (10f) sets the space between the black line (ruler) and the text below it.

                       

                        if(dc.Index == 1 )
                        {
                            columnPosition += 295;
                        }

                        else // go to the next column position
                            columnPosition += dc.Width + 5;                        
                    }
                    // go to the next row position
                    rowPosition = rowPosition + 35; // this sets the space between the row text and the black line below it (ruler).
                }
            }
        }

        private void btnShowParts_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Parts.getListParts(ds);
            grdListParts.DataSource = ds.Tables["ListParts"];
        }
    }
}


