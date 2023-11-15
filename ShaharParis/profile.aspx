<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="ShaharParis.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <p>
       שלום! <%=Username %> הגעת לדף הפרופיל שלך<br />
        <u>פרטים אישיים</u><br />
        תאריך לידה: <%=Birthdate %><br />
        האם ביקרת בפריז? <%=Visitedparis %><br />
        מגדר: <%=Gender %><br />
        מספר הטלפון: <%=Phone %><br />
        קצת עלייך: <%=Aboutyou %><br />

    </p>

    <p></p><h2> עדכון סיסמה</h2>
    <form method="post" style="background-color: rgba(240,248,255,0.7); font-size: 30px;">
        סיסמה נוכחית:<input type="password" name="pass" /><br/>
        סיסמה חדשה:<input type="password" name="newpass" /><br />
        אימות סיסמה:<input type="password" name="newpass2" /><br />
        <input type="submit" name="updatePass" value="עדכון סיסמה" /><br />

     
    </form>
    <div style="background-color: rgba(240,248,255,0.7); font-size: 25px;"><%=errorMsg%></div>
    
</asp:Content>
