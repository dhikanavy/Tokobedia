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
    public partial class InsertProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[Constant.Keys.AUTH] != null)
            {
                User user = (User)Session[Constant.Keys.AUTH];
                if (user.RoleID != 1)
                {
                    Response.Redirect(Constant.Routes.HOME_ROUTE);
                }
                else
                {
                    viewProductTypeGrid.DataSource = ProductTypeHandler.getAllProductType();
                    viewProductTypeGrid.DataBind();
                }
            }
        }

        protected void insertProduct_Click(object sender, EventArgs e)
        {
            String Name = insNameTxt.Text, messageError = "";
            int Stock, Price, ProductTypeID;
            messageError = ProductController.insert(Name, insStockTxt.Text, insPriceTxt.Text, getProductTypeID.Text);

            if (messageError != "")
                insLabelError.Text = messageError;
            else
            {
                Stock = int.Parse(insStockTxt.Text);
                Price = int.Parse(insPriceTxt.Text);
                ProductTypeID = int.Parse(getProductTypeID.Text);
                ProductHandler.insertProduct(Name, Price, Stock, ProductTypeID);
                insLabelError.Text = "Your product has been registered";
            }
        }
    }
}