using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectPsdLabBaru.Model;
using ProjectPsdLabBaru.Handler;
using ProjectPsdLabBaru.Controller;

namespace ProjectPsdLabBaru.View
{
    public partial class ProductTypeDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"]);
            ProductType p = ProductTypeHandler.get(id);
            oldNameType.Text = p.Name;
            oldDescriptionType.Text = p.Description;
        }

        protected void updateCurrentProductType_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"]);
            ProductType p = ProductTypeHandler.get(id);
            String Name = tbNameType.Text, Description = tbDescriptionType.Text, messageError = "";
            int ID = p.ID;
            messageError = ProductTypeController.update(Name, Description);
            
            if (messageError != "")
                lblErrorUpdateProductType.Text = messageError;
            else
            {
                ProductTypeHandler.updateProductType(ID, Name, Description);
                lblErrorUpdateProductType.Text = "Your product type has been updated";
            }
        }
    }
}