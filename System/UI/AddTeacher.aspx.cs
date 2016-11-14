using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class AddTeacher : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblMessage.Visible = false;
        if (!IsPostBack)
        {
            string[] str1 ={"安全保卫处","办公室" ,"教务处","会计系"," 经济管理系", "食品工程系", "机械工程系"　,"信息工程系","商务外语系","基础教学部","总务处","组织人事处","招生就业办公室","办公室"　
             　,"校领导","宿舍管理中心","图书馆","饮食服务中心"," 学生工作处","实训中心","教学研究室","网络信息中心","成人教育处","建筑工程系"};
            foreach (string i in str1)
            {
                TeacherDepartment.Items.Add(i);
            }
            string[] str2={"1  (系统管理员)","2  (院系领导)","3  (辅导员)","4  (教师)"};
            foreach (string i in str2)
            {
                TeacherRole.Items.Add(i);
            
            }


        }

    }
   
    
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {
       
    
    }
    private void Clear()
    {
        UserId.Text = "";
        UserName.Text = "";
        UserPWD.Text = "";
        TextBox4.Text = "";
        RadioButtonList1.SelectedIndex = 0;
        TeacherDepartment.SelectedIndex = 0;
        TeacherRole.SelectedIndex = 0;



    }



    protected void btn_OK_Click(object sender, EventArgs e)
    {
        if (UserId.Text == "" || UserName.Text == "" || UserPWD.Text == "")
        {
            if (UserId.Text == "")

            { Response.Write("<script>alert('教师工号不能为空啊！@.@')</script>)"); }
            else if (UserName.Text == "")
            {
                Response.Write("<script>alert('姓名不可为空!')</script>");

            }
            else
            {
                Response.Write("<script>alert('密码不可为空！')</script>");

            }


        }
        else if (UserPWD.Text != TextBox4.Text)
        {
            Response.Write("<script>alert('两次输入的密码不匹配!请重新输入。。。')</script>");
            UserPWD.Text = "";
            TextBox4.Text = "";
            
        }
        else
        {
            All_OK();
        }
   
    }
    protected void btn_Cancle_Click1(object sender, EventArgs e)
    {
        Clear();
    }
    private void All_OK() {                                    //特殊情况检查完毕
        string teacherType = "";
        string teacherRole = "";
        switch (TeacherType.SelectedItem.ToString())         
        {
            case "本校教师": teacherType = "tb_AllTeacher_Info"; break;         //本校教师表名
            case "外聘教师": teacherType = "tb_ExtemalTCH_Info"; break;         //外聘教师表明

            default: break;
          
        
        
        }
        switch (TeacherRole.SelectedItem.ToString())
        {
            case  "1  (系统管理员)": teacherRole = "1"; break;
            case  "2  (院系领导)"  :teacherRole="2";break;
            case  "3  (辅导员)"    :teacherRole="3";break;
            case "4  (教师)": teacherRole = "4"; break;
            default: break;
       }
        try
        {
            if (Insert2DB(teacherType, teacherRole))
            {
                Clear();
                lblMessage.Text = "添加成功";

            }
        }
        catch {
            Clear();
            lblMessage.Text = "输入有误！请检查输入的教师工号等信息!教师工号不可重复!";
        
        
          }
       ;
       
    
    }


    private bool  Insert2DB(string  teacherType,string teacherRole) {                                    //插入数据库

        string strConn = "data source=.;initial catalog=AttendanceSys_database;uid=sa;password=sa;";
        SqlConnection conn = new SqlConnection(strConn);
        conn.Open();
        string StrSQL = "insert into "+teacherType+" values ('" + UserId.Text + "','" + UserName.Text + "','" + UserPWD.Text + "','" + teacherRole
         + "','" + RadioButtonList1.SelectedItem.ToString() + "','" + TeacherDepartment.SelectedItem + "')";
        SqlCommand cmd = new SqlCommand(StrSQL, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
        lblMessage.Visible = true;
        

        return true;
    
    }
}