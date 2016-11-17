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
            //DataTable dt = getDT("select city from city where judge=1");
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
    }
    //public static DataTable getDT(string SQL)
    //{
    //    string strConn = "data source=.;initial catalog=Treeview;uid=sa;password=sa";
    //    SqlConnection conn = new SqlConnection(strConn);
    //    conn.Open();
    //    DataTable dt = new DataTable();
    //    SqlDataAdapter da = new SqlDataAdapter(SQL, conn);
    //    da.Fill(dt);
    //    conn.Close();
    //    return dt;
    //}
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
