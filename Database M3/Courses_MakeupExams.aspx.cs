using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database_M3
{
    public partial class Courses_MakeupExams : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connString =
                WebConfigurationManager.ConnectionStrings["DB"].ToString();
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand(
           "SELECT * FROM dbo.Courses_MakeupExams"
           , conn);

            SqlDataReader dr;

            using (cmd)
            {
                conn.Open();
                using (conn)
                {
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
            }
        }
    }
}