using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

public partial class LoadExcelToDataBase : System.Web.UI.Page
{
    HttpPostedFile file;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
            DropDownList1.Items.Add("教务处");
            DropDownList1.Items.Add("会计系");
            DropDownList1.Items.Add("机械工程系");
            DropDownList1.Items.Add("基础教学部");
            DropDownList1.Items.Add("经济管理系");
            DropDownList1.Items.Add("商务外语系");
            DropDownList1.Items.Add("信息工程系");
            DropDownList1.Items.Add("食品工程系");
            DropDownList1.Items.Add("建筑工程系");
            
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         file = FileUpload1.PostedFile;
        string fileName = file.FileName;
        if (RadioButton1.Checked)
        {
            
            
            if (fileName != string.Empty)
            {
                file.SaveAs(Class1.UploadExcel(fileName));
                Class1.Clear("tb_AllTeacher_Info");
                lblMessage1.Text = Class1.ReadTeacherExceltoSQL("tb_AllTeacher_Info", Class1.ReadExcelToDatatable("Sheet1"));
            }
            else
            {
                lblMessage1.Text = "文件为空，请重新选择！";

            }
        }
        else if (RadioButton2.Checked)
        {
            if (fileName != string.Empty)
            {
                file.SaveAs(Class1.UploadExcel(fileName));
                Class1.Clear("tb_ExtemalTCH_Info");
                lblMessage1.Text = Class1.ReadTeacherExceltoSQL("tb_ExtemalTCH_Info", Class1.ReadExcelToDatatable("Sheet1"));
            }
            else
            {
                lblMessage1.Text = "文件为空，请重新选择！";
            }
        }
        else
        {
            lblMessage1.Text = "请先选择导入的数据是“本校教师”或“外聘教师”";
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        file = FileUpload2.PostedFile;
        string fileName = file.FileName;
        if (fileName != string.Empty)
        {
            
            file.SaveAs(Class1.UploadExcel(fileName));
            
            lblMessage2.Text = Class1.ReadCourseExcelToSQL("tb_AllInformation", Class1.ReadExcelToDatatable(DropDownList1.SelectedItem.ToString()));
        }
        else
        {
            lblMessage1.Text = "文件为空，请重新选择！";
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        file = FileUpload3.PostedFile;
        string fileName = file.FileName;
        if (fileName != string.Empty)
        {

            file.SaveAs(Class1.UploadExcel(fileName));
            Class1.Clear("tb_Calendar");
            lblMessage5.Text = Class1.ReadCalendarExcelToSQL("tb_Calendar", Class1.ReadExcelToDatatable("Sheet1"));
        }
        else
        {
            lblMessage5.Text = "文件为空，请重新选择！";
        }
    }
}