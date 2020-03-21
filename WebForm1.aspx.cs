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
            Company C = new Company();
            Response.Write("Name of the employee with id =1" + "  " + C[1]);
            Response.Write("<br/>");
            Response.Write("Name of the employee with id =2" + "  " +C[2]);
            Response.Write("<br/>");
            Response.Write("Name of the employee with id =3" + "  " +C[3]);
            Response.Write("<br/>");
            Response.Write("<br/>");
            Response.Write("Total number of male employees" + " " + C["Male"]);
            Response.Write("<br/>");
            Response.Write("Total number of female employees" + " " + C["Female"]); 
            
            
            
            
            
            
            //Session["Session 1"] = "Session 1 Data";
            //Session["Session 2"] = "Session 2 Data";
            //Response.Write("Retrieve session key using integral indexer");
            //Response.Write("<br/>");
            //Response.Write("Session 1 Data -> " + Session[0].ToString());
            //Response.Write("<br/>");
            //Response.Write("Retrieve session key using session indexer");
            //Response.Write("<br/>");
            //Response.Write("Session 2 Data -> " + Session["Session 2"].ToString());
        }

    }
}