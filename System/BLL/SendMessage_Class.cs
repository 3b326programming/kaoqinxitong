using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DBA;
using System.IO;
using System.Data.SqlClient;
using System.Web;

namespace BLL
{
    public class SendMessage_Class
    {
         public static void Clear(string TableName)
        {
            DBHelper.GETDTA("delete from "+TableName);
        }

        public static DataTable selectuserID(int Role)//获取消息对应权限的教师ID
        {
            string strSQL="select UserID from tb_AllTeacher_Info where Role='" + Role + "';";
            DataTable dt=DBHelper.getDtFromSQL(strSQL);
            return dt;
        }
        /*
          public static DataTable selectLeaderID(int Role)//获取权限是校领导的教师ID
          {
            
              string strSQL="select UserID from tb_AllTeacher_Info where Role='" + Role + "'";
              DataTable dt=DBHelper.getDtFromSQL(strSQL);
              return dt;public static DataTable selectSecretaryID(int Role)//获取权限是辅导员的教师ID
          {
              string strSQL = "select UserID from tb_AllTeacher_Info where Role='" + Role + "'";
              DataTable dt = DBHelper.getDtFromSQL(strSQL);
              return dt;
          }
          public static DataTable selectTeacherID(int Role)//获取权限是普通教师的教师ID
          {
              string strSQL = "select UserID from tb_AllTeacher_Info where Role='" + Role + "'";
              DataTable dt = DBHelper.getDtFromSQL(strSQL);
              return dt;
          }*/
        public static void addMessages(string message, string messageTime)//向tb_Message_Info表中添加信息，MessageID为标记列无需添加
        {
            string strSQL = "insert into tb_Message_Info(Messages,MessageTime)values('" + message + "','"+ messageTime +"')";
            DBHelper.GETDTA(strSQL);
        }
        public static string selectMessageID(string message)
        {
            string strSQL = "select MessagesID from tb_Message_Info where Messages='"+message+"'";
            string messageID = DBHelper.getDtFromSQL(strSQL).Rows[0][0].ToString();
            return messageID;
        }
        public static void addTeacherMessage(string teacherID, int messageID)//向tb_MessageIDTeacher_Info表中添加信息
        {
            string strSQL = "insert into tb_MessageIDTeacher_Info(teacherID,messageID)values('" + teacherID + "','" + messageID + "')";
            DBHelper.GETDTA(strSQL);
        }
    }
}