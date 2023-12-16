using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database_M3
{
    public partial class StudentRegisterFirstMakeup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Sid = int.Parse(student_id.Text);
            int Cid = int.Parse(course_id.Text);
            string SCS = student_cur_sem.Text;


            string connString =
                WebConfigurationManager.ConnectionStrings["DB"].ToString();
            SqlConnection conn = new SqlConnection(connString);

            using (conn)
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "dbo.Procedures_StudentRegisterFirstMakeup",
                    Connection = conn
                };

                cmd.Parameters.Add(new SqlParameter("@StudentID", Sid));
                cmd.Parameters.Add(new SqlParameter("@courseID", Cid));
                cmd.Parameters.Add(new SqlParameter("@studentCurr_sem", SCS));


                cmd.ExecuteReader(); // gives error when inserting ID 9 (only ff in table of SICT) due to him being already registerd for a 2nd makeup exam (thus duplicate PKs)

            }
        }
    }
}