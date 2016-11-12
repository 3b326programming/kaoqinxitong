using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBA;
using System.Data;

namespace BLL
{
    public class tb_AllTeacher_Info
    {
        public static void rowupdate(string role, string struserrole, string userid, string struserid)
        {
            string SQL = "update tb_AllTeacher_Info set " + role + "='" + struserrole + "'where " + userid + "='" + struserid + "'";
            DBHelper.GETDTA(SQL);
        }
        public static void rowdelete(string id, string key)
        {
            string SQL = "delete from tb_AllTeacher_Info where " + id + "='" + key + "'";
            DBHelper.GETDTA(SQL);
        }
        public static DataTable find()
        {
            string SQL = "select * from tb_AllTeacher_Info";
            DataTable dt = DBHelper.GetDT(SQL);
            return dt;
        }
        public static DataTable Griview(string column, string name)
        {
            string SQL = "select * from tb_AllTeacher_Info where " + column + "='" + name + "'";

            DataTable dt = DBHelper.GetDT(SQL);
            return dt;

        }
    }
}
