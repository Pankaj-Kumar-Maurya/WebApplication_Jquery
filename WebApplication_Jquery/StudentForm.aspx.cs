using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Services;

namespace WebApplication_Jquery
{
    public partial class StudentForm : System.Web.UI.Page
    {
        static SqlConnection con= new SqlConnection("data source=PANKAJ;initial catalog=dark;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //WARNING : --> This Page is Replaced by WebService1.asmx.cs page.(BackEnd Code)
        //        : --> And StudentForm.aspx is replaced by StudentFormHTML.(For FrontEnd UI)
        [WebMethod]
        public static void Save(string A,string B,int C)
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