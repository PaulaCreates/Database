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
    public partial class SemesterAvailableCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void confirm_Click(object sender, EventArgs e)
        {
            string semCode = CurSemCode.Text;

            string connString =
                WebConfigurationManager.ConnectionStrings["DB"].ToString();
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand
                ("Select * FROM dbo.FN_SemsterAvailableCourses(@semstercode)", conn);

            cmd.Parameters.Add(new SqlParameter("@semstercode", semCode));

            using (cmd)
            {
                conn.Open();
                using (conn)
                {
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }

            }
        }
    }
}