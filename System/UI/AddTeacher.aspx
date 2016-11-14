<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageone.master" AutoEventWireup="true" CodeFile="AddTeacher.aspx.cs" Inherits="AddTeacher" %>
  
<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
 <link href="./css/AddTeacher.css" rel="stylesheet" type="text/css">
<div id="container">
           <div class="D1">教师类型:<asp:DropDownList ID="TeacherType" runat="server" 
                   Width="157px" Height="22px">
              <asp:ListItem>本校教师</asp:ListItem>
              <asp:ListItem>外聘教师</asp:ListItem>
              </asp:DropDownList>
         </div>
          <div class="D1">  所属部门:
          <asp:DropDownList ID="TeacherDepartment" runat="server" Height="23px" 
          Width="148px">  </asp:DropDownList>
          </div>
          
          <div class="D1">  教师工号:<asp:TextBox ID="UserId" runat="server" Width="200px"></asp:TextBox></div>  
             
            <div class="D1"> 教师姓名:<asp:TextBox  ID="UserName" runat="server" Width="76px"></asp:TextBox> 
             &nbsp;性别:<asp:RadioButtonList ID="RadioButtonList1" runat="server"  RepeatDirection="Horizontal" RepeatLayout="Flow" TextAlign="Left" 
          ViewStateMode="Disabled" Width="90px">
          <asp:ListItem Selected="True"> 男</asp:ListItem>
          <asp:ListItem>女</asp:ListItem>

      </asp:RadioButtonList>
      </div>


      <div  class="D1"> 密&nbsp;&nbsp;码:<asp:TextBox ID="UserPWD" runat="server" 
              Width="200px" TextMode="Password"></asp:TextBox>
        </div>
             
              
          <div class="D1">   确认密码:<asp:TextBox ID="TextBox4" runat="server"  Width="200px" 
                  ontextchanged="TextBox4_TextChanged" TextMode="Password"  ></asp:TextBox>
           </div> 
           
           <div style="height: 25px" class="D1"> 
              权&nbsp;&nbsp;限：<asp:DropDownList ID="TeacherRole" runat="server" 
                  
              Width="122px" Height="40px">
              </asp:DropDownList>
              
           </div>  
      <div   id="special">
          <asp:Button ID="btn_OK" runat="server" Text="确定" Width="110px" onclick="btn_OK_Click" 
               />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="btn_Cancle"
              runat="server" Text="取消" Width="110px" onclick="btn_Cancle_Click1"   />
          <br />
          <br />
           </div>
    <asp:Label ID="lblMessage" runat="server" BorderColor="#0066FF" 
               Font-Size="XX-Large" Width="177px" Font-Bold="True" ForeColor="#FF3300"></asp:Label>

    </div>
</asp:Content>

