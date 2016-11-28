<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageone.master" AutoEventWireup="true" CodeFile="HomeworkCase.aspx.cs" Inherits="HomeworkCase" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<div>
     <div> 
         查询范围:  
          <asp:DropDownList ID="DropDownList1" runat="server" 
             onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
             AutoPostBack="True">
          </asp:DropDownList> 
            &nbsp;&nbsp;
          <asp:Label ID="Label1" runat="server" Text="查询条件"></asp:Label>
          &nbsp;<asp:TextBox ID="txtLimit" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" Text="查询" 
             onclick="Button1_Click" />
  
      &nbsp;&nbsp;
         <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
  
      &nbsp;&nbsp;
         <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
  
      </div>
      <div> 
          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
              CellPadding="4" ForeColor="#333333" GridLines="None" 
              onselectedindexchanged="GridView1_SelectedIndexChanged" AllowPaging="True" 
              onpageindexchanging="GridView1_PageIndexChanging" 
              onrowcancelingedit="GridView1_RowCancelingEdit" 
              onrowediting="GridView1_RowEditing" onrowupdating="GridView1_RowUpdating" 
              Height="340px" Width="679px" AccessKey=" ">
              <AlternatingRowStyle BackColor="White" />
              <Columns>
                  <asp:BoundField HeaderText="教工号" DataField="TeacherID" ReadOnly="True" />
                  <asp:BoundField HeaderText="姓名" ReadOnly="True" />
                  <asp:BoundField HeaderText="周次" DataField="Current" ReadOnly="True" />
                  <asp:BoundField HeaderText="星期" DataField="Week" ReadOnly="True" />
                  <asp:BoundField HeaderText="节次" DataField="Time" ReadOnly="True" />
                  <asp:BoundField HeaderText="课程" DataField="CourseClass" ReadOnly="True" />
                  <asp:BoundField HeaderText="作业情况" DataField="IsHomework" />
                  <asp:BoundField HeaderText="批改情况" DataField="IsMarked" />
                  <asp:CommandField HeaderText="编辑" ShowEditButton="True" />
              </Columns>
              <EditRowStyle BackColor="#7C6F57" />
              <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
              <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
              <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
              <RowStyle BackColor="#E3EAEB" />
              <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
              <SortedAscendingCellStyle BackColor="#F8FAFA" />
              <SortedAscendingHeaderStyle BackColor="#246B61" />
              <SortedDescendingCellStyle BackColor="#D4DFE1" />
              <SortedDescendingHeaderStyle BackColor="#15524A" />
          </asp:GridView>

      </div> 
</div>
</asp:Content>

