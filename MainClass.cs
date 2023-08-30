using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS
{
    internal class MainClass
    {
        public static readonly string con_string = "Server=교수용PC\\SQLEXPRESS; Database=RMS; User ID=RMS; Password=123;";
        public static SqlConnection con = new SqlConnection(con_string);


        //Methord th check user validation 

        public static bool IsVaildUser(string user, string pass) {
        
            bool isValid = false;
            
            string qry = @"Select * from users where username = '" + user + "' and uPass ='" + pass + "' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0) { 
                isValid = true;
            }

            return isValid;
        }
    }
}
