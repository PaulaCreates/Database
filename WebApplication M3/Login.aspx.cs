using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_M3
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Advising_System; Integrated Security = True; Pooling=False");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Bt_login_Click(object sender, EventArgs e)
        {
            Int16 studentId = Int16.Parse(id.Text);
            string studentPassword = password.Text;

            SqlCommand studentLogin = new SqlCommand("SELECT dbo.FN_StudentLogin(@Student_id, @password)", conn);

            studentLogin.Parameters.Add(new SqlParameter("@Student_id", studentId));
            studentLogin.Parameters.Add(new SqlParameter("@password", studentPassword));

            conn.Open();
            bool success =  (bool)studentLogin.ExecuteScalar();
            conn.Close();

            if (success)
            {
                Response.Write("Hello there");
            }
            else
                Response.Write("Wrong credentials added!");
        }
    }
}