using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data;
using BLL;

public partial class GetMessage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind();
        }
    }
    private void Bind()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("Message");
        dt.Columns.Add("MessageTime");

        DataTable MessageID = GetMessage_Class.GetMessageID(Session["UserID"].ToString());
        for (int i = 0; i < MessageID.Rows.Count; i++)
        {
            string MessageId = MessageID.Rows[i][0].ToString();
            DataRow dr = dt.NewRow();
            dr["Message"] = GetMessage_Class.GetMessage(MessageId).Rows[0][0];
            dr["MessageTime"] = GetMessage_Class.GetMessage(MessageId).Rows[0][1];
            dt.Rows.Add(dr);
        }
        if (dt.Rows.Count == 0)
        {
            Response.Redirect("AdminSubmitAttendance.aspx");
        }
        else
        {

            rptMessage.DataSource = dt;
            rptMessage.DataBind();
        }
    }
    protected void rptMessage_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        GetMessage_Class.DeleteMessage(Session["UserID"].ToString());
        Response.Redirect("AdminSubmitAttendance.aspx");
    }
}