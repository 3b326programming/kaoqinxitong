using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBA;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public  class EmptyData
    {
        //获取本校教师人数
        public static string GetDataAllTheacher()
        {
            DBHelper.getDtFromSQL("select count(*) from tb_AllTeacher_Info where Role='4'");
            DataTable dt = new DataTable();
            dt = DBHelper.getDtFromSQL("select count(*) from tb_AllTeacher_Info where Role='4'");
            return dt.Rows[0][0].ToString();
        }
        //获取外聘教师人数
        public static string GetDatawaipinTeacher()
        {
            DBHelper.getDtFromSQL("select count(*) from tb_ExtemalTCH_Info");
            DataTable dt = new DataTable();
            dt = DBHelper.getDtFromSQL("select count(*) from tb_ExtemalTCH_Info");
            return dt.Rows[0][0].ToString();
        }
        //获取教务处的数据量
        public static string GetDatajiaowuchu()
        {
            DBHelper.getDtFromSQL("select count(*) from tb_Stu_Info ");
            DataTable dt = new DataTable();
            dt = DBHelper.getDtFromSQL("select count(*) from tb_Stu_Info ");
            return dt.Rows[0][0].ToString();
        }

    }
}
