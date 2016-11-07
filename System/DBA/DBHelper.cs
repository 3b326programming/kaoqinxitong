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
        public static DataTable GetDT(string SQL)
        {
           
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(SQL, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
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
            //string strConn1 = "data source=.;initial catalog=AttendanceSys_database;uid=sa;password=sa";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i].SetAdded();
            }
                da.Update(dt);
            conn.Close();

        }
        public static void SQlBulkCopy(string filename,DataTable dt)
        {
            SqlConnection conns = new SqlConnection(strConn);
            conns.Open();
            SqlBulkCopy sqlbulkCopy = new SqlBulkCopy(conns);
            // sqlbulkCopy.DestinationTableName = "tb_AllTeacher_Info";
           
            sqlbulkCopy.DestinationTableName = filename;

            sqlbulkCopy.ColumnMappings.Add("部门", "Department");
            sqlbulkCopy.ColumnMappings.Add("工号", "UserID");
            sqlbulkCopy.ColumnMappings.Add("密码", "UserPWD");
            sqlbulkCopy.ColumnMappings.Add("姓名", "UserName");
            sqlbulkCopy.ColumnMappings.Add("性别", "Sex");
            sqlbulkCopy.ColumnMappings.Add("权限", "Role");
            sqlbulkCopy.WriteToServer(dt);
           
          
        





        }
        public static void SQlBulkCopys(string filename, DataTable dt)
        {
            SqlConnection connss = new SqlConnection(strConn);
            connss.Open();
            SqlBulkCopy sqlbulkCopy = new SqlBulkCopy(connss);
            // sqlbulkCopy.DestinationTableName = "tb_AllTeacher_Info";

            sqlbulkCopy.DestinationTableName = filename;

            //sqlbulkCopy.ColumnMappings.Add("承担单位", "TeaDepartment");
            //sqlbulkCopy.ColumnMappings.Add("任课教师", "Teacher");
            //sqlbulkCopy.ColumnMappings.Add("上课时间/地点", "TimeAndArea");
            //sqlbulkCopy.ColumnMappings.Add("课程", "Course");
            //sqlbulkCopy.ColumnMappings.Add("所属部门", "CourseDepartment");
            //sqlbulkCopy.ColumnMappings.Add("学分", "Credit");
            //sqlbulkCopy.ColumnMappings.Add("总学时", "Role");
            //sqlbulkCopy.ColumnMappings.Add("上课班级名称", "Role");
            //sqlbulkCopy.ColumnMappings.Add("院(系)/部", "Role");
            //sqlbulkCopy.ColumnMappings.Add("学号", "Role");
            //sqlbulkCopy.ColumnMappings.Add("姓名", "Role");
            //sqlbulkCopy.ColumnMappings.Add("行政班级", "Role");
            //sqlbulkCopy.ColumnMappings.Add("性别", "Role");
            //sqlbulkCopy.ColumnMappings.Add("课程类别1", "Role");
            //sqlbulkCopy.ColumnMappings.Add("课程类别2", "Role");
            sqlbulkCopy.WriteToServer(dt);








        }
        public static void GETDTA(string strSQL)
        {
            
            //string strConn1 = "data source=.;initial catalog=AttendanceSys_database;uid=sa;password=sa";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();


        }
        public static void GetdtToSQL(string TableName,DataTable dt)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlBulkCopy bulkCopy = new SqlBulkCopy(conn);
            bulkCopy.DestinationTableName = TableName;            
            bulkCopy.WriteToServer(dt);            
        }
        public static DataTable LoadToExcel(string currFilePath, string strSQL)
        {

            string strConn = "Provider=Microsoft.jet.oledb.4.0;data Source='" + currFilePath + "';Extended Properties=Excel 8.0";
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
