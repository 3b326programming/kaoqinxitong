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
            string strSQL = "update tb_AllTeacher_Info set userPWD='" + userPwd + "' where userPWD='" + userPWD + "'";
            DBHelper.GETDTA(strSQL);
        }
        public static DataTable getid(string userId)
        {
            string strSQL = "select Username from tb_AllTeacher_Info where UserID='" + userId + "'";
            return DBHelper.getDtFromSQL(strSQL);
        }
        public static DataTable getpwd(string userId)
        {
            string strSQL = "select UserPWD from tb_AllTeacher_Info where UserID='" + userId + "'";
            return DBHelper.getDtFromSQL(strSQL);
        }
        public static DataTable getPTTid(string userId)
        {
            string strSQL = "select Username from tb_ExtemalTCH_Info where UserID='" + userId + "'";
            return DBHelper.getDtFromSQL(strSQL);
        }
        public static DataTable getPTTpwd(string userId)
        {
            string strSQL = "select UserPWD from tb_ExtemalTCH_Info where UserID='" + userId + "'";
            return DBHelper.getDtFromSQL(strSQL);
        }
        public static void UpdatePTTpwd(string userPwd, string userPWD)
        {
            string strSQL = "update tb_ExtemalTCH_Info set userPWD='" + userPwd + "' where userPWD='" + userPWD + "'";
            DBHelper.GETDTA(strSQL);
        }
    }
}
