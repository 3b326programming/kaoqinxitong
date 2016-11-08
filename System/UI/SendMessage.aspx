<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageone.master" AutoEventWireup="true" CodeFile="SendMessage.aspx.cs" Inherits="SendMessage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<table border="0" style="width:100%;height:20px">
<tr style="background-color:#3FF" ><td colspan="4"><img alt="" src="images/more3.jpg" />发布通知</td></tr>
<tr><td colspan="4"><asp:Label ID="lblMessage" runat="server" Text="lblMessage"></asp:Label></td></tr>
<tr><td style="width:25%"><asp:CheckBox ID="chkLeader" runat="server" Text="院系领导" /></td><td style="width:25%">
    <asp:CheckBox ID="chkSecretary" runat="server" Text="各系辅导员" /></td>
    <td  style="width:25%">
        <asp:CheckBox ID="chkTeachers" runat="server" 
            Text="本学期所有有课教师" /></td><td></td></tr>
</table>



<table style="width:75%">
<tr style="height:400px"><td>
    <textarea id="TextArea1" name="TextArea" style="height:400px; width:100%";rows="";cols=""></textarea></td></tr>
<tr><td align="center"><asp:Button ID="Button1" runat="server" Text="确定" 
        Width="80px" onclick="Button1_Click" /></td></tr>
</table>
</asp:Content>

