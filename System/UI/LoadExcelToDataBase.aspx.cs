﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

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
            lblMessage3.Text = "";
           // RadioButton1.AutoCheck = true;
            
            if (fileName != string.Empty)
            {
              

                file.SaveAs(Class1.UploadExcel(fileName));
                Class1.Clear("tb_AllTeacher_Info");
                lblMessage1.Text = Class1.ReadTeacherExceltoSQL("tb_AllTeacher_Info", Class1.ReadExcelToDatatable("Sheet1"));
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
            lblMessage3.Text = "";
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
            RadioButton2.Checked = false;
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
    protected void Button3_Click1(object sender, EventArgs e)
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
            lblMessage5.Text = "请选择文件！";
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {

        DataTable dt = AddSQLStringTODAL.GetDatatableBySQL("tb_AllTeacher_Info");
        DataTable dt1 = AddSQLStringTODAL.GetDatatableBySQL("tb_ExtemalTCH_Info");
        if (dt.Rows.Count > 0 || dt1.Rows.Count > 0)
        {
            InitialPWD();
        }
        else
        {
            lblMessage3.Text = "请先导入数据...";
        }

          
     }
    private void InitialPWD()
    {
        DataTable dt = AddSQLStringTODAL.GetDatatableBySQL("tb_AllTeacher_Info");
        // string str1 = PWDProcess.MD5Encrypt(dt.Rows[0][0].ToString(),PWDProcess.CreateKey(dt.Rows[0][0].ToString()));
        
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            string strTeacher = PWDProcess.MD5Encrypt(dt.Rows[i][0].ToString(), PWDProcess.CreateKey(dt.Rows[i][0].ToString()));
            AddSQLStringTODAL.UpdateTabTeacher("tb_AllTeacher_Info", strTeacher, dt.Rows[i][0].ToString());
            

        }
        

        DataTable dt1 = AddSQLStringTODAL.GetDatatableBySQL("tb_ExtemalTCH_Info");
        for (int j = 0; j < dt1.Rows.Count; j++)
        {
            string strThoerTeacher = PWDProcess.MD5Encrypt(dt1.Rows[j][0].ToString(), PWDProcess.CreateKey(dt1.Rows[j][0].ToString()));
            AddSQLStringTODAL.UpdateTabTeacher("tb_ExtemalTCH_Info", strThoerTeacher, dt1.Rows[j][0].ToString());

        }
        lblMessage3.Text = "初始化密码完成...";
    }
    protected void Button6_Click(object sender, EventArgs e)
    {

    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        FillAllSQLdataTable.FillSQLTeacherAttendance();
        FillAllSQLdataTable.FillSQLCourse();
        FillAllSQLdataTable.FillSQLCourseClass();
        FillAllSQLdataTable.FillSQLStuCourseClass();
        FillAllSQLdataTable.FillSQLStuOriClass();
        FillAllSQLdataTable.FillSQLStu();
        FillAllSQLdataTable.FillSQLStuDepartment();
        lblMessage7.Text = "处理完毕";
    }
}