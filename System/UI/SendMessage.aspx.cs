using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BLL;

public partial class SendMessage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /* if (!IsPostBack)
        {
            if (Session["Role"].ToString() != "系统管理员")
                Response.Redirect("~//Default.aspx");
        }*/
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int MessageID;
        string Message = Request.Form["TextArea"];//获取texearea中的文本
        string messageTime = System.DateTime.Now.ToString();//获取当前时间
        SendMessage_Class.addMessages(Message, messageTime);//向数据库的tb_Message_Info表中添加信息
        string messageID=SendMessage_Class.selectMessageID(Message);
        int j;
        for (j = 0; j >= 0;j++)
        {
            if (j.ToString() == messageID)
            {
                MessageID = j;//获得当前发送消息编号

                int LeaderRole = 2;
                int SecretaryRole = 3;
                int TeacherRole = 4;
                if (chkLeader.Checked == true)
                {
                    DataTable dt = SendMessage_Class.selectuserID(LeaderRole);   //查询对应权限的教师ID  获取返回值
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string LeaderID = dt.Rows[i][0].ToString();
                        SendMessage_Class.addTeacherMessage(LeaderID, MessageID);
                    }
                }
                if (chkSecretary.Checked == true)
                {
                    DataTable dt = SendMessage_Class.selectuserID(SecretaryRole);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string SecretaryID = dt.Rows[i][0].ToString();
                        SendMessage_Class.addTeacherMessage(SecretaryID, MessageID);
                    }
                }
                if (chkTeachers.Checked == true)
                {
                    DataTable dt = SendMessage_Class.selectuserID(TeacherRole);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string TeacherID = dt.Rows[i][0].ToString();
                        SendMessage_Class.addTeacherMessage(TeacherID, MessageID);
                    }
                }
            break;
            }
            
        }
        lblMessage.Text = "发布成功！";
        
    }
}
