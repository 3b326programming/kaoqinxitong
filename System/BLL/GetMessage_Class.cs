using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DBA;

namespace BLL
{
    public class GetMessage_Class
    {
        public static DataTable GetMessageID(string TeacherID)
        {
            string strSQL = "select MessageID from tb_MessageIDTeacher_Info where TeacherID='" + TeacherID + "'";
            DataTable dt = DBHelper.GetDT(strSQL);
            return dt;
        }
        public static DataTable GetMessage(string MessageID)
        {
            string strSQL = "select Messages,MessageTime from tb_Message_Info where MessagesID='" + MessageID + "'";
            DataTable dt = DBHelper.GetDT(strSQL);
            return dt;
        }
        public static void DeleteMessage(string TeacherID)
        {
            string strSQL = "delete from tb_MessageIDTeacher_Info where TeacherID='" + TeacherID + "'";
            DBHelper.GETDTA(strSQL);
        }
    }
}
