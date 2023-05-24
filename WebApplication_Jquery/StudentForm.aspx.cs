using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication_Jquery
{
    public partial class StudentForm : System.Web.UI.Page
    {
        static SqlConnection con= new SqlConnection("data source=PANKAJ;initial catalog=dark;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static void Insert(string A,string B,string C)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_StudentInsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("name",A);
            cmd.Parameters.AddWithValue("address",B);
            cmd.Parameters.AddWithValue("age",C);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}