using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMS.App_Layer.ContentSection
{
    public partial class Shima : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MyConString"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select PageText from MasterInfo where Page='Shima'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            ShimaText.DataSource = dr;
            ShimaText.DataBind();
            dr.Close();
            con.Close();
        }
    }
}