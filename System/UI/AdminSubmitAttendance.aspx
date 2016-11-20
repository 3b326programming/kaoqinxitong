<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageone.master" AutoEventWireup="true" CodeFile="AdminSubmitAttendance.aspx.cs" Inherits="AdminSubmitAttendance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <style type="text/css">
    
    </style>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <asp:Repeater ID="rptCourse" runat="server" OnItemCommand="rptCourse_ItemCommand">
    <HeaderTemplate>
        <table border="0" style="width:1000px" cellspacing="0" cellpadding="0">
            <tr>
                <td colspan="4" style="width:1000px;height:30px">
                    <asp:Label ID="Label1" runat="server" Text="本周授课信息:"></asp:Label>
                </td>
            </tr>
    </HeaderTemplate>
    <ItemTemplate>
        <tr style="text-align:center">
            <td width="100px"><%#Container.ItemIndex+1 %>&nbsp;</td>
            <td width="500px"><%#DataBinder.Eval(Container.DataItem,"Week") %><%#DataBinder.Eval(Container.DataItem,"Time") %><%#(DataBinder.Eval(Container.DataItem,"Course")).ToString().Substring(0,(DataBinder.Eval(Container.DataItem,"Course")).ToString().Length-3) %>
            <asp:TextBox ID="txtCourse" runat="server" Visible="false" Text='<%#DataBinder.Eval(Container.DataItem,"Course") %>'></asp:TextBox>
            <asp:TextBox ID="txtWeek" runat="server" Visible="false" Text='<%#DataBinder.Eval(Container.DataItem,"Week") %>'></asp:TextBox>
            <asp:TextBox ID="txtTime" runat="server" Visible="false" Text='<%#DataBinder.Eval(Container.DataItem,"Time") %>'></asp:TextBox>
            <%--<asp:TextBox ID="txtWeekRange" runat="server" Visible="false" Text='<%#DataBinder.Eval(Container.DataItem,"StudentIDList") %>'></asp:TextBox>--%>
            </td>
            <td width="200px"><asp:CheckBox ID="chkHomework" Text="布置作业" runat="server" /></td>
            <td width="200px"><asp:Button ID="btnClick" CssClass="btn" Text="考勤" Width="100" runat="server" OnClick="BtnSubmit_Click" /></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="5"><hr /></td>
        </tr>
    </ItemTemplate>
    <FooterTemplate>
    </table>
    </FooterTemplate>
    </asp:Repeater>
    <asp:Repeater ID="rptHomework" runat="server" OnItemCommand="rptCourse_ItemCommand">
        <HeaderTemplate>
        <table border="0" style="width:1000px" cellspacing="0" cellpadding="0">
            <tr>
                <td colspan="4" style="width:1000px;height:30px">
                    <asp:Label ID="Label1" runat="server" Text="上周作业未批改情况:"></asp:Label>
                </td>
            </tr>
    </HeaderTemplate>
    <ItemTemplate>
        <tr style="text-align:center">
            <td width="200px"><%#Container.ItemIndex+1 %>&nbsp;</td>
            <td width="500px"><%#DataBinder.Eval(Container.DataItem,"Week") %><%#DataBinder.Eval(Container.DataItem,"Time") %><%#(DataBinder.Eval(Container.DataItem,"Course")).ToString().Substring(0,(DataBinder.Eval(Container.DataItem,"Course")).ToString().Length-3) %>
            <asp:TextBox ID="txtCourse" runat="server" Visible="false" Text='<%#DataBinder.Eval(Container.DataItem,"Course") %>'></asp:TextBox>
            <asp:TextBox ID="txtWeek" runat="server" Visible="false" Text='<%#DataBinder.Eval(Container.DataItem,"Week") %>'></asp:TextBox>
            <asp:TextBox ID="txtTime" runat="server" Visible="false" Text='<%#DataBinder.Eval(Container.DataItem,"Time") %>'></asp:TextBox>
            <%--<asp:TextBox ID="txtWeekRange" runat="server" Visible="false" Text='<%#DataBinder.Eval(Container.DataItem,"StudentIDList") %>'></asp:TextBox>--%>
            </td>
            <td width="200px"><asp:Button ID="btnClick" CssClass="btn" Text="批改" Width="100" runat="server" OnClick="BtnSubmit_Click" /></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="5"><hr /></td>
        </tr>
    </ItemTemplate>
    <FooterTemplate>
    </table>
    </FooterTemplate>
    </asp:Repeater>
</asp:Content>

