using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database_M3
{
    public partial class StudentPhone : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Bt_Confirm(object sender, EventArgs e)
        {
            int student_id = int.Parse(id.Text);
            int student_phone = int.Parse(phone.Text);
            string connString =
                WebConfigurationManager.ConnectionStrings["DB"].ToString();
            SqlConnection conn = new SqlConnection(connString);

            using (conn)
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "dbo.Procedures_StudentaddMobile",
                    Connection = conn
                };

                cmd.Parameters.Add(new SqlParameter("@StudentID", student_id));
                cmd.Parameters.Add(new SqlParameter("@mobile_number", student_phone));

                cmd.ExecuteReader();

            }
        }
    }
}