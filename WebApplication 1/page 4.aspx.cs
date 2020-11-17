using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_1
{
    public partial class page_4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString.Get("name");
           Response.Write("Hello " + name+ " by QueryString <br>");
            String Name = (String) Session["Name"];
             Response.Write(Name+" by session");
        }
    }
}