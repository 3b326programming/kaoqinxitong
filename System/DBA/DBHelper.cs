using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DBA
{
    public class DBHelper
    {
        private static string strconn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        public static DataTable getDtFromSQL(string strSQL)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
