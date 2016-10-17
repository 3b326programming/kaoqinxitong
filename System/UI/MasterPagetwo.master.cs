using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

public partial class MasterPagetwo : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TreeNode TN1 = new TreeNode();
        TN1.Text = "管理面板";
        TreeView1.Nodes.Add(TN1);
  
       
        string SQL="select city from city where judge=11";
        DataTable dt = Class1.getDT(SQL);
        for (int i=0; i < dt.Rows.Count; i++) {
            TreeNode tn1 = new TreeNode();
            tn1.Text = dt.Rows[i][0].ToString();
            TN1.ChildNodes.Add(tn1);
            string SQL1 = "select city from city where bianhao=" + (i + 8) +"and judge=2";
            DataTable dt1=Class1.getDT(SQL1);
            for(int j=0;j<dt1.Rows.Count;j++){

                TreeNode tn2=new TreeNode ();
                tn2.Text=dt1.Rows[j][0].ToString();
                tn1.ChildNodes.Add(tn2);
            }
        }


    }
    protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
    {
        if (TreeView1.SelectedNode.Text == "个人信息")
        {
            Response.Redirect("Default.aspx");
        }

    }
}
