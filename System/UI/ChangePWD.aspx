<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageone.master" AutoEventWireup="true" CodeFile="ChangePWD.aspx.cs" Inherits="ChangePWD" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<table cellspacing="0" cellpadding="0" style="margin:0 auto; border:1px solid white;width:600px;height:300px;margin:0 auto;margin-top:100px;">
            <tr>
                <td style="width:200px;text-align:center;">教师工号：</td>
                <td style="width:200px;text-align:center;">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td style="width:200px;text-align:center;">
                    <asp:Button ID="Button2" runat="server" Text="确定" onclick="Button2_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center;">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
           <tr style="text-align:center;">
                <td>
                    <asp:Label ID="Label2" runat="server" Text="新密码："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
           </tr>
           <tr style="text-align:center;">
                <td>
                    <asp:Label ID="Label3" runat="server" Text="再次输入新密码："></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
           </tr>
           <tr style="text-align:center;">
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="提交" />
                </td>
                
           </tr>
        </table>
</asp:Content>

