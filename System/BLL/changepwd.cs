using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DBA;

namespace BLL
{
   public class changepwd
    {
        public static void UpdatePwd(string userPwd, string userPWD)
        {
            string strSQL = "update tb_ALLTeacher_Info set userPWD='" + userPwd + "' where userPWD='" + userPWD + "'";
            DBHelper.GETDTA(strSQL);
        }
        public static DataTable getpwd(string userId)
        {
            string strSQL = "select Username from tb_ALLTeacher_Info where UserID='" + userId + "'";
            return DBHelper.getDtFromSQL(strSQL);
        }
    }
}
