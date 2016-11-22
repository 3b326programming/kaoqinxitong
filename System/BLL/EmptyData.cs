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
        //获取会计系的数据
        public static string GetDatakuaiji()
        {
            DBHelper.getDtFromSQL("select count(*) from tb_AllInformation where TeaDepartment ='会计系'");
            DataTable dt = new DataTable();
            dt = DBHelper.getDtFromSQL("select count(*) from tb_AllInformation where TeaDepartment ='会计系'");
            return dt.Rows[0][0].ToString();
        }
        //获取基础教学部数据
        public static string GetDatajichujiaoxue()
        {
            DBHelper.getDtFromSQL("select count(*) from tb_AllInformation where TeaDepartment ='基础教学部'");
            DataTable dt = new DataTable();
            dt = DBHelper.getDtFromSQL("select count(*) from tb_AllInformation where TeaDepartment ='基础教学部'");
            return dt.Rows[0][0].ToString();
        }
        //获取机械工程系数据
        public static string GetDatajixiegongcheng()
        {
            DBHelper.getDtFromSQL("select count(*) from tb_AllInformation where StuDepartment='机械工程系'");
            DataTable dt = new DataTable();
            dt = DBHelper.getDtFromSQL("select count(*) from tb_AllInformation where StuDepartment ='机械工程系'");
            return dt.Rows[0][0].ToString();
        }
        //获取信息工程系数据
        public static string GetDataXinXi()
        {
            DBHelper.getDtFromSQL("select count (*) from tb_AllInformation where TeaDepartment ='信息工程系'");
            DataTable dt = new DataTable();
            dt = DBHelper.getDtFromSQL("select count (*) from tb_AllInformation where TeaDepartment ='信息工程系'");
            return dt.Rows[0][0].ToString();
        }
        //获取商务外语系数据
        public static string GetDatawaiyu()
        {
            DBHelper.getDtFromSQL("select count(*) from tb_AllInformation where TeaDepartment ='商务外语系'");
            DataTable dt = new DataTable();
            dt = DBHelper.getDtFromSQL("select count(*) from tb_AllInformation where TeaDepartment ='商务外语系'");
            return dt.Rows[0][0].ToString();

        }
        //获取食品工程系数据
        public static string GetDataShiPin()
        {
            DBHelper.getDtFromSQL("select count(*) from tb_AllInformation where StuDepartment ='食品工程系'");
            DataTable dt = new DataTable();
            dt = DBHelper.getDtFromSQL("select count(*) from tb_AllInformation where StuDepartment ='食品工程系'");
            return dt.Rows[0][0].ToString();
        }
        //获取经管系数据
        public static string GetDataJingGuan()
        {
            DBHelper.getDtFromSQL("select count(*) from tb_AllInformation where StuDepartment ='经济管理系'");
            DataTable dt = new DataTable();
            dt = DBHelper.getDtFromSQL("select count(*) from tb_AllInformation where StuDepartment ='经济管理系'");
            return dt.Rows[0][0].ToString();
        }
        //获取建筑工程系数据
        public static string GetDataJianZhu()
        {
            DBHelper.getDtFromSQL("select count(*) from tb_AllInformation where TeaDepartment ='建筑工程系'");
            DataTable dt = new DataTable();
            dt = DBHelper.getDtFromSQL("select count(*) from tb_AllInformation where TeaDepartment ='建筑工程系'");
            return dt.Rows[0][0].ToString();

        }

    }
}
