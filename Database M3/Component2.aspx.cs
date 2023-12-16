using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database_M3
{
    public partial class Component2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentViewGP.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentUpcomingInstallment.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Courses_MakeupExams.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentRegisterFirstMakeup.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentRegisterSecondMakeup.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("CoursesSlotsInstructors.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentPart2G.aspx");
        }
        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentPart2H.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentPart2I.aspx");
        }
    }
}