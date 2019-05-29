using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CMS.BL_Layer;

namespace CMS.DB_Layer
{
    public class MSSBUtil
    {
        SqlConnection con = new SqlConnection();
        public DataTable Table = new DataTable();
        public MSSBUtil()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MyConString"].ConnectionString;
        }
        /// <summary>
        /// Select From SQL Server
        /// </summary>
        /// <param name="command">select Query</param>
        /// <returns></returns>
        public DataTable retrieveDate(string command)
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(command, con);
                da.Fill(Table);
                return Table;
            }
            catch(Exception ex)
            {
                Metasys.MessageBox("Error in connection to DB : " + ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        /// <summary>
        /// SQL Server Command
        /// </summary>
        /// <param name="command">Insert,Delete,Update</param>
        /// <param name="ShowMessage">true or false</param>
        public void commandExec(string command,bool ShowMessage)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(command, con);
                int returnNo = cmd.ExecuteNonQuery();
                if(ShowMessage)
                {
                    if(returnNo>0)
                    {
                        Metasys.MessageBox("Operation has done");
                    }
                    else
                    {
                        Metasys.MessageBox("Some Error has happend in DB - please try again");
                    }
                }
            }
            catch (Exception ex)
            {
                Metasys.MessageBox("Error in connection to DB : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}