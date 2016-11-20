using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CurrentWeek();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Class1.Login(TextBox1.Text, TextBox2.Text))
        {
            string name = BLL.topmenu.getUsername(TextBox1.Text).Rows[0][0].ToString();
            string role = BLL.topmenu.getUserrole(TextBox1.Text).Rows[0][0].ToString();
            Session["UserName"] = name;
            Session["UserID"] = TextBox1.Text;
            switch (role)
            {
                case "1":
                    Session["Role"] = "系统管理员";
                    Response.Redirect("Default.aspx");
                    break;
                case "2":
                    Session["Role"] = "院系领导";
                    Response.Redirect("AdminSubmitAttendance.aspx");
                    break;
                case "3":
                    Session["Role"] = "学管人员";
                    Response.Redirect("AdminSubmitAttendance.aspx");
                    break;
                case "4":
                    Session["Role"] = "教师";
                    Response.Redirect("AdminSubmitAttendance.aspx");
                    break;
            }
            
        }
        else
        {
            Label1.Text = "登录失败";
        }
    }
    private void CurrentWeek()
    {
        DataTable dt = BLL.topmenu.getSQL();
        foreach (DataRow row in dt.Rows)
        {
            if (Convert.ToDateTime(row["StartWeek"]) < DateTime.Now && Convert.ToDateTime(row["EndWeek"]) > DateTime.Now)
            {
                string strWeekNumber = row["WeekNumber"].ToString();
                if (strWeekNumber.Length == 1)
                    strWeekNumber = "0" + strWeekNumber;
                Session["CurrentWeek"] = strWeekNumber;
                break;

            }
            else
            {
                Session["CurrentWeek"] = "0";

            }
        }
    }
}