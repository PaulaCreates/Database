using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;

namespace Database_M3
{
    public partial class Part2G : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int courseid = int.Parse(course_id.Text);
            int instructorid = int.Parse(instructor_id.Text);

            string connString =
                WebConfigurationManager.ConnectionStrings["DB"].ToString();
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand(
           "select * from dbo.Courses_Slots_Instructor where " +
           "CourseID = @courseid AND instructor_id = @instructorid"
            , conn);

            cmd.Parameters.Add(new SqlParameter("@courseid", courseid));
            cmd.Parameters.Add(new SqlParameter("@instructorid", instructorid));

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