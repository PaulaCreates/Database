using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database_M3
{
    public partial class Component1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentPhone.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("OptionalCourses.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("SemesterAvailableCourses.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewRequiredCourses.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewMS.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentSendingCourseRequest.aspx");
        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentSendingCHRequest.aspx");
        }
    }
}