using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Class1
    {
        public static bool Login(string userName,string password)
        {
           
            DataTable dt= DBHelper.getDtFromSQL("select uid from Login where uid='" + userName + "' and password='" + password + "'");

            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                
                return true;
            }

          
        }
        public static string getUserrode(string userName)
        {
            DataTable dt = DBHelper.getDtFromSQL("select userrode from Login where uid='" + userName+"'");
            return dt.Rows[0][0].ToString();
        }
        public static DataTable getClass()
        {
            DataTable dt = DBHelper.getDtFromSQL("select Class1 from student");
            return dt;
        }
    }
}
