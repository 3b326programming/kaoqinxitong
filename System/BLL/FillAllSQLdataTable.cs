using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DBA;
namespace BLL
{
    public class FillAllSQLdataTable
    {
        public static void FillSQLCourse()
        {
            DataTable dt = new DataTable();
            dt = DBHelper.getDtFromSQL("select distinct Course,Credit,Period,CourseType1,CourseType2,CourseDepartment from tb_AllInformation");
            DBHelper.SQlBulkCopys("tb_Course_Info", dt);
        }
        public static void FillSQLCourseClass()
        {
            DataTable dt = new DataTable();
            dt = DBHelper.getDtFromSQL("select distinct Course,CourseClass from tb_AllInformation");
            DBHelper.SQlBulkCopys("tb_CourseClass_Info", dt);
        }
        public static void FillSQLStuCourseClass()
        {
            DataTable dt = new DataTable();
            dt = DBHelper.getDtFromSQL("select distinct StuID,CourseClass from tb_AllInformation");
            DBHelper.SQlBulkCopys("tb_StuCourseClass_Info", dt);
        }
        public static void FillSQLStuOriClass()
        {
            DataTable dt = new DataTable();
            dt = DBHelper.getDtFromSQL("select distinct StuID,StuOriClass from tb_AllInformation");
            DBHelper.SQlBulkCopys("tb_StuOriClass_Info", dt);
        }
        public static void FillSQLStu()
        {
            DataTable dt = new DataTable();
            dt = DBHelper.getDtFromSQL("select distinct StuID,StuName,StuSex from tb_AllInformation");
            DBHelper.SQlBulkCopys("tb_Stu_Info", dt);
        }
        public static void FillSQLStuDepartment()
        {
            DataTable dt = new DataTable();
            dt = DBHelper.getDtFromSQL("select distinct StuOriClass,StuDepartment from tb_AllInformation");
            DBHelper.SQlBulkCopys("tb_StuDepartment_Info", dt);
        }
        public static void FillSQLTeacherAttendance()
        {
            DataTable dt = new DataTable();
            dt = DBHelper.getDtFromSQL("select distinct Teacher,Course,TimeAndArea,CourseClass from tb_AllInformation");
            DataTable TeacherAttendance = new DataTable();
            TeacherAttendance.Columns.Add("TeacherID");
            TeacherAttendance.Columns.Add("Course");
            TeacherAttendance.Columns.Add("Current");
            TeacherAttendance.Columns.Add("Week");
            TeacherAttendance.Columns.Add("Time");
            TeacherAttendance.Columns.Add("CourseClass");
            DataRow InsertDr;
            foreach (DataRow dr in dt.Rows)
            {
                string[] TeacherID = dr[0].ToString().Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                string[] SameTimeLocation = dr[2].ToString().Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);//拆成单独的时间地点
                for (int i = 0; i < SameTimeLocation.Length; i++)
                {
                    string[] TimeLocation = SameTimeLocation[i].ToString().Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);//地点已被分开
                    string[] Time = TimeLocation[0].ToString().Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);//星期几与第几节已经被拆开
                    string[] week = Time[0].Split(',');
                    StringBuilder sb = new StringBuilder();
                    if (Time[0].Contains("单周"))
                    {
                        for (int j = 0; j < week.Length; j++)
                        {
                            if (week[j].Contains("-"))
                            {
                                string[] strSplit = week[j].Split(new char[] { '-', '单', '周' }, StringSplitOptions.RemoveEmptyEntries);
                                for (int x = Convert.ToInt32(strSplit[0]); x <= Convert.ToInt32(strSplit[1]); x++)
                                {
                                    if (i % 2 != 0)
                                    {
                                        sb.Append((x).ToString() + " ");
                                    }
                                }
                            }
                            else
                            {
                                string[] strSplit1 = week[j].Split(new char[] { '单', '周' }, StringSplitOptions.RemoveEmptyEntries);
                                if (Convert.ToInt32(strSplit1[0]) % 2 != 0)
                                {
                                    sb.Append(strSplit1[0].ToString() + " ");
                                }
                            }
                        }
                    }
                    else if (Time[0].Contains("双周"))
                    {
                        for (int j = 0; j < week.Length; j++)
                        {
                            if (week[j].Contains("-"))
                            {
                                string[] strSplit = week[j].Split(new char[] { '-', '双', '周' }, StringSplitOptions.RemoveEmptyEntries);
                                for (int x = Convert.ToInt32(strSplit[0]); x <= Convert.ToInt32(strSplit[1]); x++)
                                {
                                    if (i % 2 == 0)
                                    {
                                        sb.Append((x).ToString() + " ");
                                    }
                                }
                            }
                            else
                            {
                                string[] strSplit1= week[j].Split(new char[] { '双', '周' }, StringSplitOptions.RemoveEmptyEntries);
                                if (Convert.ToInt32(strSplit1[0]) % 2 == 0)
                                {
                                    sb.Append(strSplit1[0].ToString() + " ");
                                }
                            }
                        }
                    }
                    else if (Time[0].Contains("周"))
                    {
                        for (int j = 0; j < week.Length; j++)
                        {
                            if (week[j].Contains("-"))
                            {
                                string[] strSplit = week[j].Split(new char[] { '-', '周' }, StringSplitOptions.RemoveEmptyEntries);
                                for (int x = Convert.ToInt32(strSplit[0]); x <= Convert.ToInt32(strSplit[1]); x++)
                                {
                                    sb.Append((x).ToString() + " ");
                                }
                            }
                            else
                            {
                                string[] strSplit1= week[j].Split(new char[] { '周' }, StringSplitOptions.RemoveEmptyEntries);
                                sb.Append(strSplit1[0].ToString() + " ");
                            }
                        }
                    }
                    string[] Current = sb.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


                    for (int j = 0; j < Current.Length; j++)
                    {
                        InsertDr = TeacherAttendance.NewRow();
                        InsertDr["TeacherID"] = TeacherID[0];
                        InsertDr["Course"] = dr["Course"];
                        InsertDr["Current"] = Current[j];
                        InsertDr["Week"] = Time[1];
                        InsertDr["Time"] = Time[2];
                        InsertDr["CourseClass"] = dr["CourseClass"];
                        TeacherAttendance.Rows.Add(InsertDr);
                    }
                }
            }
            DBHelper.SQlBulkCopys("tb_TeacherAttendance_Info", TeacherAttendance);
           //TeacherAttendance.Columns.Remove("")
        }
    }
}
