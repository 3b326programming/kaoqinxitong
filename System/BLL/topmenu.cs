using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DBA;

namespace BLL
{
    public class topmenu
    {
        public static DataTable getSQL()
        {
            string strSQL = "select * from tb_Calendar";
            return DBHelper.getDtFromSQL(strSQL);
        }
        public static DataTable getUsername(string UserID)
        {
            string strSQL = "select UserName from tb_AllTeacher_Info where UserID='" + UserID + "'";
            return DBHelper.getDtFromSQL(strSQL);
        }
        public static DataTable getUserrole(string UserRole)
        {
            string strSQL = "select Role from tb_AllTeacher_Info where UserID='" + UserRole + "'";
            return DBHelper.getDtFromSQL(strSQL);
        }

    }
    
}
