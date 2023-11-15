using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
//////////
using System.Data.OleDb;// ACCESS

/// <summary>
/// Summary description for MyAdoHelper
/// פעולות עזר לשימוש במסד נתונים  מסוג 
/// ACCESS
///  App_Data המסד ממוקם בתקיה 
/// </summary>
public class MyAdoHelper
{
    
        public static OleDbConnection ConnectToDb(string fileName)
        {
            string path = HttpContext.Current.Server.MapPath("App_Data/" + fileName);//מיקום מסד בפורוייקט
        //string connString = @"Provider=Microsoft.Jet.OLEDB.4.0;data source=" + path;  //mdb  עבור סיומת
            string connString = @"provider=Microsoft.ACE.OLEDB.12.0; Data source=" + path;  // accdb עבור סיומת
            OleDbConnection conn = new OleDbConnection(connString);
            return conn;
        }

        public static void DoQuery(string fileName, string sql)
        //הפעולה מקבלת שם קובץ של מסד נתונים ומחרוזת מחיקה/ הוספה/ עדכון
        //ומבצעת את הפקודה על המסד הפיזי
        {
            OleDbConnection conn = ConnectToDb(fileName);
            conn.Open();
            OleDbCommand com = new OleDbCommand(sql, conn);
            com.ExecuteNonQuery();
            com.Dispose();
            conn.Close();

        }


        /// <summary>
        /// To Execute update / insert / delete queries
        ///  הפעולה מקבלת שם קובץ ומשפט לביצוע ומחזירה את מספר השורות שהושפעו מביצוע הפעולה
        /// </summary>
        public static int RowsAffected(string fileName, string sql)//הפעולה מקבלת מסלול מסד נתונים ופקודת עדכון
                                                                   //ומבצעת את הפקודה על המסד הפיזי
        {

            OleDbConnection conn = ConnectToDb(fileName);
            conn.Open();
            OleDbCommand com = new OleDbCommand(sql, conn);
            int rowsA = com.ExecuteNonQuery();
            conn.Close();
            return rowsA;
        }

        /// <summary>
        /// הפעולה מקבלת שם קובץ ומשפט לחיפוש ערך - מחזירה אמת אם הערך נמצא ושקר אחרת
        /// </summary>
        public static bool IsExist(string fileName, string sql)//הפעולה מקבלת שם קובץ ומשפט בחירת נתון ומחזירה אמת אם הנתונים קיימים ושקר אחרת
        {

            OleDbConnection conn = ConnectToDb(fileName);
            conn.Open();
            OleDbCommand com = new OleDbCommand(sql, conn);
            OleDbDataReader data = com.ExecuteReader();
            bool found;
            found = (bool)data.Read();// אם יש נתונים לקריאה יושם אמת אחרת שקר - הערך קיים במסד הנתונים
            conn.Close();
            return found;

        }


        public static DataTable ExecuteDataTable(string fileName, string sql)
        {
            OleDbConnection conn = ConnectToDb(fileName);
            conn.Open();
            OleDbDataAdapter tableAdapter = new OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            tableAdapter.Fill(dt);
            return dt;
        }


        public static void ExecuteNonQuery(string fileName, string sql)
        {
            OleDbConnection conn = ConnectToDb(fileName);
            conn.Open();
            OleDbCommand command = new OleDbCommand(sql, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public static string DataTableToString(string fileName, string sql)
        {


            DataTable dt = ExecuteDataTable(fileName, sql);

            string printStr = "<table border='1'>";

            foreach (DataRow row in dt.Rows)
            {
                printStr += "<tr>";
                foreach (object myItemArray in row.ItemArray)
                {
                    printStr += "<td>" + myItemArray.ToString() + "</td>";
                }
                printStr += "</tr>";
            }
            printStr += "</table>";

            return printStr;
        }


    }
