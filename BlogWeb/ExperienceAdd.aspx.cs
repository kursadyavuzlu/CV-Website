﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class ExperienceAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_ExperienceTableAdapter dt_Exp = new DataSet1TableAdapters.Tbl_ExperienceTableAdapter();
            dt_Exp.AddExperience(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
            Response.Redirect("Experience.aspx");
        }
    }
}