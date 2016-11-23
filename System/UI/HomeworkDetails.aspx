<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageone.master" AutoEventWireup="true" CodeFile="HomeworkDetails.aspx.cs" Inherits="HomeworkDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><br />
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br />
    <asp:Label ID="Label1" runat="server" Text="lblmessage"></asp:Label><br />
<asp:Button ID="Button1" runat="server" Text="上报作业情况" onclick="Button1_Click" />&nbsp;
<asp:Button ID="Button2" runat="server" Text="返回主页面" onclick="Button2_Click" />&nbsp;
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" 
        CellPadding="2" ForeColor="Black" GridLines="None" 
         Width="809px" 
        DataSourceID="SqlDataSource1" AllowPaging="True" 
        onrowdatabound="GridView1_RowDataBound" PageSize="12" AllowSorting="True" 
        onselectedindexchanged="GridView1_SelectedIndexChanged">
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
            <asp:TemplateField HeaderText="作业完成情况">
            <ItemTemplate>
                 <asp:RadioButton ID="RadioButton1" runat="server" Text="已完成作业" Checked="true" AutoPostBack="true" Visible="True" OnCheckedChanged="rdo_CheckChange" GroupName="g"/>
                 <asp:RadioButton ID="RadioButton2" runat="server" Text="未完成作业" AutoPostBack="true" OnCheckedChanged="rdo_CheckChange" GroupName="g"/>
            </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:TemplateField>
            </Columns>
            <PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:aaaConnectionString %>" 
    SelectCommand="SELECT distinct [Department], [StuName], [CourseClass], [StuID] FROM [Teacher_Attendance] WHERE (([TeacherID] = @TeacherID) AND ([Course] = @Course) AND ([Time] = @Time) AND ([Week] = @Week))">
        <SelectParameters>
            <asp:SessionParameter Name="TeacherID" SessionField="UserID" Type="String" />
            <asp:SessionParameter Name="Course" SessionField="CurrentCourse" 
                Type="String" />
            <asp:SessionParameter Name="Time" SessionField="Time" Type="String" />
            <asp:SessionParameter Name="Week" SessionField="Week" Type="String" />
        </SelectParameters>
</asp:SqlDataSource>
</asp:Content>

