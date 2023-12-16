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
    public partial class ViewRequiredCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int studentid = int.Parse(id.Text);
            string semCode = currentSemCode.Text;

            string connString =
                WebConfigurationManager.ConnectionStrings["DB"].ToString();
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "dbo.Procedures_ViewRequiredCourses",
                Connection = conn
            };

            cmd.Parameters.Add(new SqlParameter("@StudentID", studentid));
            cmd.Parameters.Add(new SqlParameter("@current_semester_code", semCode));

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