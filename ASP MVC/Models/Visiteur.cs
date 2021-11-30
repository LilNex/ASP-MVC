using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ASP_MVC.Models
{
    
    public class Visiteur
    {
        public static List<Visiteur> lst = new List<Visiteur>();
        public string nom { get; set; }
    }

    public class DB_Visiteur
    {
        public static string  openConnection()
        {
            SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder();
            conn["Server"] = "Lilnex\\SQLEXPRESS";
            string strConn = "Data Source=LilNex\\sqlexpress;Initial Catalog=lilnx;Integrated Security=True";
            SqlConnection sql = new SqlConnection(strConn);
            sql.Open();

            SqlCommand sqlcmd = new SqlCommand("SELECT * FROM personne", sql);
            SqlDataReader dataR = sqlcmd.ExecuteReader();
            string test = "{0} : {1} : {2} / ";
            string dbStr = "";
            while (dataR.Read())
            {
                dbStr += String.Format(test, dataR[0], dataR[1], dataR[2]); 
            }
            

            return dbStr;
        }
    }
}