using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;

public partial class adminDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label1.Text = Session["userid"] + "你好，你的权限为：" + Session["rode"];
            DataTable dt = Class1.getClass();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DropDownList1.Items.Add(dt.Rows[i][0].ToString());
            }
        }
    }
}