<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageone.master" AutoEventWireup="true" CodeFile="EmptyData.aspx.cs" Inherits="EmptyData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<table border="0" style="width:100%;height:100%">
<tr style="background-color:#4e4141";><td style="height: 10px">&nbsp;&nbsp;<img alt="" src="images/more3.jpg" />&nbsp;&nbsp;&nbsp;请选则要清空的数据表(教师表)</td></tr>
<tr><td style="height: 20px">&nbsp;&nbsp;&nbsp;“本校教师数据量”&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" 
        runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="清空本校教师数据" 
        onclick="Button1_Click" />
    </td></tr>
    <tr><td style="height: 20px">&nbsp;&nbsp;&nbsp;“外聘教师数据量”&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox2" 
        runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="清空外聘教师数据量" 
            onclick="Button2_Click" />
    </td></tr>
    <tr style="background-color:#4e4141";><td style="height: 10px">&nbsp;&nbsp;<img alt="" src="images/more3.jpg" />&nbsp;&nbsp;&nbsp;请选则要清空的数据表(教师表)</td></tr>
    <tr><td style="height: 20px">&nbsp;&nbsp;&nbsp;“教务处的数据量”&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox3" 
        runat="server"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" Text="清空教务处数据量" 
            onclick="Button3_Click" />
    </td></tr>
    <tr><td style="height: 20px">&nbsp;&nbsp;&nbsp;“会计系的数据量”&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox4" 
        runat="server"></asp:TextBox>
        <asp:Button ID="Button4" runat="server" Text="清空会计系数据量" />
    </td></tr>
    <tr><td style="height: 20px">&nbsp;&nbsp;&nbsp;“信息工程系的数据量”&nbsp;<asp:TextBox ID="TextBox5" 
        runat="server"></asp:TextBox>
        <asp:Button ID="Button5" runat="server" Text="清空信息工程系数据量" />
    </td></tr>
        <tr><td style="height: 20px">&nbsp;&nbsp;&nbsp;“商务外语系的数据量”&nbsp;<asp:TextBox ID="TextBox6" 
        runat="server"></asp:TextBox>
        <asp:Button ID="Button6" runat="server" Text="清空商务外语系数据量" />
     </td></tr>
        <tr><td style="height: 20px">&nbsp;&nbsp;&nbsp;“机械工程系的数据量”&nbsp;<asp:TextBox ID="TextBox7" 
        runat="server"></asp:TextBox>
        <asp:Button ID="Button7" runat="server" Text="清空机械工程系数据量" />
     </td></tr>
        <tr><td style="height: 20px">&nbsp;&nbsp;&nbsp;“食品工程系的数据量”&nbsp;<asp:TextBox ID="TextBox8" 
        runat="server"></asp:TextBox>
        <asp:Button ID="Button8" runat="server" Text="清空食品工程系数据量" />
     </td></tr>
        <tr><td style="height: 20px">&nbsp;&nbsp;&nbsp;“经济管理系的数据量”&nbsp;<asp:TextBox ID="TextBox9" 
        runat="server"></asp:TextBox>
        <asp:Button ID="Button9" runat="server" Text="清空经济管理系数据量" />
     </td></tr>
        <tr><td style="height: 20px">&nbsp;&nbsp;&nbsp;“建筑工程系的数据量”&nbsp;<asp:TextBox ID="TextBox10" 
        runat="server"></asp:TextBox>
        <asp:Button ID="Button10" runat="server" Text="清空建筑工程系数据量" />
    </td></tr>
    <tr><td style="height: 20px">&nbsp;&nbsp;&nbsp;“基础教学部的数据量”&nbsp;<asp:TextBox ID="TextBox11" 
        runat="server"></asp:TextBox>
        <asp:Button ID="Button11" runat="server" Text="清空基础教学部数据量" />
    </td></tr>
</table>
</asp:Content>

