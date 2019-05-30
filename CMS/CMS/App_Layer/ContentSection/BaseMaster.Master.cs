using CMS.BL_Layer;
using CMS.DB_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMS.App_Layer.ContentSection
{
    public partial class BaseMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                MSSBUtil loadData = new MSSBUtil();
                loadData.retrieveDate("select * from MasterInfo");
            }
            catch(Exception ex)
            {
                Metasys.MessageBox("Some Error:" + ex.Message);
            }
        }
    }
}