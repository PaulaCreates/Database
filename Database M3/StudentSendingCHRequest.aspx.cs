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
    public partial class StudentSendingCHRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Bt_request_Click(object sender, EventArgs e)
        {
            string connetionString =
            WebConfigurationManager.ConnectionStrings["DB"].ConnectionString;

            SqlConnection conn = new SqlConnection(connetionString);

            string studentid = student_id.Text;
            string credithours = credit_hours.Text;
            string requesttype = type.Text;
            string studentcomment = comment.Text;

            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "dbo.Procedures_StudentSendingCHRequest",
                    Connection = conn
                };

                cmd.Parameters.Add(new SqlParameter("@StudentID", studentid));
                cmd.Parameters.Add(new SqlParameter("@credit_hours", credithours));
                cmd.Parameters.Add(new SqlParameter("@type", requesttype));
                cmd.Parameters.Add(new SqlParameter("@comment", studentcomment));

                cmd.ExecuteReader();
            }
        }
    }
}
