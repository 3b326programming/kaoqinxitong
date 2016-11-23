<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageone.master" AutoEventWireup="true" CodeFile="AttendanceDetails.aspx.cs" Inherits="AttendanceDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <style type="text/css">
    
   .top
 {
     width:100%;
     height:20px;
     background-color:#3FF;
 }
 .top1
 {
     
 
     width:100%;
     height:20px;
    
 }
 .content
 {
      width:60%;
      margin:0 auto;
     
     
 }
 img
 {
     padding-top:3px;
     }
 
     
         
        
    
        
        
            
        
    
    </style>
   <div class="top"><img src="images/more3.jpg" alt=""/><asp:Label ID="Label1" runat="server" Text="lblAttendanceMessage"></asp:Label></div>
    <div class="top1"><img src="images/more3.jpg" alt="" /><asp:Label ID="Label2" runat="server" Text="lblLateMessage"></asp:Label></div>
    <div class="top"><img src="images/more3.jpg" alt="" /><asp:Label ID="Label3" runat="server" Text="lblEarlyMessage"></asp:Label></div>
   <div class="top1"><img src="images/more3.jpg" alt="" /><asp:Label ID="Label4" runat="server" Text="lblLeaveMessage"></asp:Label></div>
   <div class="top"><img src="images/more3.jpg" alt="" /><asp:Label ID="Label5" runat="server" Text="lblResultMessage"></asp:Label></div>
   <div class="top1"><img src="images/more3.jpg" alt="" /><asp:Label ID="Label6" runat="server" Text="lblMessage"></asp:Label></div>
   <div class="top"><img src="images/more3.jpg" alt="" />&nbsp;<asp:Button ID="Button1" runat="server" Text="返回主页面" onclick="Button1_Click" />&nbsp;
    <asp:Button ID="Button2" runat="server" Text="上报考勤结果" onclick="Button2_Click" />&nbsp;
    <asp:CheckBox ID="CheckBox1" runat="server" Text="教学异动" />&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>&nbsp;
    <asp:Button ID="Button3" runat="server" Text="确定" onclick="Button3_Click" />

    
    </div>
    <div class="content">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" 
        CellPadding="2" ForeColor="Black" GridLines="None"
        onselectedindexchanged="GridView1_SelectedIndexChanged" Width="809px" 
        DataSourceID="SqlDataSource1" 
        onrowdatabound="GridView1_RowDataBound" PageSize="12" AllowSorting="True" 
        CssClass="style1" 
       >
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:BoundField DataField="Department" HeaderText="所属系部" 
                SortExpression="Department">
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>
            <asp:BoundField DataField="CourseClass" HeaderText="班级" 
                SortExpression="CourseClass">
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>
            <asp:BoundField DataField="StuID" HeaderText="学号" SortExpression="StuID">
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>
            <asp:BoundField DataField="StuName" HeaderText="姓名" SortExpression="StuName">
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="出勤情况">
             <ItemTemplate>
                 <asp:RadioButton ID="RadioButton1" runat="server" Text="正常" Checked="true" AutoPostBack="true" Visible="True" OnCheckedChanged="rdo_CheckChange" GroupName="g"/>
                 <asp:RadioButton ID="RadioButton2" runat="server" Text="迟到" AutoPostBack="true" OnCheckedChanged="rdo_CheckChange" GroupName="g"/>
                 <asp:RadioButton ID="RadioButton3" runat="server" Text="旷课" AutoPostBack="true" OnCheckedChanged="rdo_CheckChange" GroupName="g"/>
                 <asp:RadioButton ID="RadioButton4" runat="server" Text="早退" AutoPostBack="true" OnCheckedChanged="rdo_CheckChange" GroupName="g"/>
                 <asp:RadioButton ID="RadioButton5" runat="server" Text="请假" AutoPostBack="true" OnCheckedChanged="rdo_CheckChange" GroupName="g"/>
                 
             </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
            HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <SortedAscendingCellStyle BackColor="#FAFAE7" />
        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
        <SortedDescendingCellStyle BackColor="#E1DB9C" />
        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:aaaConnectionString %>" 
    
            SelectCommand="SELECT Distinct [Department], [StuName], [StuID], [CourseClass] FROM [Teacher_Attendance] WHERE (([TeacherID] = @TeacherID) AND ([Course] = @Course) AND ([Time] = @Time) AND ([Week] = @Week))">
        <SelectParameters>
            <asp:SessionParameter Name="TeacherID" SessionField="UserID" Type="String" />
            <asp:SessionParameter Name="Course" SessionField="CurrentCourse" 
                Type="String" />
            <asp:SessionParameter Name="Time" SessionField="Time" Type="String" />
            <asp:SessionParameter Name="Week" SessionField="Week" Type="String" />
        </SelectParameters>
</asp:SqlDataSource>
</div>

 
</asp:Content>

