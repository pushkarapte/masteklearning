using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Session 1"] = "Session 1 Data";
            Session["Session 2"] = "Session 2 Data";
            Response.Write("Retrieve session key using integral indexer");
            Response.Write("<br/>");
            Response.Write("Session 1 Data -> " + Session[0].ToString());
            Response.Write("<br/>");
            Response.Write("Retrieve session key using session indexer");
            Response.Write("<br/>");
            Response.Write("Session 2 Data -> " + Session["Session 2"].ToString());
        }

    }
}