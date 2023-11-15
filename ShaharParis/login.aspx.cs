using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShaharParis
{
    public partial class login : System.Web.UI.Page
    {
        public string errormsg;
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Request["username"];
            string pass = Request["pass"];
            if (Request.Form["go"] != null)
            {
               
                if (user == "shahar" && pass == "123")
                {
                    Session["shahar"] = "admin";
                    Response.Redirect("admin.aspx");
                }
                else
                {
                    errormsg = "שם משתמש או סיסמה שגויים";
                }
                string sql = "SELECT * FROM Users WHERE Username='" + user + "'AND Pass='" + pass + "'";
                if (MyAdoHelper.IsExist("ShaharParisDB.accdb", sql))
                {
                    Session["user"] = user;
                    Response.Redirect("profile.aspx");
                }
                else
                {
                    errormsg = "ההתחברות נכשלה";
                }
            }
            
        }
    }
}