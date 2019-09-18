using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Net.Mail;

namespace RepairSys
{
    class Repair
    {
        private string forename;
        private string surname;
        private double repair_cost;
        private string phone_No;
        private int repair_ID;
        private String status="Pending Repair";
        private string description;
        private string email;
        private DateTime Log_Date;
 

        public Repair(String forename,String surname,String phone,string desc, int rId,string custEmail)
        {
            this.forename = forename;
            this.surname = surname;
            repair_cost = 0;
            repair_ID = rId;
            phone_No = phone;
            Log_Date = DateTime.Today;
            status = "Pending";
            description = desc;
            email = custEmail;

        }

        public Repair()
        {
            repair_ID = 0;
            forename = "";
            repair_cost = 0;
            surname = "";
            phone_No = "";
            status = "Pending";
            Log_Date = DateTime.Today;
            email = "";

        }

        public double getReparCost()
        {
            return repair_cost;
        }

        public string getemail()
        {
            return email;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }


        public void logRepair()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

           
            String strSQL = "INSERT INTO Repairs VALUES(" + this.repair_ID +
            "," + this.repair_cost + ",'" + this.status + "','" +
            this.forename + "','"+ this.surname+"','"+this.phone_No+ "','" + this.email + "','" + this.description+"',to_Date('"+ this.Log_Date.ToShortDateString()+ "','DD/MM/YYYY'),null"+ /*.ToShortDateString() + "','DD/MM/YYYY')*/")";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public static void updateRepairStatus(int repid,string status)
        { 

            //connect to database
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

       
            String strSQL = "update Repairs set status = '"+status+ "' WHERE REPAIR_ID = " + repid ;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public static void setCompletionDate(int repid)
        {
            DateTime Completion_Date = DateTime.Today;

            //connect to database
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

       
            String strSQL = "update Repairs set Completion_Date = to_Date('" + Completion_Date.ToShortDateString() + "','DD/MM/YYYY') WHERE REPAIR_ID = " + repid;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public static void updateRepairDesc(int repid, String description)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

            //Define SQL query to Update Repair description
            String strSQL = "update Repairs set Repair_Description = '" + description + "' WHERE REPAIR_ID = " + repid;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public static int nextRepairID()
        {
       
            int nextRepairId = 1;

            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

  
            String strSQL = "SELECT MAX(Repair_ID) FROM Repairs";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader dr = cmd.ExecuteReader();
            
            dr.Read();

            if (!dr.IsDBNull(0))
                nextRepairId = dr.GetInt32(0) + 1;
    
            myConn.Close();

            return nextRepairId;
        }

        public static DataSet getRepairStatus(DataSet DS , String status)
        {
            //connect to db
            OracleConnection conn = new OracleConnection(DBconnect.oradb);

            //define sql query
            String strSQL = "SELECT Repair_ID, Status,Log_Date,Phone_No, Surname,Forename FROM Repairs WHERE Status = '"+ status +"' ";

            //create oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //create oracle adapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //fill dataset
            da.Fill(DS, "status_List");

            //close db connection
            conn.Close();

            //return DataSet
            return DS;

        }

        public static void updateRepairCost(int repairId,Double repair_cost)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE REPAIRS SET Repair_Cost = " + repair_cost+  " WHERE Repair_Id = " + repairId;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public static string getDescription(int repID)
        {   
            string strDesc = "";

            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX stock_No used
            String strSQL = "SELECT Repair_Description FROM Repairs WHERE Repair_ID = '" + repID + "'";

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

        public static string getEmail(int repID)
        {
            string email = "";

            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBconnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX stock_No used
            String strSQL = "SELECT Email FROM Repairs WHERE Repair_ID = '" + repID + "'";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                email = dr.GetString(0);
            }
            //close DB connection
            myConn.Close();

            return email;

        }

        public static DataSet listRepairs(DataSet ds)
        {

            //connect to db
            OracleConnection conn = new OracleConnection(DBconnect.oradb);

            //define sql query
           
            //define sql query
            String strSQL = "SELECT REPAIR_ID AS ID,REPAIR_COST AS COST,STATUS,FORENAME,SURNAME,PHONE_NO AS PHONE,EMAIL,to_char(LOG_DATE,'DD/MM/YYYY') AS LOG_DATE,to_char(COMPLETION_DATE,'DD/MM/YYYY') AS COMPLETION_DATE FROM Repairs ORDER BY repair_id";
            
            //create oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //create oracle adapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //fill dataset
            da.Fill(ds, "repairlist");

            //close db connection
            conn.Close();

            //return DataSet
            return ds;

        }

        public static DataSet filterRepairs(DataSet ds, String status)
        {

            //connect to db
            OracleConnection conn = new OracleConnection(DBconnect.oradb);

            //define sql query
            string strSQL = "SELECT Repair_ID,REPAIR_COST,status,forename,surname,phone_no,Log_date FROM Repairs WHERE status= '" + status + "' ORDER BY Repair_ID";

            if (status == "Completed")
            {
                //define sql query
                strSQL = "SELECT * FROM Repairs WHERE status= 'Completed'";
            }
            //create oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //create oracle adapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //fill dataset
            da.Fill(ds, "repairlist");

            //close db connection
            conn.Close();

            //return DataSet
            return ds;

        }

        public static void sendInvoice(String reciever , String emailMessage , String cost)
        {
            string senderAddress = "carraigmcnlty@gmail.com";
            string password = "Caraig234456";
            string subject = "Repair Status Changed";
            string message = "";
            double output;

            if (double.TryParse(emailMessage ,out output) )
            {
                 message = "Your repair cost has been calculated.The Repair total is " + output + "\n\n This cost must be paid in full for our Technicians  to continue your repair. ";

            }

              message = "Your repair status has been changed to  " + emailMessage ;

            if (emailMessage == "Revised")
            {
                message = "Unfortunately your repair had to be revised to move forward.The Repair total is now" + cost + "\n\nIf you have paid already you need only pay the difference ";
            }

                if (emailMessage == "Completed")
            {
                message = "Your repair has been " + emailMessage + "\n\n\nPlease return to the store to collect your device.";
            }

            if (emailMessage == "Logged")
            {
                message = "Thank you For logging a repair with us. We will contact you during each stage of the repair process (Logged , Estimated, Processing,Completed)";
            }


            MailMessage mail;

            mail = new MailMessage(senderAddress, reciever,subject , message);

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential(senderAddress, password);
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
    }
}
