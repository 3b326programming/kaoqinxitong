using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBA;

public partial class EmptyData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            TextBox1.Text = BLL.EmptyData.GetDataAllTheacher();
            TextBox2.Text = BLL.EmptyData.GetDatawaipinTeacher();
            TextBox3.Text = BLL.EmptyData.GetDatajiaowuchu();
            TextBox4.Text = BLL.EmptyData.GetDatakuaiji();
            TextBox5.Text = BLL.EmptyData.GetDataXinXi();
            TextBox6.Text = BLL.EmptyData.GetDatawaiyu();
            TextBox7.Text = BLL.EmptyData.GetDatajixiegongcheng();
            TextBox8.Text = BLL.EmptyData.GetDataShiPin();
            TextBox9.Text = BLL.EmptyData.GetDataJingGuan();
            TextBox10.Text = BLL.EmptyData.GetDataJianZhu();
            TextBox11.Text = BLL.EmptyData.GetDatajichujiaoxue();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DBHelper.getDtFromSQL("truncate table tb_AllTeacher_Info");
        TextBox1.Text = BLL.EmptyData.GetDataAllTheacher();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        DBHelper.getDtFromSQL("truncate table tb_ExtemalTCH_Info");
        TextBox2.Text = BLL.EmptyData.GetDatawaipinTeacher();

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        DBHelper.getDtFromSQL("truncate table tb_Stu_Info");
        TextBox3.Text = BLL.EmptyData.GetDatajiaowuchu();
    }

    

    protected void Button4_Click1(object sender, EventArgs e)
    {
        DBHelper.getDtFromSQL("delete from tb_AllInformation where TeaDepartment='会计系'");


        DBHelper.getDtFromSQL("delete from tb_Course_Info where Department='会计系'");
        DBHelper.getDtFromSQL("delete from tb_CourseClass_Info where Course not in (select Course from tb_Course_Info)");

        DBHelper.getDtFromSQL("delete from tb_StuDepartment_Info where Department='会计系'");

        DBHelper.getDtFromSQL("delete from tb_StuCourseClass_Info where CourseClass not in (select CourseClass from tb_Course_Info)");

        TextBox4.Text = BLL.EmptyData.GetDatakuaiji();

    }
    protected void Button5_Click1(object sender, EventArgs e)
    {
        DBHelper.getDtFromSQL("delete from tb_AllInformation where TeaDepartment='信息工程系'");

        DBHelper.getDtFromSQL("delete from tb_Course_Info where Department='信息工程系'");
        DBHelper.getDtFromSQL("delete from tb_CourseClass_Info where Course not in (select Course from tb_Course_Info)");

        DBHelper.getDtFromSQL("delete from tb_StuDepartment_Info where Department='信息工程系'");

        DBHelper.getDtFromSQL("delete from tb_StuCourseClass_Info where CourseClass not in (select CourseClass from tb_Course_Info)");

        TextBox5.Text = BLL.EmptyData.GetDataXinXi();
    }
    protected void Button6_Click1(object sender, EventArgs e)
    {
        DBHelper.getDtFromSQL("delete from tb_AllInformation where TeaDepartment='商务外语系'");

        DBHelper.getDtFromSQL("delete from tb_Course_Info where Department='商务外语系'");
        DBHelper.getDtFromSQL("delete from tb_CourseClass_Info where Course not in (select Course from tb_Course_Info)");

        DBHelper.getDtFromSQL("delete from tb_StuDepartment_Info where Department='商务外语系'");

        DBHelper.getDtFromSQL("delete from tb_StuCourseClass_Info where CourseClass not in (select CourseClass from tb_Course_Info)");

        TextBox6.Text = BLL.EmptyData.GetDatawaiyu();
    }
    protected void Button7_Click1(object sender, EventArgs e)
    {
        DBHelper.getDtFromSQL("delete from tb_AllInformation where StuDepartment='机械工程系'");

        TextBox7.Text = BLL.EmptyData.GetDatajixiegongcheng();

    }
    protected void Button8_Click1(object sender, EventArgs e)
    {
        DBHelper.getDtFromSQL("delete from tb_AllInformation where TeaDepartment='食品工程系'");

        TextBox8.Text = BLL.EmptyData.GetDataShiPin();
    }
    protected void Button9_Click1(object sender, EventArgs e)
    {
        DBHelper.getDtFromSQL("delete from tb_AllInformation where StuDepartment='经济管理系'");

        DBHelper.getDtFromSQL("delete from tb_Course_Info where Department='经济管理系'");
        DBHelper.getDtFromSQL("delete from tb_CourseClass_Info where Course not in (select Course from tb_Course_Info)");

        DBHelper.getDtFromSQL("delete from tb_StuDepartment_Info where Department='经济管理系'");

        DBHelper.getDtFromSQL("delete from tb_StuCourseClass_Info where CourseClass not in (select CourseClass from tb_Course_Info)");

        TextBox9.Text = BLL.EmptyData.GetDataJingGuan();

    }
    protected void Button10_Click1(object sender, EventArgs e)
    {
        DBHelper.getDtFromSQL("delete from tb_AllInformation where TeaDepartment='建筑工程系'");

        DBHelper.getDtFromSQL("delete from tb_Course_Info where Department='建筑工程系'");
        DBHelper.getDtFromSQL("delete from tb_CourseClass_Info where Course not in (select Course from tb_Course_Info)");

        DBHelper.getDtFromSQL("delete from tb_StuDepartment_Info where Department='建筑工程系'");

        DBHelper.getDtFromSQL("delete from tb_StuCourseClass_Info where CourseClass not in (select CourseClass from tb_Course_Info)");

        TextBox10.Text = BLL.EmptyData.GetDataJianZhu();

    }
    protected void Button11_Click1(object sender, EventArgs e)
    {
        DBHelper.getDtFromSQL("delete from tb_AllInformation where TeaDepartment='基础教学部'");

        TextBox11.Text = BLL.EmptyData.GetDatajichujiaoxue();
    }
}