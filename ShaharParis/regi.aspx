<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="regi.aspx.cs" Inherits="ShaharParis.regi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <script type="text/javascript">
        function CheckForm()
        {
            if (document.regForm.username2.value == "")
            {
                alert('יש להזין שם');
                return false;
            }
            if (document.regForm.pass2.value == "")
            {
                alert('יש להזין סיסמה');
                return false;
            }
            if (document.regForm.pass2.value.length < 6)
            {
                alert('יש להזין סיסמה בת 6 תווים לפחות');
                return false;
            }
            if (!document.regForm.birth.value) {
                alert('יש להזין תאריך לידה'); 
                return false;
            }
            if (document.regForm.been.value == "")
            {
                alert('יש לסמן אם היית בפריז');
                return false;
            }
            if (document.regForm.gender.selectedIndex == "")
            {
                alert('בחר מגדר');
                return false;
            }           


            if (document.regForm.telephone.value.match(/^[0-9]{10}$/) == null)
            {
                alert('לא מס טלפון');
                return false;

            }
        }
        

    </script>

    <form name="regForm" method="post" onsubmit="return CheckForm();">
        <p style="background-color: rgba(240,248,255,0.7); font-size: 20px;">
            שם משתמש: <input type="text" name="username2" /><br />
         סיסמה: <input type="password" name="pass2" /><br />
            תאריך לידה: <input type="date" name="birth" /><br />
            האם ביקרת בפריז?
            כן<input type="radio" name="been" style="font-size:10px;" value="true">
            לא<input type="radio" name="been" style="font-size:10px;" value="false"><br />
           מגדר: <select name="gender">
                <option value="1">בחר</option>
                <option value="male">זכר</option>
                <option value="female">נקבה</option>
            </select><br />
             מספר טלפון: <input type="tel" name="telephone" /><br />
            קצת עליך: <textarea name="aboutyou"></textarea>
            <br /> <input type="submit" name="regi" value="הירשם" />
            <%=error %>
        </p>
    </form>
    
</asp:Content>
