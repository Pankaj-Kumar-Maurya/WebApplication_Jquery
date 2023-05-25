using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication_Jquery
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlConnection con = new SqlConnection("data source=PANKAJ;initial catalog=dark;integrated security=true");
        [WebMethod]
        public void Save(string A, string B, int C)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_StudentInsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("name", A);
            cmd.Parameters.AddWithValue("address", B);
            cmd.Parameters.AddWithValue("age", C);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
