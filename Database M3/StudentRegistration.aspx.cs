using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Windows;

namespace Database_M3
{
    public partial class StudentRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Bt_register_Click(object sender, EventArgs e)
        {
            GetData();
        }
        protected void Bt_redirectButton_OnClick(object sender, EventArgs e)
        {
            Response.Write("Helllooooooooooooooooo");
            Response.Redirect("www.google.com");
        }
        private void GetData()
        {
            string connetionString =
            WebConfigurationManager.ConnectionStrings["DB"].ConnectionString;

            SqlConnection conn = new SqlConnection(connetionString);

            string first = first_name.Text;
            string last = last_name.Text;
            string pass = password.Text;
            string fac = faculty.Text;
            string mail = email.Text;
            string maj = major.Text;
            string sem = semester.Text;


            using (conn)
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "dbo.Procedures_StudentRegistration",
                    Connection = conn
                };

                cmd.Parameters.Add(new SqlParameter("@first_name", first));
                cmd.Parameters.Add(new SqlParameter("@last_name", last));
                cmd.Parameters.Add(new SqlParameter("@password", pass));
                cmd.Parameters.Add(new SqlParameter("@faculty", fac));
                cmd.Parameters.Add(new SqlParameter("@email", mail));
                cmd.Parameters.Add(new SqlParameter("@major", maj));
                cmd.Parameters.Add(new SqlParameter("@semester", sem));
                cmd.Parameters.Add("@Student_id", SqlDbType.Int);
                cmd.Parameters["@Student_id"].Direction = ParameterDirection.Output;

                cmd.ExecuteReader();
                string output = cmd.Parameters["@Student_id"].Value.ToString();
                student_id.Text = "This is your assigned student ID: " + output;
                Response.AddHeader("REFRESH", "5;URL=StudentPage.aspx");
            }
        }

    }
}