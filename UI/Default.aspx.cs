using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Class1.Login(TextBox1.Text, TextBox2.Text))
        {
            Label3.Text = "登录成功";
            Label4.Text = Class1.getUserrode(TextBox1.Text);
        }
        else
        {
            Label3.Text = "登录失败";
        }
    }
}