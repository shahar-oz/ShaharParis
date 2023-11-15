using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ShaharParis
{
    public partial class profile : System.Web.UI.Page
    {
        public string errorMsg, Birthdate, Visitedparis, Gender, Phone, Aboutyou, Username;
        protected void Page_Load(object sender, EventArgs e)
        {
            //הגנה
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            //שליפת פרטי המשתמש
            Username=Session["user"].ToString();
            string sqlDetails = "SELECT * FROM Users WHERE Username='" + Username + "'";
            DataTable dt = MyAdoHelper.ExecuteDataTable("ShaharParisDB.accdb", sqlDetails);
            Birthdate = ((DateTime)dt.Rows[0]["Birthdate"]).ToShortDateString();
            Visitedparis = dt.Rows[0]["Visitedparis"].ToString();
            if (Visitedparis == "True") Visitedparis = "כן";
            if (Visitedparis == "False") Visitedparis = "לא";
            Gender = dt.Rows[0]["Gender"].ToString();
            if (Gender == "male") Gender = "זכר";
            if (Gender == "female") Gender = "נקבה";
            Phone = dt.Rows[0]["Phone"].ToString();
            Aboutyou = dt.Rows[0]["Aboutyou"].ToString();


            //עדכון סיסמא
            if (Request["updatePass"] != null)
            {
                string pass = Request["pass"].ToString();
                string newpass = Request["newpass"].ToString();
                string newpass2 = Request["newpass2"].ToString();

                //string username = Session["user"].ToString();

                //בדיקה שהסיסמאות החדשות זהות
                if (newpass != newpass2)
                {
                    errorMsg = "הסיסמאות החדשות לא זהות";
                }
                else
                {
                    //בדיקה שסיסמא  נוכחית נכונה
                    string sql="SELECT * FROM Users WHERE Username='"+Username+"' AND Pass='"+pass+"'";
                    if (MyAdoHelper.IsExist("ShaharParisDB.accdb", sql))
                    {
                        //בדיקה שסיסמא נוכחית וסיסמה חדשה שונות


                        if (pass != newpass)
                        {
                            //עדכון הסיסמה
                            string sqlupdate = "UPDATE Users SET Pass='" + newpass + "'WHERE Username='" + Username + "'";
                            MyAdoHelper.DoQuery("ShaharParisDB.accdb", sqlupdate);
                            errorMsg = "סיסמה עודכנה בהצלחה";
                        }
                        else
                        {
                            errorMsg = "הסיסמה החדשה צריכה להיות שונה מהסיסמה הנוכחית";
                        }


                      

                    }
                    else
                    {
                        errorMsg = "סיסמא נוכחית אינה נכונה";
                    }
                }
            }
        }
    }
}