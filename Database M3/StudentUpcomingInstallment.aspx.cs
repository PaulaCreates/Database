using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database_M3
{
    public partial class StudentUpcomingInstallment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string connetionString = WebConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            SqlConnection conn = new SqlConnection(connetionString);

            int studentId = int.Parse(student_id.Text);

            SqlCommand cmd = new SqlCommand("SELECT dbo.FN_StudentUpcoming_installment(@balala)", conn);

            cmd.Parameters.Add(new SqlParameter("@balala", studentId));
            using (conn)
            {
                conn.Open();
                string installment = (string)cmd.ExecuteScalar(); //when date is null, an error will occur
                Label2.Text = installment;
            }


        }
    }
}