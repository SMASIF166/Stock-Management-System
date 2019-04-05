using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using StudnetEntryForm.Gatway;

namespace Stock_Management_System.Classes
{
    public class Gateway
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader reader;
       // private string connectionString = WebConfigurationManager.ConnectionStrings["StockConString"].ConnectionString;
        Connection oConnection=new Connection();

        public int SaveCategory(Category aCategory)
        {
            int row = 0;
            string query = "INSERT INTO t_Category(category_name) VALUES('"+aCategory.categoryName+"')";

            
            cmd =new SqlCommand(query,oConnection.GetConnection());
            row = cmd.ExecuteNonQuery();
           oConnection.GetClose();
            return row;
        }

        public bool IsCategoryExist(string categoryName)
        {
            string query = "SELECT * FROM t_Category WHERE category_name='"+categoryName+"'";
            cmd=new SqlCommand(query,oConnection.GetConnection());
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                oConnection.GetConnection();
                return true;
            }
            return false;
        }

        public List<Category> GetCategories()
        {
            string query = "SELECT * FROM t_Category";
            cmd =new SqlCommand(query,oConnection.GetConnection());
            reader = cmd.ExecuteReader();
            List<Category> categoryList=new List<Category>();
            while (reader.Read())
            {
                Category aCategory=new Category();
                aCategory.categoryId = (int) reader["category_id"];
                aCategory.categoryName = reader["category_name"].ToString();
                categoryList.Add(aCategory);
            }
            return categoryList;
        }

     //company

        public int SaveComapny(Company aCompany)
        {
            int row = 0;
            string query = "INSERT INTO t_Company(company_name) VALUES('" + aCompany.companyName + "')";


            cmd = new SqlCommand(query, oConnection.GetConnection());
            row = cmd.ExecuteNonQuery();
            oConnection.GetClose();
            return row;
        }

        public bool IsCompanyExist(string companyName)
        {
            string query = "SELECT * FROM t_Company WHERE company_name='" + companyName + "'";
            cmd = new SqlCommand(query, oConnection.GetConnection());
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                oConnection.GetConnection();
                return true;
            }
            return false;
        }

        public List<Company> GetCompanys()
        {
            string query = "SELECT * FROM t_Company";
            cmd = new SqlCommand(query, oConnection.GetConnection());
            reader = cmd.ExecuteReader();
            List<Company> companeList=new List<Company>();
        
            while (reader.Read())
            {
                Company aCompany=new Company();
                aCompany.companyId = (int) reader["company_id"];
                aCompany.companyName = reader["company_name"].ToString();
                companeList.Add(aCompany);
                
            }
            return companeList;
        }
    }
}