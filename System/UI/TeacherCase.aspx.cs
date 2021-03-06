﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Data.SqlClient;

public partial class TeacherCase : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //if (Session["UserID"].ToString() == "")
            //{
            //    Response.Redirect("Login.aspx");
            //}
            //else
            //{
            DataTable dt = FindCase.findAll("tb_TeacherAttendance_Info");
            BindToView(dt);


            string[] str = { "所有记录", "按周次查询", "按教工工号查询", "按按教工姓名查询" };
            foreach (string str1 in str)
            {
                DropDownList1.Items.Add(str1);

            }
            txtLimit.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
           
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.ToString() == "所有记录")
        {
            txtLimit.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
        }
        else
        {
            Label1.Visible = true;
            txtLimit.Visible = true;
            Label2.Visible = false;
        }

    }
    protected void BindToView(DataTable dt)           //  绑定数据的方法
    {
        GridView1.DataSource = dt;
        GridView1.DataKeyNames = new string[] { "TeacherID", "Current", "Week", "Time"};
        GridView1.DataBind();
    }
    protected void Bind()                           //分情况进行数据绑定
    {
        DataTable dt = new DataTable();

        try
        {
            switch (DropDownList1.SelectedItem.ToString())
            {
                case "所有记录":
                    dt = FindCase.findAll("tb_TeacherAttendance_Info");
                    BindToView(dt); break;
                case "按周次查询":
                    dt = FindCase.findSelected("tb_TeacherAttendance_Info", "[Current]", txtLimit.Text.Trim());
                    BindToView(dt); break;
                case "按教工工号查询":
                    dt = FindCase.findSelected("tb_TeacherAttendance_Info", "TeacherID", txtLimit.Text.Trim());
                    BindToView(dt); break;
                case "按按教工姓名查询":
                    dt = FindCase.findSelected("tb_TeacherAttendance_Info", "TeacherName", txtLimit.Text.Trim());
                    BindToView(dt); break;
                default:
                    break;
            }
            Label2.Visible = true;
            Label2.Text = "查询成功";

        }
        catch
        {

            Response.Write("<script>alert('输入数据不合法,条件有误')</script>");
            txtLimit.Text = "";


        }
        //if (DropDownList1.SelectedValue.ToString()=="所有记录")    
        //{
        //    DataTable dt = FindCase.findAll("tb_TeacherAttendance_Info");
        //    BindToView(dt); 

        //}
        //else if (DropDownList1.Items.ToString() != "所有记录" && txtLimit.Text != "")
        //{
        //    try
        //    {
        //        DataTable dt=FindCase.

        //    }
        //    catch { }



    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Bind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }





    protected void GridView1_PageIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)    //分页功能
    {

        GridView1.PageIndex = e.NewPageIndex;
        Bind();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)        //出现“更改”和“取消”
    {
        GridView1.EditIndex = e.NewEditIndex;
        Bind();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)    //“更新”取消
    {
        GridView1.EditIndex = -1;
        Bind();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)  //更新功能
    {

        string isAttendance = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[6].Controls[0])).Text.ToString().Trim();

        string strUserID = GridView1.DataKeys[e.RowIndex].Values[0].ToString();
        string strCurrent = GridView1.DataKeys[e.RowIndex].Values[1].ToString();
        string strWeek = GridView1.DataKeys[e.RowIndex].Values[2].ToString();
        string strTime = GridView1.DataKeys[e.RowIndex].Values[3].ToString();
      
        try
        {
            FindCase.rowupdate("tb_TeacherAttendance_Info", "IsAttendance", isAttendance, "TeacherID", strUserID, "[Current]", strCurrent, "Week", strWeek, "Time", strTime);
        }
        catch{
            Response.Write("<script>alert('数据类型不合法,条件有误')</script>");
        
        }
        GridView1.EditIndex = -1;
        Bind();


    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)     //无效的事件
    {
        FindCase.rowdelete("tb_TeacherAttendance_Info", "TeacherID", GridView1.DataKeys[e.RowIndex].Value.ToString());
        Bind();
    }


    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                e.Row.Attributes.Add("onmouseover", "d=this.style.backgroundColor;this.style.backgroundColor='gray'");

                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=d");
            }
        }

    }
}