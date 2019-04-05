using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Stock_Management_System.Classes;

namespace Stock_Management_System.UI
{
    public partial class CategoryUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void categorySaveButton_Click(object sender, EventArgs e)
        {
            Category aCategory = new Category();
            aCategory.categoryName = categoryNameTextBox.Text;

            Manager aManager = new Manager();
            string msg = aManager.SaveCategory(aCategory);
            Label2.Text = msg;
            categoryGridView.DataSource = aManager.GetCategories();
            categoryGridView.DataBind();


        }
    }
}