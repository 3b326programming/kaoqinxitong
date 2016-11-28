using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBA;
using System.Data;
 

namespace BLL
{
    public class FindCase
    {
        public static DataTable findAll(string TableName)
        {
            string SQL = "select * from "+TableName+"";

           
            DataTable dt = DBHelper.GetDT(SQL);
            return dt;
        }
        public static DataTable findSelected(string TableName,string column,string text)
        {
            string SQL="select * from "+TableName+" where "+ column+"  like  "+text+" ";
            DataTable dt=DBHelper.GetDT(SQL);
            return dt;

        }
        public static void rowupdate(string TableName,string Column,string content,string UserID,string strUserID,string            
            Column2,string strCurrent,string Column3,string strWeek,string Column4,string strTime)
        {  
            string SQL = "update  " + TableName + " set " + Column + " = '" + content + "' where " + UserID + "='" + strUserID + "' and   " + Column2 + " = '" + strCurrent + "' and " + Column3 + "= '" + strWeek + "' and " + Column4 + "='" + strTime + "'";
           
                DBHelper.GETDTA(SQL);
            
          
        }
        public static void rowupdate2IsHomework(string TableName, string Ishomework, string strIsHomework, string IsMarked,string strIsMarked,  string UserID, string strUserID, string
            Column2, string strCurrent, string Column3, string strWeek, string Column4, string strTime)
        {
            string SQL = "update  " + TableName + " set'"+Ishomework+"' = '"+strIsHomework+"','"+IsMarked+"'='"+strIsMarked+"' where " + UserID + "='" + strUserID + "' and   " + Column2 + " = '" + strCurrent + "' and " + Column3 + "= '" + strWeek + "' and " + Column4 + "='" + strTime + "'";
            DBHelper.GETDTA(SQL);
        
        }

        public static void rowdelete(string TableName,string Column,string UserID )
        {
            string SQL = "delete from "+TableName+"  where " + Column+ "='" +UserID + "'";
            DBHelper.GETDTA(SQL);
        }
     
      //public static DataTable Griview(string column, string name)
        //{
        //    string SQL = "select * from   where " + column + "='" + name + "'";

        //    DataTable dt = DBHelper.GetDT(SQL);
        //    return dt;
  
        //}
    }
    }

