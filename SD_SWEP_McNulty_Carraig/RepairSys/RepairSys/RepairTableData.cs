using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairSys
{
    class RepairTableData
    {
        public static DataTable createTable()
        {

            // Here we create a DataTable with four columns.
            DataTable table = new DataTable();
            table.Columns.Add("Part_ID", typeof(string));
            table.Columns.Add("Part_Model", typeof(string));
            table.Columns.Add("Quantity", typeof(string));
            table.Columns.Add("Unit_Price", typeof(string));

            return table;
        }

        public static String calculateRepairCost(DataTable table)
        {

            double totalRepairCost = 0;

            foreach (DataRow row in table.Rows)
            {
                int quantity = Convert.ToInt32(row[2]);
                double unitCost = Convert.ToDouble(row[3]);

                totalRepairCost += unitCost * quantity;
            }

            return totalRepairCost.ToString(".00");
        }

        public static DataTable createTableRow(DataGridView grdAddedParts, DataGridView grdShowParts, DataTable table, int quantity)
        {
            DataGridViewRow selectedPartRow = grdShowParts.Rows[grdShowParts.CurrentCell.RowIndex];

            //populate the textbox from specific value of the coordinates of column and row.
            string pId = selectedPartRow.Cells[0].Value.ToString();
            string model = selectedPartRow.Cells[1].Value.ToString();
            string partType = selectedPartRow.Cells[2].Value.ToString();
            string price = selectedPartRow.Cells[3].Value.ToString();
            bool quantityUpdated = false;

            if (grdAddedParts.RowCount > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    if (row[0].ToString() == pId)
                    {
                        quantityUpdated = true;
                        //int pIdInt = Convert.ToInt32(pId);
                        int tableRow = Convert.ToInt32(row[2].ToString());

                        if (tableRow == 5)
                        {
                            MessageBox.Show("Maximum number of part type added", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                        else
                        {
                            if ((tableRow + quantity) > 5)
                            {
                                row[2] = 5;
                            }

                            else
                            {
                                // Here we add five DataRows.
                                row[2] = tableRow + quantity;
                                break;
                            }

                        }


                    }
                }
            }

            if (quantityUpdated == false)
            {

                // Here we add five DataRows.
                table.Rows.Add(pId, model, quantity, price);
            }



            return table;
        }

        public static void removeRepairPart(DataGridView grdAddedParts, DataGridView grdShowParts , DataTable table)
        {
            //DataGridViewRow selectedPart = grdShowParts.Rows[grdShowParts.CurrentCell.RowIndex]; 
          
                if (grdAddedParts.RowCount > 0)
                {
                    DataGridViewRow selectedPart = grdAddedParts.Rows[grdAddedParts.CurrentCell.RowIndex];
                    string pId = selectedPart.Cells[0].Value.ToString();
                    foreach (DataRow row in table.Rows)
                    {
                        if (row[0].ToString() == pId)
                        {
                            int tableRow = Convert.ToInt32(row[2].ToString());

                            if (tableRow == 1)
                            {
                                table.Rows.RemoveAt(grdAddedParts.CurrentCell.RowIndex);
                                grdAddedParts.DataSource = table;
                                break;
                            }

                            else
                            {
                                int pIdInt = Convert.ToInt32(pId);

                                if (tableRow > 1 && tableRow <= 5)
                                {
                                    tableRow -= 1;

                                    // Here we add five DataRows.
                                    row[2] = tableRow;
                                    break;

                                }

                            }

                        }

                    }

                }
            
        }

        public static DataTable addTableRow(DataGridView grdAddedParts, DataGridView grdShowParts, DataTable table, int quantity)
        {
            DataGridViewRow selectedPartRow = grdShowParts.Rows[grdShowParts.CurrentCell.RowIndex];

            //populate the textbox from specific value of the coordinates of column and row.
            string pId = selectedPartRow.Cells[0].Value.ToString();
            string model = selectedPartRow.Cells[1].Value.ToString();
            string partType = selectedPartRow.Cells[2].Value.ToString();
            string price = selectedPartRow.Cells[3].Value.ToString();
            bool quantityUpdated = false;

            if (grdAddedParts.RowCount > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    if (row[0].ToString() == pId)
                    {
                        quantityUpdated = true;
                        //int pIdInt = Convert.ToInt32(pId);
                        int tableRow = Convert.ToInt32(row[2].ToString());

                        if (tableRow == 5)
                        {
                            MessageBox.Show("Maximum number of part type added", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                        else
                        {
                            if ((tableRow + quantity) > 5)
                            {
                                row[2] = 5;
                            }

                            else
                            {
                                // Here we add five DataRows.
                                row[2] = tableRow + quantity;
                                break;
                            }

                        }


                    }
                }
            }

            if (quantityUpdated == false)
            {

                // Here we add five DataRows.
                table.Rows.Add(pId, model, quantity, price);
            }



            return table;
        }

    }
}
