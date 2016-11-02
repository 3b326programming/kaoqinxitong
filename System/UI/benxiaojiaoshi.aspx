<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageone.master" AutoEventWireup="true" CodeFile="benxiaojiaoshi.aspx.cs" Inherits="benxiaojiaoshi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <style type="text/css">
    .top
 {
     width:100%;
     height:30px;
     background-color:#3FF;
     }
   .top1
 {
     margin-left:auto;
     margin-right:auto;
     width:50%;
     height:30px;
     
     }
  .top2
  {
      width:50%;
      
      margin-left:auto;
      margin-right:auto;
      padding-left:20px;
      }
</style>
<div class=top><img alt="" src="images/more3.jpg" style="padding-top:6px"/></div>
<div class=top1>
    查询范围<asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>查询条件<asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="确定" 
        onclick="Button1_Click" /></div>
 <div class=top2>
<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" 
         AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
         GridLines="None" PageSize="15">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:BoundField DataField="Department" HeaderText="所属部门" />
        <asp:BoundField DataField="UserID" HeaderText="教师工号" />
        <asp:BoundField DataField="UserName" HeaderText="教师姓名" />
        <asp:BoundField DataField="Role" HeaderText="教师权限" />
        <asp:CommandField HeaderText="编辑" ShowEditButton="True" />
        <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
    </Columns>
    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
    <SortedAscendingCellStyle BackColor="#FDF5AC" />
    <SortedAscendingHeaderStyle BackColor="#4D0000" />
    <SortedDescendingCellStyle BackColor="#FCF6C0" />
    <SortedDescendingHeaderStyle BackColor="#820000" />

</asp:GridView>
</div>
</asp:Content>

