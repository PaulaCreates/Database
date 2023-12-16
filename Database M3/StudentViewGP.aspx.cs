using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace Database_M3
{
    public partial class StudentViewGP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int studentid = int.Parse(student_id.Text);

            string connString =
                WebConfigurationManager.ConnectionStrings["DB"].ToString();
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand(
           "SELECT * FROM dbo.FN_StudentViewGP(@StudentID)"
           , conn);

            cmd.Parameters.Add(new SqlParameter("@StudentID", studentid));

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