 <%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ShaharParis.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <form method="post">
    <p style="background-color: rgba(240,248,255,0.7); font-size: 30px;">
    
        שם משתמש: <input type="text" name="username" /><br />
         סיסמה: <input type="password" name="pass" /><br />
        <input type="submit" name="go" value="התחבר" /><br />
       <span style="font-size: 25px;">עוד אין לך חשבון? </span> <br />
       <a style="color:#6e1313;background-color:none; font-size: 20px;"href="regi.aspx">ליצירת חשבון חדש |</a>
         <a style="color:#6e1313;background-color:none; font-size: 20px;"href="logout.aspx">התנתקות</a>
   </p>
        </form>
    <p style="background-color: rgba(240,248,255,0.7); font-size: 30px;">
     <% =errormsg %>
        </p>
    <br />


        
</asp:Content>
