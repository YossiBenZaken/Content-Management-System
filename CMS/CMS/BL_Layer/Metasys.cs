using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.BL_Layer
{
    public class Metasys
    {
        public static void MessageBox(string Message)
        {
            HttpContext.Current.Response.Write("<script>alert('" + Message + "')</script>");
        }
    }
}