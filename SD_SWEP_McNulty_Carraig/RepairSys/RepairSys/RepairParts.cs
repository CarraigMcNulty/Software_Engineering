using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairSys
{
    class RepairParts
    {
        private string model_number;
        private double repairCost;
        private string part_type;
        private int part_id;
        private int repair_ID;

        private int quantity;


        public RepairParts()
        {
            part_id = 0;
            repair_ID = 0;
            repairCost = 0.00;
            model_number = "";
           

        }

        // Argument Constructor
        public RepairParts(int pId, int rId, double rCost, String pType,  int quantity)
        {
            this.repairCost = rCost;
            this.part_id = pId;
            this.repair_ID = rId;
            this.part_type = pType;
            this.quantity = quantity;
        }

        public void setPartModelNo(String model_no)
        {
            this.model_number = model_no;
        }

        public void setPartType(String ptype)
        {
            this.part_type = ptype;
        }

        public void setRepID(int repid)
        {
            this.repair_ID = repid;
        }

        public void setPartID(int pid)
        {
            this.part_id = pid;
        }

        public void setQuantity(int quan)
        {
            this.quantity = quan;
        }

        public void setUnitPrice(Double rc)
        {
            this.repairCost = rc;
        }

        public int getRepairID()
        {
            return repair_ID;
        }

        public Double getRepairCost()
        {
            return repairCost;
        }

        public void addToRepairParts()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "INSERT INTO Repair_Parts VALUES(" + this.part_id +
            "," + this.repair_ID + "," + this.quantity + ")";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();

        }

        public static DataSet getRepairParts(DataSet DS ,int id)
        {

            if(DS == null)
            {
                DS = new DataSet();

            }

            //connect to database
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL ="Select r.PART_ID , p.PARTs_MODEL, R.QUANTITY ,p.UNIT_PRICE FROM REPAIR_PARTS r LEFT  JOIN PARTS p ON r.Part_Id = p.Part_ID WHERE r.repair_ID =" + id +"ORDER BY Repair_ID" ;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "Repair_Parts");

            //close the DB Connection
            myConn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }

        public void deleteRepairParts()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "Delete from Repair_Parts WHERE REPAIR_ID = " + this.repair_ID;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
    }
}
