using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

public partial class LoadExcelToDataBase : System.Web.UI.Page
{
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
        
        HttpPostedFile file = FileUpload1.PostedFile;
        string fileName = file.FileName;
        if (RadioButton1.Checked)
        {
           // RadioButton1.AutoCheck = true;
            
            if (fileName != string.Empty)
            {
               
                file.SaveAs(Class1.Upload(fileName));
                Class1.Clear("tb_AllTeacher_Info");
                lblMessage1.Text = Class1.TeacherTable("tb_AllTeacher_Info", Class1.LoadToExcel("Sheet1"));
                //lblMessage1.Text = Class1.TeacherTable( Class1.LoadToExcel("Sheet1"));
            }
            else
            {
                lblMessage1.Text = "文件为空，请重新选择！";

            }
            RadioButton1.Checked = false;
        }
        else if (RadioButton2.Checked)
        {
            
            if (fileName != string.Empty)
            {
                file.SaveAs(Class1.Upload(fileName));
                Class1.Clear("tb_ExtemalTCH_Info");
                lblMessage1.Text = Class1.TeacherTable("tb_ExtemalTCH_Info", Class1.LoadToExcel("Sheet1"));
            }
            else
            {
                lblMessage1.Text = "文件为空，请重新选择！";
            }
            RadioButton2.Checked = false;
        }
        else
        {
            lblMessage1.Text = "请先选择导入的数据是“本校教师”或“外聘教师”";
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        HttpPostedFile file = FileUpload2.PostedFile;
        string fileName = file.FileName;
        if (fileName != string.Empty)
        {
            
            file.SaveAs(Class1.Upload(fileName));

            lblMessage2.Text = Class1.CourseTable("tb_AllInformation", Class1.LoadToExcel(DropDownList1.SelectedItem.ToString()));
        }
        else
        {
            lblMessage1.Text = "文件为空，请重新选择！";
        }
    }
}