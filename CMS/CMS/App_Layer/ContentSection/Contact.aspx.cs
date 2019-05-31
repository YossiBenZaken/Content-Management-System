using System;
using System.Configuration;
using System.Data.SqlClient;

namespace CMS.App_Layer.ContentSection
{
    public partial class Contact : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MyConString"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select PageText from MasterInfo where Page='Contact'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            ContactText.DataSource = dr;
            ContactText.DataBind();
            dr.Close();
            con.Close();
        }
    }
}