using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock_Management_System.Classes
{
    public class Manager
    {
        Gateway aGateway=new Gateway();

        public string SaveCategory(Category aCategory)
        {
            if (aGateway.IsCategoryExist(aCategory.categoryName))
            {
                return "Category Exist";
            }
            int rowCount = aGateway.SaveCategory(aCategory);
            if (rowCount > 0)
            {
                return "Category Saved";
            }
            return "Category Not Saved";
        }

        public List<Category> GetCategories()
        {
            return aGateway.GetCategories();
        }

        //Company

        public string SaveCompany(Company aCompany)
        {
            if (aGateway.IsCompanyExist(aCompany.companyName))
            {
                return "Comapany Exist";
            }
            int rowCount = aGateway.SaveComapny(aCompany);
            if (rowCount > 0)
            {
                return "Company Saved";
            }
            return "Company Not Saved";
        }

        public List<Company> GetCompanys()
        {
            return aGateway.GetCompanys();
        }
    }
}