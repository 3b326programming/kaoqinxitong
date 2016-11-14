using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Data.SqlClient;

public partial class shiyan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = tb_AllTeacher_Info.find();
            BindToGridView(dt);
            Label2.Visible = false;
            TextBox1.Visible = false;
         

        }
    }

    protected void Bind()
    {
        if (DropDownList1.SelectedItem.ToString() == "所有记录")
        {
            DataTable dt = tb_AllTeacher_Info.find();
            BindToGridView(dt);

        }
        else if (DropDownList1.SelectedItem.ToString() != "所有记录" && TextBox1.Text != "")
        {
            if (DropDownList1.SelectedItem.Text == "按部门查询")
            {
                DataTable dt = tb_AllTeacher_Info.Griview("Department", TextBox1.Text);
                BindToGridView(dt);

            }
            else if (DropDownList1.SelectedItem.Text == "按教师工号查询")
            {
                DataTable dt = tb_AllTeacher_Info.Griview("UserID", TextBox1.Text);
                BindToGridView(dt);
            }
            else if (DropDownList1.SelectedItem.Text == "按教师姓名查询")
            {
                DataTable dt = tb_AllTeacher_Info.Griview("UserName", TextBox1.Text);
                BindToGridView(dt);
            }
            else if (DropDownList1.SelectedItem.Text == "按教师权限")
            {
                DataTable dt = tb_AllTeacher_Info.Griview("Role", TextBox1.Text);
                BindToGridView(dt);
            }

        }
    }
    protected void BindToGridView(DataTable dt)
    {
        GridView1.DataSource = dt;
        GridView1.DataKeyNames = new string[] { "UserID" };
        GridView1.DataBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.ToString() == "所有记录")
        {
            Label2.Visible = false;
            TextBox1.Visible = false;
        }
        else
        {
            Label2.Visible = true;
            TextBox1.Visible = true;
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;

        Bind();
        

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        
        
    
        
            Bind();
        
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        Bind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        // if(Class1.rowdelete("UserID",GridView1.DataKeys[e.RowIndex].Value.ToString()))
        tb_AllTeacher_Info.rowdelete("UserID", GridView1.DataKeys[e.RowIndex].Value.ToString());
        {
            Bind();
        }

    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        
        string strUserRole = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[4].Controls[0])).Text.ToString();
        string strUserID = GridView1.DataKeys[e.RowIndex].Value.ToString();
        tb_AllTeacher_Info.rowupdate("Role", strUserRole, "UserID", strUserID);
        
           
           
        
        GridView1.EditIndex = -1;
        Bind();
        

    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                e.Row.Attributes.Add("onmouseover", "d=this.style.backgroundColor;this.style.backgroundColor='#3FF'");

                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=d");
                if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
                {
                    ((LinkButton)e.Row.Cells[6].Controls[0]).Attributes.Add("onclick", "javascript:return confirm('您确认要删除:\"" + e.Row.Cells[2].Text + "\"吗?')");
                }

            }
        }
       

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Bind();
    }
}
