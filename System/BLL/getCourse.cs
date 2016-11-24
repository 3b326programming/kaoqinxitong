using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DBA;

namespace BLL
{
    public class getCourse
    {
        public static DataTable GetCourse(string teacherid, string currentweek)
        {
            string strSQL = "select Week,Time,Course from tb_TeacherAttendance_Info where TeacherID='" + teacherid + "' and [Current]='" + currentweek + "'";
            return DBHelper.getDtFromSQL(strSQL);
        }
        public static DataTable GETCourse(string teacherid, string lastweek, string Ishomework, string Isfinished)
        {
            string strSQL = "select Week,Time,Course from tb_TeacherAttendance_Info where TeacherID='" + teacherid + "' and [Current]='" + lastweek + "'and IsHomework='" + Ishomework + "'and IsMarked='" + Isfinished + "'";
            return DBHelper.getDtFromSQL(strSQL);
        }
        public static DataTable getIsRecord(string teacherid, string currentweek, string currentcourse, string week, string time)
        {
            string strSQL = "select IsAttendance from tb_TeacherAttendance_Info where TeacherID='" + teacherid + "'and [Current]='" + currentweek + "'and Course='" + currentcourse + "'and Week='" + week + "'and Time='" + time + "'";
            return DBA.DBHelper.getDtFromSQL(strSQL);
        }
        public static bool insertInto(string teacherid, string stuid, string currentcourse, string currentweek, string week, string time, string isattendance)
        {
            string strSQL = "insert into tb_StuAttendance_Info(TeacherID,StuID,Course,[Current],Week,Time,StuAttendance) values('" + teacherid + "','" + stuid + "','" + currentcourse + "','" + currentweek + "','" + week + "','" + time + "','" + isattendance + "')";
            DBHelper.GETDTA(strSQL);
            return true;
        }

        public static bool updateInto(string IsAttendance, string IsHomework, string TeacherID, string Course, string Current, string Week, string Time)
        {
            string SQL = "update tb_TeacherAttendance_Info set IsAttendance='" + IsAttendance + "',IsHomework='" + IsHomework + "'where TeacherID='" + TeacherID + "'and Course='" + Course + "'and [Current]='" + Current + "'and Week='" + Week + "'and Time='" + Time + "'";
            DBHelper.GETDTA(SQL);
            return true;
        }
        public static DataTable getcount(string userid, string course, string time, string week)
        {
            string strSQL = "SELECT distinct Department, StuName, CourseClass, StuID FROM Teacher_Attendance WHERE TeacherID ='" + userid + "'  AND Course ='" + course + "'  AND Time = '" + time + "' AND Week = '" + week + "'";
            return DBHelper.getDtFromSQL(strSQL);
        }

        public static bool UpdateInto(string IsMarked, string TeacherID, string Course, string Current, string Week, string Time)
        {
            string SQL = "update tb_TeacherAttendance_Info set IsMarked='" + IsMarked + "'where TeacherID='" + TeacherID + "'and Course='" + Course + "'and [Current]='" + Current + "'and Week='" + Week + "'and Time='" + Time + "'";
            DBHelper.GETDTA(SQL);
            return true;
        }
        public static DataTable GetIsRecord(string teacherid, string currentweek, string currentcourse, string week, string time)
        {
            string strSQL = "select IsMarked from tb_TeacherAttendance_Info where TeacherID='" + teacherid + "' and [Current]='" + currentweek + "'and Course='" + currentcourse + "'and Week='" + week + "'and Time='" + time + "'";
            return DBA.DBHelper.getDtFromSQL(strSQL);
        }

    }
}
