using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SL_WebForms_ph3
{
    public partial class SchoolMgmt : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Class.aspx");
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Student.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Subject.aspx");
        }
    }
}