<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="ShaharParis.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>ניהול האתר</h1>

    <table cellpadding="10" style="font-size: 30px;color:black;text-decoration:none;background-color: rgba(240,248,255,0.7); width:50%;">
        <td> 
              <form method="post">
         
    <h3 style="color:black">חיפוש משתמשים</h3>
                  <select name="param">
                      <option value="Username">שם משתמש</option>
                      <option value="Birthdate">תאריך לידה</option>
                      <option value="VisitedParis">ביקר בפריז</option>
                      <option value="Gender">מגדר</option>
                      <option value="Phone">טלפון</option>
                      <option value="Aboutyou">קצת עלייך</option>
                  </select>
        <input type="text" name="user2Search" />
        <input type="submit" name="search" value="חיפוש" />

    </form>

        </td>

        <td>
                <form method="post">
     
        <h3 style="color:black">מחיקת משתמשים</h3>
        <input type="text" name="user2delete" />
        <input type="submit" name="btnDelete" value="מחיקה"/>
            <br />

    </form>
        </td>
    </table>

    <h2>טבלת משתמשים</h2>
    
    <%=usersTable %>
    
    
    <br /><br />

</asp:Content>
