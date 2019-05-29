using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMS.BL_Layer;
using CMS.DB_Layer;

namespace CMS.App_Layer.AdminSection
{
    public partial class AdminChangeMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = "";
                if(FileUpload_HIMG.PostedFile.FileName.Trim() !="")
                {
                    fileName = System.IO.Path.GetFileName(FileUpload_HIMG.PostedFile.FileName);
                    string path = Server.MapPath("../ContentSection/Images") + "/" + fileName;
                    FileUpload_HIMG.PostedFile.SaveAs(path);
                    fileName = "images/" + fileName;
                }
                MSSBUtil loadData = new MSSBUtil();
                loadData.retrieveDate("Select * from MasterInfo");
                if (loadData.Table.Rows.Count > 0)
                {
                    MSSBUtil updateData = new MSSBUtil();
                    updateData.commandExec("Update MasterInfo set HeaderIMG=N'"+fileName+"', HeaderText=N'"+txt_HeaderText.Text.Trim()+"'", true);
                }
                else
                {
                    MSSBUtil saveData = new MSSBUtil();
                    saveData.commandExec("Insert into MasterInfo values(N'"+fileName+"',N'"+txt_HeaderText.Text.Trim()+"')", true);
                }
            }
            catch(Exception ex)
            {
                Metasys.MessageBox("Something goes wrong-Error is:" + ex.Message);
            }
        }
    }
}