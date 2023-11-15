using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShaharParis
{
    public partial class regi : System.Web.UI.Page
    {
        public string error;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["regi"] != null)
            {
                string username = Request["username2"].ToString();
                string sql = "SELECT * FROM Users WHERE Username='" + username + "'";
                if (MyAdoHelper.IsExist("ShaharParisDB.accdb", sql))
                {
                    error = "שם משתמש כבר קיים";

                }
                else 
                {
                    string pswd= Request["pass2"].ToString();
                    string bday = Request["birth"].ToString();
                    string havebeen = Request["been"].ToString();
                    string gender = Request["gender"].ToString();
                    string tele = Request["telephone"].ToString();
                    string about = Request["aboutyou"].ToString();

                    string sql2 = "INSERT INTO Users VALUES('"+username+"','"+pswd+"',#"+bday+"#,"+havebeen+",'"+gender+"','"+tele+"','"+about+"')";
                    MyAdoHelper.DoQuery("ShaharParisDB.accdb", sql2);
                    Session["user"] = username;
                    Response.Redirect("profile.aspx");
                }
            }
        }
           
    }
}