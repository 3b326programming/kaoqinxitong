using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBA;

public partial class EmptyData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            TextBox1.Text = BLL.EmptyData.GetDataAllTheacher();
            TextBox2.Text = BLL.EmptyData.GetDatawaipinTeacher();
            TextBox3.Text = BLL.EmptyData.GetDatajiaowuchu();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DBHelper.getDtFromSQL("truncate table tb_AllTeacher_Info");
        TextBox1.Text = BLL.EmptyData.GetDataAllTheacher();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        DBHelper.getDtFromSQL("truncate table tb_ExtemalTCH_Info");
        TextBox2.Text = BLL.EmptyData.GetDatawaipinTeacher();

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        DBHelper.getDtFromSQL("truncate table tb_Stu_Info");
        TextBox3.Text = BLL.EmptyData.GetDatajiaowuchu();
    }
}