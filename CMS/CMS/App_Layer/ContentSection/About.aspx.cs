using System;
using System.Configuration;
using System.Data.SqlClient;

namespace CMS.App_Layer.ContentSection
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MyConString"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select PageText from MasterInfo where Page='About'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            AboutText.DataSource = dr;
            AboutText.DataBind();
            dr.Close();
            con.Close();
        }
    }
}