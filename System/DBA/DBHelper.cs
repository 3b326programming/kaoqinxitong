using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;

namespace DBA
{
    public class DBHelper
    {
        private static string strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public static DataTable getDtFromSQL(string strSQL)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
            da.Fill(dt);
            conn.Close();
            
            return dt;
        }
        public static void Getdt(string strSQL,DataTable dt)
        {
            string strConn1 = "data source=.;initial catalog=AttendanceSys_database;uid=sa;password=sa";
            SqlConnection conn = new SqlConnection(strConn1);
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i].SetAdded();
            }
                da.Update(dt);
            conn.Close();

        }
        public static void GETDTA(string strSQL)
        {
            
            string strConn1 = "data source=.;initial catalog=AttendanceSys_database;uid=sa;password=sa";
            SqlConnection conn1 = new SqlConnection(strConn1);
            conn1.Open();
            SqlCommand cmd = new SqlCommand(strSQL, conn1);
            cmd.ExecuteNonQuery();
            conn1.Close();


        }
        public static DataTable LoadToExcel(string currFilePath, string strSQL)
        {

            string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;data Source='" + currFilePath + "';Extended Properties='Excel 8.0;HDR=Yes;IMEX=1';";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" });
            string SheetName;


            
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
