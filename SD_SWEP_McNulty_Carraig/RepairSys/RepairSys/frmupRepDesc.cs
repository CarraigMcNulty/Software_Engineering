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
    public partial class frmupRepDesc : Form
    {
        public frmupRepDesc()
        {
            InitializeComponent();
        }

        frmReviseRepair parent;
        public frmupRepDesc(frmReviseRepair Parent, String description, String Repid)
        {
            parent = Parent;
            InitializeComponent();
            txtRepairDesc.Text = description;

            txtRepId.Text = Repid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Repid = Convert.ToInt32(txtRepId.Text);

            if (Repid > 0 && txtRepairDesc.Text != "")
            {
                Repair.updateRepairDesc(Repid, ValidateText(txtRepairDesc.Text));
                MessageBox.Show("Repair Description for Repair Id: " + txtRepId.Text + " Updated", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }

            else
            {
                MessageBox.Show("Error Description not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private string ValidateText(string text)
        {
            string escapeText = "";

            foreach (char letter in text)
            {
                if (letter == '\'')
                {
                    escapeText += "''";
                }

                else
                    escapeText += letter;

            }

            return escapeText;
        }
    }
}
