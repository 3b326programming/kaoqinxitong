<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminDefault.aspx.cs" Inherits="adminDefault" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript">
// <![CDATA[

        function Button1_onclick() {

        }

// ]]>
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    <asp:Label ID="Label2" runat="server" Text="本系课程"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <p>
        <input id="Button1" type="button" value="button" onclick="return Button1_onclick()" /></p>
    <asp:Button ID="Button2" runat="server" Text="Button" />
    </form>
</body>
</html>
