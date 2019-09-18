using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairSys
{
    class Payment
    {
        private int payment_id;
        private int repair_id;
        private double amount_Paid;
        private DateTime pay_Date;

        public Payment(int payment_id, int repair_id, double amount_Paid)
        {
            this.payment_id = payment_id;
            this.repair_id = repair_id;
            this.amount_Paid = amount_Paid;
            this.pay_Date = DateTime.Today;

        }

        public Payment()
        {
            payment_id = 0;
            repair_id = 0;
            amount_Paid = 0;
            pay_Date = DateTime.Today;
        }

        public void addPayments()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "INSERT INTO Payments VALUES(" + this.payment_id + "," + this.repair_id +
            "," + this.amount_Paid + ", to_Date('" + this.pay_Date.ToShortDateString() + "', 'DD/MM/YYYY'))";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public static int nextPaymentID()
        {
            // variable to hold value to be returned
            int nextPartId = 1;

            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX part ID used
            String strSQL = "SELECT MAX(Payment_ID) FROM Payments";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            //read the first (only) value returned by query
            //If first stockNo, assign value 1, otherwise add 1 to MAX value
            dr.Read();

            //An aggregate function always returns 1 row, even if it contains a NULL value
            // If NULL, then there are no StockNo's in the Stock File - start at 1
            //Otherwise add 1 to the value read

            if (!dr.IsDBNull(0))
                //intNextStockNo = Convert.ToInt32(dr.GetValue(0)) + 1;
                nextPartId = dr.GetInt32(0) + 1;

            //close DB connection
            myConn.Close();

            //return next StockNo
            return nextPartId;
        }

        public static Boolean isExistingPayment(int repid)
        {
            bool exists = false;

            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX part ID used
            String strSQL = "SELECT repair_id FROM Payments WHERE REPAIR_ID = " + repid;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            //read the first (only) value returned by query
            //If first stockNo, assign value 1, otherwise add 1 to MAX value
            dr.Read();


            if (dr.HasRows)
            {

                //intNextStockNo = Convert.ToInt32(dr.GetValue(0)) + 1;
                exists = true;
            }

            //close DB connection
            myConn.Close();


            //return next StockNo
            return exists;

        }

        public static double retrieverepCost(int repid)
        {
            Double payment = 00.00;

            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX part ID used
            String strSQL = "SELECT sum(amount_paid) FROM Payments WHERE REPAIR_ID = " + repid;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                payment = dr.GetDouble(0);
            }

            //close DB connection
            myConn.Close();

            return payment;

        }

        public static DataSet GetYears(DataSet years)
        {
            //connect to db
            OracleConnection conn = new OracleConnection(DBconnect.oradb);
            conn.Open();

            //define sql query
            String strSQL = "SELECT DISTINCT to_Char(Pay_Date,'YYYY') FROM PAYMENTS";

            //create command
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(years, "year");
            conn.Close();

            return years;
        }

        public static DataTable analyseRevenueChart(string year, DataTable dt)
        {
            //Counts the top ten part id and matches them with the part model from the joined parts and repair parts table. Taken from completed repairs in the specified year
            String strSQL = "SELECT SUM(Amount_Paid), to_Char(Pay_Date,'MM') FROM Payments " +
              "WHERE to_Char(Pay_Date, 'YYYY') = '" + year + "' " +
              "GROUP BY to_Char(Pay_Date,'MM')" +
             "ORDER BY to_char(Pay_Date,'MM')";

            OracleConnection myConn = new OracleConnection(DBconnect.oradb);

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(dt);
            myConn.Close();

            return dt;
        }

    }
}
