<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageone.master" AutoEventWireup="true" CodeFile="benxiaojiaoshi.aspx.cs" Inherits="shiyan" %>

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
    
      width:55%;
      margin-left:auto;
      margin-right:auto;
      
     
      }
   
</style>
<div class=top ><img alt=""src="images/more3.jpg" style="padding-top:6px"/></div>
    <div class=top1><asp:Label ID="Label1" runat="server" Text="查询范围"></asp:Label>
    <asp:DropDownList ID="DropDownList1"
        runat="server" AutoPostBack="True" Font-Size="12pt" Width="135px" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem>所有记录</asp:ListItem>
        <asp:ListItem>按部门查询</asp:ListItem>
        <asp:ListItem>按教师工号查询</asp:ListItem>
        <asp:ListItem>按权限查询</asp:ListItem>
    </asp:DropDownList>
        <asp:Label ID="Label2" runat="server" Text="查询条件"></asp:Label><asp:TextBox ID="TextBox1"
            runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="查询" onclick="Button1_Click" /></div>
    <div class="top2"  ><asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
        GridLines="None" PageSize="16" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" 
        onpageindexchanging="GridView1_PageIndexChanging" 
        onrowcancelingedit="GridView1_RowCancelingEdit" 
        onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" 
        onrowupdating="GridView1_RowUpdating" ForeColor="#333333" 
            onrowdatabound="GridView1_RowDataBound">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="Department" HeaderText="所属部门" ReadOnly="True">
            <ControlStyle Width="100px" />
            <ItemStyle Width="100px" HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>
            <asp:BoundField DataField="UserID" HeaderText="教师工号" ReadOnly="True">
            <ControlStyle Width="100px" />
            <ItemStyle Width="100px" HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>
            <asp:BoundField DataField="UserName" HeaderText="教师姓名" ReadOnly="True">
            <ControlStyle Width="100px" />
            <ItemStyle Width="100px" HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>
            <asp:BoundField DataField="UserPWD" HeaderText="用户密码" Visible="False">
            <ControlStyle Width="100px" />
            <ItemStyle Width="100px" HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>
            <asp:BoundField DataField="Role" HeaderText="教师权限">
            <ControlStyle Width="100px" />
            <ItemStyle Width="100px" HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>
            <asp:CommandField HeaderText="编辑" ShowEditButton="True">
            <ControlStyle Width="100px" />
            <ItemStyle Width="70px" HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:CommandField>
            <asp:CommandField HeaderText="删除" ShowDeleteButton="True">
            <ControlStyle Width="100px" />
            <ItemStyle Width="70px" HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:CommandField>
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
    <div class=top><img alt=""src="images/more3.jpg" style="padding-top:6px"/></div>
</asp:Content>

