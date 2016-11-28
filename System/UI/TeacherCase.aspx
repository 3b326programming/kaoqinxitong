<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageone.master" AutoEventWireup="true" CodeFile="TeacherCase.aspx.cs" Inherits="TeacherCase" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<div>
      <div> 
         查询范围:  
          <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
              onselectedindexchanged="DropDownList1_SelectedIndexChanged">
          </asp:DropDownList> 
            &nbsp;&nbsp;
          <asp:Label ID="Label1" runat="server" Text="查询条件"></asp:Label>
          &nbsp;<asp:TextBox ID="txtLimit" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" Text="查询" 
              onclick="Button1_Click" />
  
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
  
      </div>
      <div>
          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
              CellPadding="4" ForeColor="#333333" GridLines="None" Height="210px" 
              Width="782px" AllowPaging="True" 
              onpageindexchanged="GridView1_PageIndexChanged" 
              onrowcancelingedit="GridView1_RowCancelingEdit" 
              onselectedindexchanged="GridView1_SelectedIndexChanged" 
              onrowdeleting="GridView1_RowDeleting" 
              onrowupdating="GridView1_RowUpdating" 
              onpageindexchanging="GridView1_PageIndexChanging" 
              onrowediting="GridView1_RowEditing" 
              onrowdatabound="GridView1_RowDataBound">
              <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
              <Columns>
                  <asp:BoundField HeaderText="教工号" DataField="TeacherID" ReadOnly="True" >
                  <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                  </asp:BoundField>
                  <asp:BoundField HeaderText="姓名" ReadOnly="True" >
                  <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                  </asp:BoundField>
                  <asp:BoundField HeaderText="周次" DataField="Current" ReadOnly="True" >
                  <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                  </asp:BoundField>
                  <asp:BoundField HeaderText="星期" DataField="Week" ReadOnly="True" >
                  <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                  </asp:BoundField>
                  <asp:BoundField HeaderText="节次" DataField="Time" ReadOnly="True" >
                  <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                  </asp:BoundField>
                  <asp:BoundField HeaderText="课程" DataField="Course" ReadOnly="True" >
                  <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                  </asp:BoundField>
                  <asp:BoundField HeaderText="考勤情况" DataField="IsAttendance" >
                  <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                  </asp:BoundField>
                  <asp:CommandField HeaderText="编辑" ShowEditButton="True" >
                  <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                  </asp:CommandField>
              </Columns>
              <EditRowStyle BackColor="#999999" />
              <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
              <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
              <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
              <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
              <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
              <SortedAscendingCellStyle BackColor="#E9E7E2" />
              <SortedAscendingHeaderStyle BackColor="#506C8C" />
              <SortedDescendingCellStyle BackColor="#FFFDF8" />
              <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
          </asp:GridView>

      </div> 
</div>
</asp:Content>

