using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
public partial class MasterPagefour : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
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
    protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
    {
        if (TreeView1.SelectedNode.Text == "修改密码")
        {
            Response.Redirect("Default.aspx");
        }

    }
    }
