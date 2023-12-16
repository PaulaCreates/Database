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
    public partial class StudentPart2H : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int Sid = int.Parse(student_id.Text);
            int Cid = int.Parse(course_id.Text);
            string SCS = student_cur_sem.Text;
            int IID = int.Parse(instructor_id.Text);



            string connString =
                WebConfigurationManager.ConnectionStrings["DB"].ToString();
            SqlConnection conn = new SqlConnection(connString);

            using (conn)
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "dbo.Procedures_Chooseinstructor",
                    Connection = conn
                };

                cmd.Parameters.Add(new SqlParameter("@StudentID", Sid));
                cmd.Parameters.Add(new SqlParameter("@CourseID", Cid));
                cmd.Parameters.Add(new SqlParameter("@current_semester_code", SCS));
                cmd.Parameters.Add(new SqlParameter("@instrucorID", IID));

                cmd.ExecuteReader(); 
            }
        }
    }
}