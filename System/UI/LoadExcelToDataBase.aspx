<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageone.master" AutoEventWireup="true" CodeFile="LoadExcelToDataBase.aspx.cs" Inherits="LoadExcelToDataBase" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <script type="text/javascript">
        function Navigate() {
            document.getElementById("lblMessage2").Text = "查询中，请稍后QAQ";
            alert("wocao ");
            return false;
            

        }    
      
    </script>
    <style type="text/css">
       .btn
       {
           width:109px;
           height:27px;
           background-image:url(images/btn.jpg);
           }
       .lab
       {
           width:154px;
           height:27px;
           background-image:url(images/fenxi.jpg);
           
           
           }
    </style>
    <table border="0" style="width:100%;height:100%">

    <tr style="background-color:#3FF"><td><img alt="" src="images/more3.jpg" />导入教师基本信息</td></tr>
    <tr style="height:18px"><td style="padding-left:200px">
        <asp:RadioButton ID="RadioButton1" runat="server" Text="本校教师"/>
        <asp:RadioButton ID="RadioButton2" runat="server" Text="外聘教师" /></td></tr>
    <tr ><td>请选择要导入的文件<asp:FileUpload ID="FileUpload1" 
            runat="server" Width="600px" Font-Italic="False" Font-Overline="False" 
            Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
            Height="22px"/>&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Width="109px" 
            onclick="Button1_Click" CssClass="btn" Text="导入"/></td></tr>
    <tr><td><asp:Label ID="lblMessage1" runat="server" Font-Size="Small" Text="lblMessage1"></asp:Label></td></tr>

    <tr style="background-color:#3FF"><td><img alt="" src="images/more3.jpg" />分系部导入教师授课信息</td></tr>
    <tr><td style="padding-left:200px"><asp:DropDownList ID="DropDownList1" runat="server" 
            Font-Size="Medium" Width="120px">
         </asp:DropDownList></td></tr>
    <tr><td>请选择要导入的文件<asp:FileUpload ID="FileUpload2" 
            runat="server" Width="600px" Font-Italic="False" Font-Overline="False" 
            Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
            Height="22px"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="导入" Width="109px" OnClientClick="Navigate()"
            onclick="Button2_Click" CssClass="btn"/></td></tr>
    <tr><td><asp:Label ID="lblMessage2" runat="server" Font-Size="Small" 
            ></asp:Label>
        </td></tr>

    <tr><td style="background-color:#3FF"><img alt="" src="images/more3.jpg" />导入本学期校历</td></tr>
   <tr><td>请选择要导入的文件<asp:FileUpload ID="FileUpload3" 
            runat="server" Width="600px" Font-Italic="False" Font-Overline="False" 
            Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" 
           Height="22px"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="导入" Width="109px" 
           CssClass="btn" onclick="Button3_Click1"/></td></tr>
    <tr><td><asp:Label ID="lblMessage5" runat="server" Font-Size="Small" 
            Text="lblMessage5"></asp:Label></td></tr>
    <tr><td style="background-color:#3FF"><img alt="" src="images/more3.jpg" />录入各系部人数</td></tr>
    <tr><td>会计系
         <asp:TextBox ID="txtKJ" runat="server" Width="70px"></asp:TextBox>
         信息系 
         <asp:TextBox ID="txtXX" runat="server" Width="70px"></asp:TextBox>
         经管系 
         <asp:TextBox ID="txtJG" runat="server" Width="70px"></asp:TextBox>
         建筑系 
         <asp:TextBox ID="txtJZ" runat="server" Width="70px"></asp:TextBox>
         机电系 
         <asp:TextBox ID="txtJD" runat="server" Width="70px"></asp:TextBox>
         外语系 
         <asp:TextBox ID="txtYY" runat="server" Width="70px"></asp:TextBox>
         食品系 
         <asp:TextBox ID="txtSP" runat="server" Width="70px"></asp:TextBox></td></tr>
    <tr><td><asp:Label ID="lblMessage6" runat="server" Font-Size="Small" 
            Text="lblMessage6"></asp:Label></td></tr>
    <tr><td style="background-color:#3FF"><img alt="" src="images/more3.jpg" />数据预处理</td></tr>
    <tr><td><asp:Button ID="Button4" runat="server" Text="分析入库数据" CssClass="lab"/>
             <asp:Label ID="lblMessage3" runat="server" Text="lblMessage3"></asp:Label></td></tr>
    <tr><td><asp:Button ID="Button5" runat="server" Text="处理入库数据" CssClass="lab"/>
             <asp:Label ID="lblMessage7" runat="server" Text="lblMessage7"></asp:Label></td></tr>
    <tr><td><asp:Button ID="Button6" runat="server" Text="清空入库数据" CssClass="lab"/>
             <asp:Label ID="lblMessage8" runat="server" Text="lblMessage8"></asp:Label></td></tr>
    </table>
</asp:Content>
