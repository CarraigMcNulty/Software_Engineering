using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace RepairSys
{
    class Parts
    {
        // instance variables
        private string model_number;
        private string part_type;
        private int Part_id;
        private double unit_cost;

        // No argument constructor
        public Parts()
        {
            Part_id = 0;
            model_number = "";
            part_type = "";
            unit_cost = 0;

        }

        // Argument Constructor
        public Parts(String Mno, double CostP, String pType, int pId)
        {
            model_number = Mno;
            Part_id = pId;
            part_type = pType;
            unit_cost = CostP;

        }

        // Define setters
        public void setPartModelNo(String model_no)
        {
            this.model_number = model_no;
        }

        public void setPartType(String ptype)
        {
            this.part_type = ptype;
        }

        // Define setters
        public void setCostPrice(Double cp)
        {
            this.unit_cost = cp;
        }

        //Define getters
        public string getModelNo()
        {
            return model_number;
        }


        //define a static method to get all data from Part Types table
        public static DataSet getUnregisteredParts(DataSet DS)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBconnect.oradb);

            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT Part_Type FROM Part_Types";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "Part_Type");

            //close the DB Connection
            conn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }

        //define a static method to get all data from Parts table
        public static DataSet getRegisteredParts(DataSet DS)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBconnect.oradb);

            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT DISTINCT Part_Type FROM Parts ORDER BY Part_Type";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the DataSet DS with the query result
            da.Fill(DS, "Parts");

            //close the DB Connection
            conn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }


        public static int nextPartID()
        {
            // variable to hold value to be returned
            int nextPartId = 1;

            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX part ID used
            String strSQL = "SELECT MAX(Part_ID) FROM Parts";

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

        public static string getPartDetail(String colName, String partType)
        {
            string strDesc = "";
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX stock_No used
            String strSQL = "SELECT " + colName + " FROM Part_Types WHERE part_type = '" + partType + "'";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                strDesc = dr.GetString(0);
            }
            //close DB connection
            myConn.Close();

            return strDesc;

        }

        public static string getPartId(String partID)
        {
            string strDesc = "";
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX stock_No used
            String strSQL = "SELECT Repair_ID FROM Repairs WHERE Repair_ID = '" + partID + "'";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                strDesc = dr.GetString(0);
            }
            //close DB connection
            myConn.Close();

            return strDesc;

        }

        public static DataSet getListPartsModelNo(DataSet DS, String modelNo)
        {
            //connect to db
            OracleConnection conn = new OracleConnection(DBconnect.oradb);

            //define sql query
            String strSQL = "SELECT * FROM Parts WHERE Parts_Model= '" + modelNo + "' ORDER BY PART_ID";

            //create oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //create oracle adapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //fill dataset
            da.Fill(DS, "part_ModelList");

            //close db connection
            conn.Close();

            //return DataSet
            return DS;

        }

        public static DataSet getListPartType(DataSet DS, String partType)
        {
            //connect to db
            OracleConnection conn = new OracleConnection(DBconnect.oradb);

            //define sql query
            String strSQL = "SELECT * FROM Parts WHERE Part_Type ='" + partType + "' ORDER BY PART_ID";

            //create oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //create oracle adapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //fill dataset
            da.Fill(DS, "part_TypeList");

            //close db connection
            conn.Close();

            //return DataSet
            return DS;

        }

        public static DataSet getListParts(DataSet DS)
        {
            //connect to db
            OracleConnection conn = new OracleConnection(DBconnect.oradb);

            //define sql query
            String strSQL = "SELECT * FROM Parts ORDER BY PART_ID";

            //create oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //create oracle adapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //fill dataset
            da.Fill(DS, "ListParts");

            //close db connection
            conn.Close();

            //return DataSet
            return DS;

        }

        public void addPart()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "INSERT INTO Parts VALUES(" + this.Part_id +
            ",'" + this.model_number.ToUpper() + "','" + this.part_type + "'," +
            this.unit_cost + ")";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }


        public void updPart(int partId)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE PARTS SET Parts_Model = '" + this.model_number.ToUpper() + "', Part_Type = '" + this.part_type + "', unit_price = " +
                this.unit_cost + " WHERE Part_Id = " + partId;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public static Boolean validateUniqueModelNo(String modelno)
        {
            // variable to hold value to be returned
            bool valid = false;

            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);


            //Define SQL query to get MAX stock_No used
            String strSQL = "SELECT Parts_Model FROM Parts where parts_model = '" + modelno + "'";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            myConn.Open();
            //execute the SQL query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();



            if (!dr.Read())
            {
                //return next StockNo
                return valid = true;
            }

            return valid;
        }

        public static DataTable analysePartsChart(string year,DataTable dt)
        {
            //Counts the top ten part id and matches them with the part model from the joined parts and repair parts table. Taken from completed repairs in the specified year
            String strSQL = "SELECT * FROM( " +
            "SELECT COUNT(RP.PART_ID), P.PARTS_MODEL FROM REPAIR_PARTS RP INNER JOIN PARTS P " +
            "ON RP.PART_ID = P.PART_ID " +
            "WHERE REPAIR_id IN( " +
            "SELECT REPAIR_ID FROM REPAIRS WHERE TO_CHAR(COMPLETION_DATE, 'YYYY') = '" + year + "') " +
            "GROUP BY P.PARTS_MODEL " +
            "ORDER BY COUNT(RP.PART_ID)) " +
            "WHERE ROWNUM <= 10";

            OracleConnection myConn = new OracleConnection(DBconnect.oradb);

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(dt);
            myConn.Close();

            

            return dt;

            
        }




    }
}
