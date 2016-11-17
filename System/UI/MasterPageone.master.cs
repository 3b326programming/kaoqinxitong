using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using System.Data.SqlClient;
public partial class MasterPageone : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["UserName"].ToString();
        Label2.Text = Session["Role"].ToString();
        Label3.Text = Session["CurrentWeek"].ToString();
        Label4.Text = "当前在线" + Application["online"].ToString() + "人";

        if (!IsPostBack)
        {

            if (Session["Role"].ToString() == "系统管理员")
            {

                string SQL = "select city from tb_TreeView_Info where judge=1";
                DataTable dt = Class1.getDT(SQL);

                TreeNode Tn1 = new TreeNode();
                Tn1.Text = "管理员面板";
                TreeView1.Nodes.Add(Tn1);

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    TreeNode tn1 = new TreeNode();
                    tn1.Text = dt.Rows[i][0].ToString();
                    Tn1.ChildNodes.Add(tn1);
                    String SQL1 = "select city from tb_TreeView_Info where bianhao=" + (i + 2) + " and judge=2";
                    DataTable dt1 = Class1.getDT(SQL1);
                    //  DataTable dt1 = getDT("select city from city where bianhao=" + (i + 2) + " and judge=2");

                    for (int j = 0; j < dt1.Rows.Count; j++)
                    {

                        TreeNode tn2 = new TreeNode();
                        tn2.Text = dt1.Rows[j][0].ToString();

                        tn1.ChildNodes.Add(tn2);
                    }
                }
            }

            else if (Session["Role"].ToString() == "院系领导")
            {
                TreeNode TN1 = new TreeNode();
                TN1.Text = "管理面板";
                TreeView1.Nodes.Add(TN1);


                string SQL = "select city from city where judge=11";
                DataTable dt = Class1.getDT(SQL);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TreeNode tn1 = new TreeNode();
                    tn1.Text = dt.Rows[i][0].ToString();
                    TN1.ChildNodes.Add(tn1);
                    string SQL1 = "select city from city where bianhao=" + (i + 8) + "and judge=2";
                    DataTable dt1 = Class1.getDT(SQL1);
                    for (int j = 0; j < dt1.Rows.Count; j++)
                    {

                        TreeNode tn2 = new TreeNode();
                        tn2.Text = dt1.Rows[j][0].ToString();
                        tn1.ChildNodes.Add(tn2);
                    }
                }
            }
            else if (Session["Role"].ToString() == "学管人员")
            {
                string SQL = "select city from city where judge=22";
                DataTable dt = Class1.getDT(SQL);

                TreeNode Tn1 = new TreeNode();
                Tn1.Text = "管理面板";
                TreeView1.Nodes.Add(Tn1);

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    TreeNode tn1 = new TreeNode();
                    tn1.Text = dt.Rows[i][0].ToString();
                    Tn1.ChildNodes.Add(tn1);
                    String SQL1 = "select city from city where bianhao=" + (i + 11) + " and judge=2";
                    DataTable dt1 = Class1.getDT(SQL1);
                    //  DataTable dt1 = getDT("select city from city where bianhao=" + (i + 2) + " and judge=2");

                    for (int j = 0; j < dt1.Rows.Count; j++)
                    {

                        TreeNode tn2 = new TreeNode();
                        tn2.Text = dt1.Rows[j][0].ToString();

                        tn1.ChildNodes.Add(tn2);
                    }
                }
            }
            else if (Session["Role"].ToString() == "教师")
            {
                string SQL = "select city from city where judge=33";
                DataTable dt = Class1.getDT(SQL);

                TreeNode Tn1 = new TreeNode();
                Tn1.Text = "教师面板";
                TreeView1.Nodes.Add(Tn1);

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    TreeNode tn1 = new TreeNode();
                    tn1.Text = dt.Rows[i][0].ToString();
                    Tn1.ChildNodes.Add(tn1);
                    String SQL1 = "select city from city where bianhao=" + (i + 14) + " and judge=2";
                    DataTable dt1 = Class1.getDT(SQL1);


                    for (int j = 0; j < dt1.Rows.Count; j++)
                    {

                        TreeNode tn2 = new TreeNode();
                        tn2.Text = dt1.Rows[j][0].ToString();

                        tn1.ChildNodes.Add(tn2);
                    }
                }
            }
        }



    }
   
    protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
    {
        if (TreeView1.SelectedNode.Text == "本校教师")
        {
            Response.Redirect("Default.aspx");
        }
        else if(TreeView1.SelectedNode.Text == "导入数据")
        {
            Response.Redirect("LoadExcelToDataBase.aspx");
        }
        else if (TreeView1.SelectedNode.Text == "清空数据")
        {
            Response.Redirect("EmptyData.aspx");
        }
        else if (TreeView1.SelectedNode.Text == "修改密码")
        {
            Response.Redirect("ChangePWD.aspx");
        }
    }

        
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        
    }
}

