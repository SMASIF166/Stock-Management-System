using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Stock_Management_System.Classes;

namespace Stock_Management_System.UI
{
    public partial class CompanyUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CompanySaveButton_Click(object sender, EventArgs e)
        {
            Company aCompany=new Company();
            aCompany.companyName = companyNameTextBox.Text;

            Manager aManager=new Manager();
            string msg = aManager.SaveCompany(aCompany);
            Label2.Text = msg;
            companyGridView.DataSource = aManager.GetCompanys();
            companyGridView.DataBind();
        }
    }
}