using Oracle.ManagedDataAccess.Client;
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
    public partial class frmYearlyRevenue : Form
    {
        frmMainMenu parent;
        public frmYearlyRevenue()
        {
            InitializeComponent();
        }

        public frmYearlyRevenue(frmMainMenu Parent)
        {

            this.parent = Parent;
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setChart(cboYear.SelectedItem.ToString());
        }

        private void frmYearlyRevenue_Load(object sender, EventArgs e)
        {
            loadcombo();
            
        }

        public void setChart(string year)
        {
            
            DataTable dt = new DataTable();
            Payment.analyseRevenueChart(cboYear.SelectedItem.ToString(), dt);


            string[] N = new string[dt.Rows.Count];
            decimal[] M = new decimal[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                N[i] = getMonth(Convert.ToInt32(dt.Rows[i][1]));
                M[i] = Convert.ToDecimal(dt.Rows[i][0]);
            }

            //order the arrays N and M

            chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtData.Series[0].LegendText = "Income in €";

            chtData.Series["Series1"]["PointWidth"] = ".5";

            chtData.Series["Series1"]["PixelPointWidth"] = "20";
            chtData.Series[0].Points.DataBindXY(N, M);
            chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

            //chtSales.Series[0].Points[0] = "XXX";
            //chtData.Series[0].Label = "#VALY";

            
            //chtData.ChartAreas[0].AxisX.LabelStyle.si = 5;
            chtData.ChartAreas[0].AxisX.Title = "MONTH";
            chtData.ChartAreas[0].AxisY.Title = "€'s";
            chtData.ChartAreas[0].AxisY.Interval = 1000;
            chtData.Series[0].IsVisibleInLegend = false;


            chtData.Visible = true;
        }

        public void loadcombo()
        {
            DataSet year = new DataSet();
            year = Payment.GetYears(year);
            for (int i = 0; i < year.Tables["year"].Rows.Count; i++)
                cboYear.Items.Add(year.Tables[0].Rows[i][0].ToString());


            chtData.Visible = false;
            chtData.Titles.Add("Yearly Revenue");
        }

public String getMonth(int month)
{
    switch (month)
    {
        case 1:
            {
                return "JAN";

            }
        case 2:
            {
                return "FEB";

            }
        case 3:
            {
                return "MAR";

            }
        case 4:
            {
                return "APR";

            }
        case 5:
            {
                return "MAY";

            }
        case 6:
            {
                return "JUN";

            }
        case 7:
            {
                return "JUL";

            }
        case 8:
            {
                return "AUG";

            }
        case 9:
            {
                return "SEP";

            }
        case 10:
            {
                return "OCT";

            }
        case 11:
            {
                return "NOV";

            }
        case 12:
            {
                return "DEC";

            }
        default: return "OTH";

    }



}
        private void btnPrint_Click(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            parent.Show();
        }
    }
}
    
