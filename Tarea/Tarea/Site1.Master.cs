using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void link_uno_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm1.aspx");
        }

        protected void link_dos_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm2.aspx");

        }

        protected void link_tres_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm4.aspx");
        }

        protected void link_cuatro_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm3.aspx");
        }

        protected void link_cinco_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm5.aspx");

        }
    }
}