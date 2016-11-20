<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 <style type="text/css">
      
      *{overflow:hidden; font-size:9pt;
       padding:0px;}
      .d
      {
          width:95px;
          height:34px;
          background-image:url(images/login.gif);
          text-align:center;
       }
      
      body{
            margin-left: 0px;
	        margin-top: 0px;
	        margin-right: 0px;
	        margin-bottom: 0px;
	        background-image:url("images/bg.gif");
	        background-repeat:repeat-x;
	      
	        }
	   .s
      {
          width:135px;
          height:21px;
          background-image:url(images/inputbg.gif)
          background-repeat:repeat-x;
          border:solid 1px #d1d1d1;
            
         
          }
</style>
</head>
<body>
    <form id="form1" runat="server">
   

<table width="100%"  height="100%" border="0" cellspacing="0" cellpadding="0" style="margin-top:92px">
  <tr>
    <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td height="561" style="background:url(images/lbg.gif)"><table width="940" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td height="238" style="background:url(images/login06.gif)">&nbsp;</td>
          </tr>
          <tr>
            <td height="190"><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="208" height="190" style="background:url(images/login02.jpg)">&nbsp;</td>
                <td width="518" height="190"style="background:url(images/login03.jpg) "><table width="320" border="0" align="center" cellpadding="0" cellspacing="0">
                  <tr>
                    <td width="40" height="40"><img src="images/user.gif" width="30" height="30"></td>
                    <td width="40" height="40">用户</td>
                    <td width="235" height="40"><asp:TextBox ID="TextBox1" runat="server" CssClass="s"></asp:TextBox>
                        </td>
                  </tr>
                  <tr>
                    <td height="40"><img src="images/password.gif" width="28" height="32"></td>
                    <td height="40">密码</td>
                    <td height="40">
                     <asp:TextBox ID="TextBox2" runat="server" CssClass="s"></asp:TextBox>
                        </td>
                        </tr>
                    <tr>
                    <td height="40">&nbsp;</td>
                    <td height="40">验证码</td>
                    <td height="40" ><asp:TextBox ID="TextBox3" runat="server" CssClass="s"></asp:TextBox> <img src="Core.aspx" alt="验证字符" style="width:65;height:21; vertical-align:top;">
                       </td>
                    </tr>
                  <tr>
                    <td height="40">&nbsp;</td>
                    <td height="40">&nbsp;</td>
                    <td height="40">
                        <asp:Button
                            ID="Button1" runat="server" onclick="Button1_Click" CssClass="d"/> 
                        <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="#FF3300"></asp:Label></td>
                  </tr>
                </table></td>
                <td width="212" style="background:url(images/login04.jpg)" >&nbsp;</td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td height="133" style="background:url(images/login05.jpg)">
               
               
              </td>
          </tr>
        </table></td>
      </tr>
    </table></td>
  </tr>
</table>

   
    </form>
</body>
</html>
