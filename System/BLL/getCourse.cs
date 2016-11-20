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
    }
}
