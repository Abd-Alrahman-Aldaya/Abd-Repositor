﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_1
{
    public partial class page_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page_load " + "<br>");     
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
                TextBox2.Text = TextBox1.Text;
                TextBox1.Text = "";
            Response.Write("button cach event by viewstat");      
        }
    }
}