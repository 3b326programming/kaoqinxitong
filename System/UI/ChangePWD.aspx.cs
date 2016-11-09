using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

public partial class ChangePWD : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        Label2.Visible = false;
        Label3.Visible = false;
        TextBox3.Visible = false;
        TextBox4.Visible = false;
        Button1.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (TextBox3.Text == TextBox4.Text)
        {
            if (BLL.changepwd.getid(TextBox1.Text).Rows.Count == 0)
            {
                string pwd = changepwd.getPTTpwd(TextBox1.Text).Rows[0][0].ToString();
                BLL.changepwd.UpdatePTTpwd(TextBox3.Text, pwd);
                Response.Write("<script>alert('修改成功')</script>");
                TextBox1.Text = "";
            }
            else if (BLL.changepwd.getid(TextBox1.Text).Rows.Count != 0)
            {
                string pwd = changepwd.getpwd(TextBox1.Text).Rows[0][0].ToString();
                BLL.changepwd.UpdatePwd(TextBox3.Text, pwd);
                Response.Write("<script>alert('修改成功')</script>");
                TextBox1.Text = "";
            }

        }

        else if (TextBox3.Text != TextBox4.Text)
        {
            Response.Write("<script>alert('两次输入的新密码不相符')</script>");
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox1.Text = "";
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (BLL.changepwd.getid(TextBox1.Text).Rows.Count == 0)
        {
            string name = BLL.changepwd.getPTTid(TextBox1.Text).Rows[0][0].ToString();
            Label1.Text = "您即将对" + name + "的账户更改密码";
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            TextBox3.Visible = true;
            TextBox4.Visible = true;
            Button1.Visible = true;
        }
        else if (BLL.changepwd.getid(TextBox1.Text).Rows.Count != 0)
        {
            string name = BLL.changepwd.getid(TextBox1.Text).Rows[0][0].ToString();
            Label1.Text = "您即将对" + name + "的账户更改密码";
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            TextBox3.Visible = true;
            TextBox4.Visible = true;
            Button1.Visible = true;
        }
        else if (TextBox1.Text == "")
        {
            Response.Write("<script>alert('请输入工号')</script>");
        }
    }
}