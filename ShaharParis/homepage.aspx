<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="ShaharParis.homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <h2>ברוכים הבאים למדריך לפריז</h2>

    <p>
        היא נחשבת לאחת הערים היפות בעולם, אם לא היפה מכולן,
        העיר פריז הידועה גם כ"עיר האורות", בירתה של צרפת,
        שוכנת על גדותיו של נהר הסיין, שבחלקה הצפוני של צרפת, בלב מחוז איל דה פראנס.<br /> פריז היא גם העיר הכי גדולה במדינה, ואחת מהערים הגדולות באירופה.
      
      
        <br />
        בפריז יש מגוון רחב של מקומות בילוי, טיול, תרבות, וקניות.
        <br />
        לפריז היסטוריה עשירה ומגוונת. כבר מהמאה העשירית היא אחד ממוקדי ההשכלה, הדת והכוח הראשיים של אירופה.
        <br />

        בין אם תבחרו לטוס לפריז לקניות, למוזיאונים או לבילויים, האתר הזה הוא בשבילכם!

    </p>

    <script type="text/javascript">
        var Id = 1;
        function display(id) {
            displayImg(id);
            highlight(id);
            Id = id;
        }
        function displayImg(img) {
            // document.getElementById('selected').innerHTML="<img align='center' width='800' height='450' src='picss/img"+img+".jpg'>"
            document.theimage.src = "picss/img"+img+".jpg";
        }
        function highlight(id) {
            for (var i = 1; i <= 10; i++) {
                document.getElementById(i).style = "border:black 1px double; padding:10px; background-color:rgba(240,248,255,0.7);border-spacing:1px;vertical-align:top;font-size:25px;text-align:center;vertical-align:middle; opacity:100;";
            }
            document.getElementById(i).style = "border:black 1px double; padding:10px; background-color:rgba(240,248,255,0.7);border-spacing:1px;vertical-align:top;font-size:25px;text-align:center;vertical-align:middle; opacity:100%;";
        }
        function slideLeft() {
            if (Id <= 1) Id = 10;
            else Id -= 1;
            display(Id);
        }
        function slideRight() {
            if (Id >= 10) Id = 1;
            else Id += 1;
            display(Id);
        }
        display(Id);
    </script>
    <table>
        <tr>
            <td> <button onclick="slideLeft()"><big><</big></button></td>
            <td><div id="selected" ><img name="theimage" src="picss/img1.jpg" width=800 height=450></div></td>
                 <td><button onclick="slideRight()"><big>></big></button></td>

    </table>
            <td>    <div>
       
        <table >
            <tr>
                <td id="1"><img width="116" height="65" src="picss/img1.jpg" onclick="display(1)" ></td>
                <td id="2"><img width="116" height="65" src="picss/img2.jpg" onclick="display(2)" ></td>
                <td id="3"><img width="116" height="65" src="picss/img3.jpg" onclick="display(3)" ></td>
                <td id="4"><img width="116" height="65" src="picss/img4.jpg" onclick="display(4)" ></td>
                <td id="5"><img width="116" height="65" src="picss/img5.jpg" onclick="display(5)" ></td>
            </tr>
            <tr>
                <td id="6"><img width="116" height="65" src="picss/img6.jpg" onclick="display(6)" ></td>
                <td id="7"><img width="116" height="65" src="picss/img7.jpg" onclick="display(7)" ></td>
                <td id="8"><img width="116" height="65" src="picss/img8.jpg" onclick="display(8)" ></td>
                <td id="9"><img width="116" height="65" src="picss/img9.jpg" onclick="display(9)" ></td>
                <td id="10"><img width="116" height="65" src="picss/img10.jpg" onclick="display(10)" ></td>
            </tr>
        </table>
    </div></td>
        </tr>
   


</asp:Content>
