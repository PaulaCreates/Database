using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database_M3
{
    public partial class StudentLoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Bt_login_Click(object sender, EventArgs e)
        {
            string connetionString = WebConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            SqlConnection conn = new SqlConnection(connetionString);
            int studentId = int.Parse(id.Text);
            string studentPassword = password.Text;

            SqlCommand studentLogin = new SqlCommand("SELECT dbo.FN_StudentLogin(@Student_id, @password)", conn);

            studentLogin.Parameters.Add(new SqlParameter("@Student_id", studentId));
            studentLogin.Parameters.Add(new SqlParameter("@password", studentPassword));

            conn.Open();
            bool success = (bool)studentLogin.ExecuteScalar();
            conn.Close();

            string stuId = studentLogin.Parameters["@Student_id"].Value.ToString();
            string pass = studentLogin.Parameters["@password"].Value.ToString();


            if (success)
            {
                Response.Redirect("StudentPage.aspx");
            }
            else
                Response.Write("Wrong credentials added or Financial payment not settled!");

        }
        protected void Bt_register_Click(object sender, EventArgs e)
        {
            string connetionString = WebConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            SqlConnection conn = new SqlConnection(connetionString);
            SqlCommand command = new SqlCommand("Select * from Student", conn);
            

        }
    }

}