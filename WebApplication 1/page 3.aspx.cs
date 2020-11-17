using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_1
{
    public partial class page_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HiddenField1.Value = "input name: ";
            Label1.Text = Convert.ToString(HiddenField1.Value);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Name"] =TextBox1.Text;
            Response.Redirect("page 4.aspx?name=" + TextBox1.Text);
          
        }
    }
}