using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

public partial class HomeworkDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Visible = false;
        Label3.Visible = false;
        if (!IsPostBack)
        {
            if (CompareWeek())
            {
                if (CheckIsRecord())
                {
                    Label1.Text = "您已经批改本次作业!";
                }
                else
                {
                    DataTable dt = BLL.getCourse.getcount(Session["UserID"].ToString(), Session["CurrentCourse"].ToString(), Session["Time"].ToString(), Session["Week"].ToString());
                    int a = dt.Rows.Count;
                    string strCourse = Session["CurrentCourse"].ToString();
                    Label1.Text= Session["Week"].ToString() + Session["Time"].ToString() + "|" + strCourse.Substring(8, strCourse.Length - 11) + "|" + a + "人";

                }



            }
            else
            {
                
                Label1.Text = "本门课程尚未结束！请您布置作业后在批改！";
                GridView1.Visible = false;
            }
        }

    }
    private bool CompareWeek()
    {
        int Week = 0;
        int CurrentWeek = 0;
        switch (DateTime.Now.DayOfWeek.ToString())
        {
            case "Monday":
                CurrentWeek = 1;
                break;
            case "Tuesday":
                CurrentWeek = 2;
                break;
            case "Wednesday":
                CurrentWeek = 3;
                break;
            case "Thursday":
                CurrentWeek = 4;
                break;
            case "Friday":
                CurrentWeek = 5;
                break;
            case "Saturday":
                CurrentWeek = 6;
                break;
            case "Sunday":
                CurrentWeek = 7;
                break;
            default:
                CurrentWeek = 0;
                break;
        }
        switch (Session["Week"].ToString())
        {
            case "星期一":
                Week = 1;
                break;
            case "星期二":
                Week = 2;
                break;
            case "星期三":
                Week = 3;
                break;
            case "星期四":
                Week = 4;
                break;
            case "星期五":
                Week = 5;
                break;
            case "星期六":
                Week = 6;
                break;
            case "星期天":
                Week = 7;
                break;
            default:
                Week = 0;
                break;
        }
        if (CurrentWeek > Week)
        {
            return true;
        }
        if (CurrentWeek == Week)
        {
            int aa = 0;
            switch (Session["Time"].ToString())
            {
                case "1-2节":
                    aa = 10;
                    break;
                case "3-4节":
                    aa = 12;
                    break;
                case "5-6节":
                    aa = 16;
                    break;
                case "7-8节":
                    aa = 18;
                    break;
                case "9-10节":
                    aa = 20;
                    break;
                default:
                    aa = 0;
                    break;
            }
            if (DateTime.Now.Hour >= aa)
                return true;
            else
                return false;
        }
        else
        {
            return false;
        }
    }
    private bool CheckIsRecord()
    {
        DataTable dt = BLL.getCourse.GetIsRecord(Session["UserID"].ToString(), Session["HomeWorkWeek"].ToString(), Session["CurrentCourse"].ToString(), Session["Week"].ToString(), Session["Time"].ToString());
        if (dt.Rows[0]["IsMarked"].ToString().Trim() == "False")
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    protected void rdo_CheckChange(object sender, EventArgs e)
    {
        foreach (GridViewRow row in this.GridView1.Rows)
        {
            Control ct1 = row.FindControl("RadioButton1");
            Control ct2 = row.FindControl("RadioButton2");
            TableCellCollection cell = row.Cells;
            if ((ct1 as RadioButton).Checked)
            {
                GridView1.Rows[row.RowIndex].BackColor = System.Drawing.Color.White;
            }
            if ((ct2 as RadioButton).Checked)
            {
                GridView1.Rows[row.RowIndex].BackColor = System.Drawing.Color.Red;
            }
        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                e.Row.Attributes.Add("onmouseover", "d=this.style.backgroundColor;this.style.backgroundColor='Olive'");

                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=d");
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label2.Visible = true;
        Label3.Visible = true;
        StringBuilder isfinished = new StringBuilder("作业未完成名单：");
        int sum = 0;
        foreach (GridViewRow row in this.GridView1.Rows)
        {
            Control ct1 = row.FindControl("RadioButton2");
            TableCellCollection cell = row.Cells;
            if ((ct1 as RadioButton).Checked)
            {
                if (BLL.getCourse.insertInto(Session["UserID"].ToString(), cell[2].Text.ToString(), Session["CurrentCourse"].ToString(), Session["CurrentWeek"].ToString(), Session["Week"].ToString(), Session["Time"].ToString(), "0"))
                {
                    sum++;
                    isfinished.Append(cell[3].Text.ToString() + ";");
                }
            }
        }
        if (isfinished.ToString() == "")
            isfinished.Append("无");
        bool b=BLL.getCourse.UpdateInto( "True", Session["UserID"].ToString(), Session["CurrentCourse"].ToString(), Session["HomeWorkWeek"].ToString(), Session["Week"].ToString(), Session["Time"].ToString());
        if (b)
        {
            Label3.Text = isfinished.ToString();
            isfinished.Remove(0, isfinished.Length);
            Label2.Text = "本次作业批改已结束，请返回主页面";
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminSubmitAttendance.aspx");
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}