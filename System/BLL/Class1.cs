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
    public class Class1
    {
        public static DataTable Griview(string column, string name)
        {
            string SQL = "select * from tb_AllTeacher_Info where " + column + "='" + name + "'";

            DataTable dt = DBHelper.GetDT(SQL);
            return dt;

        }
        public static bool Login(string userName, string password)
        {

            DataTable dt = DBHelper.getDtFromSQL("select uid from Login where uid='" + userName + "' and password='" + password + "'");

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
            DataTable dt = DBHelper.getDtFromSQL("select userrode from Login where uid='" + userName + "'");
            return dt.Rows[0][0].ToString();
        }
        public static DataTable getClass()
        {
            DataTable dt = DBHelper.getDtFromSQL("select Class1 from student");
            return dt;
        }
        //树状图
        public static DataTable getDT(string SQL)
        {
            DataTable dt = DBHelper.getDtFromSQL(SQL);
            return dt;
        }
        //导入数据表方法
        public static string currFilePath = string.Empty;
        public static string currFileExtension = string.Empty;
        //修改名字并复制上传Excel文件
        public static string UploadExcel(string fileName)
        {
            
            
            
            string tempPath = System.IO.Path.GetTempPath();
            //Label1.Text = tempPath;
            DirectoryInfo di = new DirectoryInfo(tempPath);

            //Label1.Text = tempPath;
            //Label2.Text = file.FileName;
            
            fileName = System.IO.Path.GetFileName(fileName);
            currFileExtension = System.IO.Path.GetExtension(fileName);
            string time = System.DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss-fff");
            currFilePath = tempPath + time + "-" + fileName;
            return currFilePath;
           
        }
        //Excel文件导入datatable
        public static DataTable ReadExcelToDatatable(string Department)
        {
            
            DataTable dt = DBHelper.LoadToExcel(currFilePath, "select * from [" + Department + "$]");
           // DBHelper.SQlBulkCopy(dt);
            return dt;
        }
        //Excel文件导入SQL表
        public static string ReadTeacherExceltoSQL(string TableName,DataTable dt)
           
        {
            //Upload();
            if (currFileExtension == ".xlsx" || currFileExtension == ".xls")
            {

                string[] Content = { "部门", "工号", "密码", "姓名", "性别", "权限" };
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        if (dt.Rows[0][i].ToString().Contains(Content[i]))
                        {
                            return "选择的文件内容与数据库要求不匹配，请确认！";
                        }
                    }
                    catch
                    {
                        return "选择的文件内容与数据库要求不匹配，请确认！";
                    }
                }
               // for (int i = 0; i < dt.Rows.Count; i++)
              //  {                    
                 //   DBHelper.GETDTA("insert into " + TableName + " values('" + dt.Rows[i][1].ToString() + "','" + dt.Rows[i][3].ToString() + "','" + dt.Rows[i][2].ToString() + "','" + dt.Rows[i][5].ToString() + "','" + dt.Rows[i][4].ToString() + "','" + dt.Rows[i][0].ToString() + "')");
              //  }
        

                //DBHelper.Getdt("select * from "+TableName,dt);
                DBHelper.SQlBulkCopy(TableName,dt);
                return "导入成功QAQ";
            }
            else
            {
                return "导入的文件类型必须是Excel文件！";
            }
        }
        public static string ReadCourseExcelToSQL(string TableName, DataTable dt)
        {
            if (currFileExtension == ".xlsx" || currFileExtension == ".xls")
            {
                string[] Content = { "承担单位", "任课教师", "上课时间/地点", "课程", "所属部门", "学分", "总学时", "上课班级名称", "院(系)部", "学号", "姓名", "行政班级", "性别", "课程类别1", "课程类别2" };
                for (int i = 0; i < 15; i++)
                {
                    try
                    {
                        if (dt.Rows[0][i].ToString().Contains(Content[i]))
                        {
                            return "选择的文件内容与数据库要求不匹配，请确认！";
                        }
                    }
                    catch
                    {
                        return "选择的文件内容与数据库要求不匹配，请确认!";
                    }
                }
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    DBHelper.GETDTA("insert into tb_AllInformation values('" + dt.Rows[i][0].ToString() + "','" + dt.Rows[i][1].ToString() + "','" + dt.Rows[i][2].ToString() + "','" + dt.Rows[i][3].ToString() + "','" + dt.Rows[i][4].ToString() + "','" + dt.Rows[i][5].ToString() + "','" + dt.Rows[i][6].ToString() + "','" + dt.Rows[i][7].ToString() + "','" + dt.Rows[i][8].ToString() + "','" + dt.Rows[i][9].ToString() + "','" + dt.Rows[i][10].ToString() + "','" + dt.Rows[i][11].ToString() + "','" + dt.Rows[i][12].ToString() + "','" + dt.Rows[i][13].ToString() + "')");
                //}
                DBHelper.SQlBulkCopys(TableName, dt);

                return "导入成功QAQ";
            }
            else
            {
                return "导入的文件类型必须是Excel文件！";
            }
        }
        public static string ReadCalendarExcelToSQL(string TableName, DataTable dt)
        {
            if (currFileExtension == ".xlsx" || currFileExtension == ".xls")
            {
                string[] Content = { "周次", "起", "止" };
                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        if (dt.Rows[0][i].ToString().Contains(Content[i]))
                        {
                            return "选择的文件内容与数据库要求不匹配，请确认！";
                        }
                    }
                    catch
                    {
                        return "选择的文件内容与数据库要求不匹配，请确认!";
                    }
                }

                return "导入成功QAQ";
            }
            else
            {
                return "导入的文件类型必须是Excel文件！";
            }
        }
        //清空数据表
        public static void Clear(string TableName)
        {
            DBHelper.GETDTA("delete from "+TableName);
        }
    }
}
