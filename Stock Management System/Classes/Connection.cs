using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace StudnetEntryForm.Gatway
{
    public class Connection
    {
        private SqlConnection con;
        private string connectionString = WebConfigurationManager.ConnectionStrings["StockConString"].ConnectionString;


        public SqlConnection GetConnection()
        {
            con = new SqlConnection(connectionString);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            else
            {
                con.Open();
            }
            return con;
        }

        public void GetClose()
        {
            if (con != null)
            {
                con.Close();
            }
        }
    }
}