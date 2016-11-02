using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;


public partial class benxiaojiaoshi : System.Web.UI.Page
{
    
        
       
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            DropDownList1.Items.Add("所有记录");
            DropDownList1.Items.Add("按部门查询");
            DropDownList1.Items.Add("按教师工号查询");
            DropDownList1.Items.Add("按教师姓名查询");
            DropDownList1.Items.Add("按教师权限查询");
            GridView1.DataSource = Class1.Griview("Department", "信息工程系");
            GridView1.DataBind();
            this.GridView1.Visible = true;
        }


       

        
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {


        //GridView1.DataSource = Class1.Griview("1", "1");
        //GridView1.DataBind();
       
        if (DropDownList1.SelectedItem.Text == "按部门查询")
        {
            GridView1.DataSource = Class1.Griview("Department", TextBox1.Text);
            GridView1.DataBind();
        }
        else if (DropDownList1.SelectedItem.Text == "按教师工号查询")
        {
            GridView1.DataSource = Class1.Griview("UserID", TextBox1.Text);
            GridView1.DataBind();
        }
        else if (DropDownList1.SelectedItem.Text == "按教师姓名查询")
        {
            GridView1.DataSource = Class1.Griview("UserName", TextBox1.Text);
            GridView1.DataBind();
        }
        else if (DropDownList1.SelectedItem.Text == "按教师权限")
        {
            GridView1.DataSource = Class1.Griview("Role", TextBox1.Text);
            GridView1.DataBind();
        }
    }
}
