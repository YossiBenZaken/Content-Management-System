﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMS.App_Layer.ContentSection
{
    public partial class Hobbies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MyConString"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select PageText from MasterInfo where Page='Hobbies'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            HobbiesText.DataSource = dr;
            HobbiesText.DataBind();
            dr.Close();
            con.Close();
        }
    }
}