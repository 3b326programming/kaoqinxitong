using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBHelper
    {
        public static DataTable getDtFromSQL(string SQL)
        {
            string strSQL = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            SqlConnection conn = new SqlConnection(strSQL);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(SQL, conn);
            da.Fill(dt);
            return dt;
        }

    }
}
