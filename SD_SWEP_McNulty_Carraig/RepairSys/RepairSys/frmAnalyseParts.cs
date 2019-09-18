using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace RepairSys
{
    public partial class frmAnalyseParts : Form
    {
        public frmAnalyseParts()
        {
            InitializeComponent();
        }

        frmMainMenu parent;
        public frmAnalyseParts(frmMainMenu Parent)
        {

            this.parent = Parent;
            InitializeComponent();
        }

        private void frmAnalyseParts_Load(object sender, EventArgs e)
        {
            loadcombo();
        }

        public void loadcombo()
        {
            DataSet year = new DataSet();
            year = Payment.GetYears(year);
            for (int i = 0; i < year.Tables["year"].Rows.Count; i++)
                cboYear.Items.Add(year.Tables[0].Rows[i][0].ToString());


            chtData.Visible = false;
            chtData.Titles.Add("Parts Revenue");
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Parts.analysePartsChart(cboYear.SelectedItem.ToString(), dt);

            //order the arrays N and M
            string[] N = new string[dt.Rows.Count];
            decimal[] M = new decimal[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                N[i] = dt.Rows[i][1].ToString();
                M[i] = Convert.ToDecimal(dt.Rows[i][0]);
            }

            chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtData.ChartAreas[0].AxisY.Interval = 5;

            chtData.Series[0].LegendText = "Income in €";

            chtData.Series["Series1"]["PointWidth"] = ".5";

            chtData.Series["Series1"]["PixelPointWidth"] = "20";
            chtData.Series[0].Points.DataBindXY(N, M);
            chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

            //chtSales.Series[0].Points[0] = "XXX";
            //chtData.Series[0].Label = "#VALY";

            //chtData.ChartAreas[0].AxisX.LabelStyle.si = 5;
            chtData.ChartAreas[0].AxisX.Title = "PART TYPE";
            chtData.ChartAreas[0].AxisY.Title = "NUMBER SOLD";
            chtData.Series[0].IsVisibleInLegend = false;

            chtData.Visible = true;
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            // Allow the user to choose the page range he or she would
            // like to print.
            prntD.AllowSomePages = true;

            // Show the help button.
            prntD.ShowHelp = true;

            // Set the Document property to the PrintDocument for 
            // which the PrintPage Event has been handled. To display the
            // dialog, either this property or the PrinterSettings property 
            // must be set 
            prntDoc = chtData.Printing.PrintDocument;
            prntD.Document = prntDoc;
            DialogResult result = prntD.ShowDialog();

            // If the result is OK then print the document.
            if (result == DialogResult.OK)
            {
                prntDoc.Print();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            parent.Show();
        }
    }
}
