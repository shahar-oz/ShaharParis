using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShaharParis
{
    public partial class admin : System.Web.UI.Page
    {
        public string usersTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["shahar"] == null)
            {
                Response.Redirect("login.aspx");

            }

            string sqlAll = "SELECT * FROM Users";

            if (Request["search"] != null)
            {
                if (Request["user2Search"]!= "")
                {
                    sqlAll = sqlAll + " WHERE " + Request["param"]+"='" + Request["user2Search"] + "'";
                }
                
            }

            DataTable dtUsers=MyAdoHelper.ExecuteDataTable("ShaharParisDB.accdb", sqlAll);
            if (dtUsers.Rows.Count == 0)
            {
                usersTable = "<p> no users </p>";
            }
            else
            {
                usersTable += "<table cellspacing=8 style=\"border: 2px solid;border-collapse: collapse; \">";
                usersTable += "<tr>";
                usersTable += "<th style=\"border: 2px solid;border-collapse: collapse; \"> שם משתמש </th>";
                usersTable += "<th style=\"border: 2px solid;border-collapse: collapse; \"> תאריך לידה </th>";
                usersTable += "<th style=\"border: 2px solid;border-collapse: collapse; \"> ביקור בפריז </th>";
                usersTable += "<th style=\"border: 2px solid;border-collapse: collapse; \"> מגדר </th>";
                usersTable += "<th style=\"border: 2px solid;border-collapse: collapse; \"> טלפון </th>";
                usersTable += "<th style=\"border: 2px solid;border-collapse: collapse; \"> עלייך </th>";
                usersTable += "</tr>";

                for(int i=0; i < dtUsers.Rows.Count; i++)
                {
                    usersTable += "<tr>";
                    usersTable += "<td style=\"border: 2px solid;border-collapse: collapse; \">" + dtUsers.Rows[i]["Username"] + "</td>";
                    string Birthdate = ((DateTime)dtUsers.Rows[i]["Birthdate"]).ToShortDateString();
                    usersTable += "<td style=\"border: 2px solid;border-collapse: collapse; \">" + Birthdate + "</td>";
                    string Visit = dtUsers.Rows[i]["Visitedparis"].ToString();
                    if (Visit == "True") Visit = "כן";
                    if (Visit == "False") Visit = "לא";
                    usersTable += "<td style=\"border: 2px solid;border-collapse: collapse; \">" + Visit + "</td>";
                    string Gender = dtUsers.Rows[i]["Gender"].ToString();
                    if (Gender == "male") Gender = "זכר";
                    if (Gender == "female") Gender = "נקבה";
                    usersTable += "<td style=\"border: 2px solid;border-collapse: collapse; \">" + Gender + "</td>";
                    
                    usersTable += "<td style=\"border: 2px solid;border-collapse: collapse; \">" + dtUsers.Rows[i]["Phone"] + "</td>";
                    usersTable += "<td style=\"border: 2px solid;border-collapse: collapse; \">" + dtUsers.Rows[i]["Aboutyou"] + "</td>";
                    usersTable += "</tr>";
                }

                usersTable += "</table>";
            }

            if (Request["btnDelete"] != null)
            {
                string username = Request["user2delete"].ToString();
                string sqlDelete = "DELETE FROM Users WHERE Username='" + username + "'";
                MyAdoHelper.DoQuery("ShaharParisDB.accdb",sqlDelete);
                Response.Redirect("admin.aspx");
            }
        }
    }
}