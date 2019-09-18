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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            
            InitializeComponent();
        }

        private void addPartToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
            frmAddPart addPart = new frmAddPart(this);
            addPart.StartPosition = FormStartPosition.CenterScreen;
            addPart.Show(); 
            this.Hide();
        }

        private void updatePartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdatePart updatePart = new frmUpdatePart(this);
            updatePart.StartPosition = FormStartPosition.CenterScreen;
            updatePart.Show();
            this.Hide();
        }

        private void listPartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListParts listParts = new frmListParts(this);
            listParts.StartPosition = FormStartPosition.CenterScreen;
            listParts.Show();
            this.Hide();
        }

        private void logRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogRepair logRepair = new frmLogRepair(this);
            logRepair.StartPosition = FormStartPosition.CenterScreen;
            logRepair.Show();
            this.Hide();
        }

        private void estimateCostToolStripMenuItem_Click(object sender, EventArgs e)
        {

         

            frmEstimate_cost estimate_Cost = new frmEstimate_cost(this);
            estimate_Cost.StartPosition = FormStartPosition.CenterScreen;
            estimate_Cost.Show();
            this.Hide();


        }

        private void listRepairsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListRepairs listRepairs = new frmListRepairs(this);
            listRepairs.StartPosition = FormStartPosition.CenterScreen;
            listRepairs.Show();
            this.Hide();
        }

        private void commenceRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCommenceRepair listRepairs = new frmCommenceRepair(this);
            listRepairs.StartPosition = FormStartPosition.CenterScreen;
            listRepairs.Show();
            this.Hide();
        }

        private void reviseRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReviseRepair reviseRepair = new frmReviseRepair(this);
            reviseRepair.StartPosition = FormStartPosition.CenterScreen;
            reviseRepair.Show();
            this.Hide();

        }

        private void partsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void completeRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompleteRepair completeRepair = new frmCompleteRepair(this);
            completeRepair.StartPosition = FormStartPosition.CenterScreen;
            completeRepair.Show();
            this.Hide();
        }

        private void yearlyRevenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYearlyRevenue yearlyRevenue = new frmYearlyRevenue(this);
            yearlyRevenue.StartPosition = FormStartPosition.CenterScreen;
            yearlyRevenue.Show();
            this.Hide();
        }

        private void partsSoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
                frmAnalyseParts repairParts = new frmAnalyseParts(this);
                repairParts.StartPosition = FormStartPosition.CenterScreen;
                repairParts.Show();
                this.Hide();
           
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
