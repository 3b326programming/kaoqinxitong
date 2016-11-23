using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using BLL;

public partial class AttendanceDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
        if (!IsPostBack)
        {
            VisbleFalse();
            if (CompareWeek())
            {
                if (CheckIsRecord())
                {
                    Label6.Visible = true;
                    Label6.Text = "您已经录入本次考勤!";
                    GridView1.Visible = false;

                }
                else
                {
                    DataTable dt = BLL.getCourse.getcount(Session["UserID"].ToString(), Session["CurrentCourse"].ToString(), Session["Time"].ToString(), Session["Week"].ToString());
                    int a = dt.Rows.Count;

                    Label6.Visible = true;
                    string strCourse = Session["CurrentCourse"].ToString();
                    Label6.Text = Session["Week"].ToString() + Session["Time"].ToString() + "|" +strCourse.Substring(8,strCourse.Length-11) + "|" +a + "人";
                    this.GridView1.BackColor = System.Drawing.Color.White;
                  

                }



            }
            else
            {
                Label6.Visible = true;
                Label6.Text = "本门课程尚未结束，请于课程结束后录入";
                GridView1.Visible = false;
                

            }
        }
    }
    private void VisbleFalse()
    {
        Label1.Visible = false;
        Label2.Visible = false;
        Label3.Visible = false;
        Label4.Visible = false;
        Label5.Visible = false;
        Label6.Visible = false;
        DropDownList1.Visible = false;
        
        Button2.Visible = false;
        Button3.Visible = false;
        CheckBox1.Visible = false;
    }
    protected void rdo_CheckChange(object sender, EventArgs e)
    {
        Button2.Visible = true;
        
        foreach (GridViewRow row in GridView1.Rows)
       
        {
            
            Control ctl1 = row.FindControl("RadioButton1");
            Control ctl2 = row.FindControl("RadioButton2");
            Control ctl3 = row.FindControl("RadioButton3");
            Control ctl4 = row.FindControl("RadioButton4");
            Control ctl5 = row.FindControl("RadioButton5");
            Control ctl6 = row.FindControl("RadioButton6");
            TableCellCollection cell = row.Cells;
            if ((ctl1 as RadioButton).Checked)
            {
                
                GridView1.Rows[row.RowIndex].BackColor = System.Drawing.Color.White;
            }
            if ((ctl2 as RadioButton).Checked)
            {
                GridView1.Rows[row.RowIndex].BackColor = System.Drawing.Color.Yellow;
            }
            if ((ctl3 as RadioButton).Checked)
            {
                GridView1.Rows[row.RowIndex].BackColor = System.Drawing.Color.Red;
            }
            if ((ctl4 as RadioButton).Checked)
            {
                GridView1.Rows[row.RowIndex].BackColor = System.Drawing.Color.Yellow;
            }
            if ((ctl5 as RadioButton).Checked)
            {
                GridView1.Rows[row.RowIndex].BackColor = System.Drawing.Color.SkyBlue;
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
        DataTable dt = BLL.getCourse.getIsRecord(Session["UserID"].ToString(), Session["CurrentWeek"].ToString(), Session["CurrentCourse"].ToString(), Session["Week"].ToString(), Session["Time"].ToString());
        string a = dt.Rows[0]["IsAttendance"].ToString().Trim();
        if (dt.Rows[0]["IsAttendance"].ToString().Trim() == "False")
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

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
    protected void Button2_Click(object sender, EventArgs e)
    
      
    {
        
        StringBuilder strLate = new StringBuilder("迟到名单：");
        StringBuilder strAbsence = new StringBuilder("旷课名单：");
        StringBuilder strEarly = new StringBuilder("早退名单：");
        StringBuilder strLeave = new StringBuilder("请假名单：");
        int sum = 0;
        foreach (GridViewRow row in this.GridView1.Rows)
        {
            Control ct2 = row.FindControl("RadioButton2");
            Control ct3 = row.FindControl("RadioButton3");
            Control ct4 = row.FindControl("RadioButton4");
            Control ct5 = row.FindControl("RadioButton5");
            TableCellCollection cell = row.Cells;
            if ((ct2 as RadioButton).Checked)
            {
                if (BLL.getCourse.insertInto(Session["UserID"].ToString(), cell[2].Text.ToString(), Session["CurrentCourse"].ToString(), Session["CurrentWeek"].ToString(), Session["Week"].ToString(), Session["Time"].ToString(), "迟到"))
                {
                    sum++;
                    strLate.Append(cell[3].Text.ToString() + ";");
                }
            }
            if ((ct3 as RadioButton).Checked)
            {
                if (BLL.getCourse.insertInto(Session["UserID"].ToString(), cell[2].Text.ToString(), Session["CurrentCourse"].ToString(), Session["CurrentWeek"].ToString(), Session["Week"].ToString(), Session["Time"].ToString(), "旷课"))
                {
                    sum++;
                    strAbsence.Append(cell[3].Text.ToString() + ";");
                }
            }
            if ((ct4 as RadioButton).Checked)
            {
                if (BLL.getCourse.insertInto(Session["UserID"].ToString(), cell[2].Text.ToString(), Session["CurrentCourse"].ToString(), Session["CurrentWeek"].ToString(), Session["Week"].ToString(), Session["Time"].ToString(), "早退"))
                {
                    sum++;
                    strEarly.Append(cell[3].Text.ToString() + ";");
                }
            }
            if ((ct5 as RadioButton).Checked)
            {
                if (BLL.getCourse.insertInto(Session["UserID"].ToString(), cell[2].Text.ToString(), Session["CurrentCourse"].ToString(), Session["CurrentWeek"].ToString(), Session["Week"].ToString(), Session["Time"].ToString(), "请假"))
                {
                    sum++;
                    strLeave.Append(cell[3].Text.ToString() + ";");
                }
            }
        }
        if (strLate.ToString() == "迟到名单：")
            strLate.Append("无");
        if (strAbsence.ToString() == "旷课名单：")
            strAbsence.Append("无");
        if (strEarly.ToString() == "早退名单：")
            strEarly.Append("无");
        if (strLeave.ToString() == "请假名单：")
            strLeave.Append("无");
        bool b = getCourse.updateInto("1", "1", Session["UserID"].ToString(), Session["CurrentCourse"].ToString(), Session["CurrentWeek"].ToString(), Session["Week"].ToString(), Session["Time"].ToString());
        if (b)
        {
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            Label5.Visible = true;
            
            Label1.Text = strAbsence.ToString();
            Label2.Text = strLate.ToString();
            Label3.Text = strEarly.ToString();
            Label4.Text = strLeave.ToString();
            strLate.Remove(0, strLate.Length);
            strEarly.Remove(0, strEarly.Length);
            strLeave.Remove(0, strLeave.Length);
            strAbsence.Remove(0, strAbsence.Length);
            Label5.Text = "本次考勤记录已经上报成功!本次课您" + Session["Homework"].ToString() + ",请返回主页面!";
        }
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminSubmitAttendance.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {

    }
}
