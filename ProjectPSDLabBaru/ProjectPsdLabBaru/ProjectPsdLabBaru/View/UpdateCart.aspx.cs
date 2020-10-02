using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectPsdLabBaru.Model;
using ProjectPsdLabBaru.Controller;
using ProjectPsdLabBaru.Handler;

namespace ProjectPsdLabBaru.View
{
    public partial class UpdateCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[Constant.Keys.AUTH] != null)
            {
                User user = (User)Session[Constant.Keys.AUTH];
                if (user.RoleID == 2)
                {
                    int id = Int32.Parse(Request.QueryString["id"]);
                    Product p = ProductHandler.get(id);
                    updateCartNameTxt.Text = p.Name;
                    updateCartPriceTxt.Text = p.Price.ToString();
                    updateCartStockTxt.Text = p.Stock.ToString();
                    updateCartProductTypeTxt.Text = ProductTypeHandler.getProductType(p.ProductTypeID);
                }
                else
                {
                    var redirecTo = Constant.Routes.HOME_ROUTE;
                    Response.Redirect(redirecTo);
                }
            }
            else
            {
                var redirecTo = Constant.Routes.HOME_ROUTE;
                Response.Redirect(redirecTo);
            }
        }
        protected void updateCartButton_Click(object sender, EventArgs e)
        {
            User user = (User)Session[Constant.Keys.AUTH];
            int id = Int32.Parse(Request.QueryString["id"]), Quantity = 0;
            string messageError = "";

            messageError = CartController.update(updateCartQuantityTxt.Text, id, user.ID);

            if (messageError != "")
            {
                labelErrorUpdateCart.Text = messageError;
            }
            else
            {
                Quantity = int.Parse(updateCartQuantityTxt.Text);
                Product product = ProductHandler.get(id);
                if(Quantity==0)
                    CartHandler.remove(user.ID, id);
                else
                    CartHandler.updateNewQuantity(user.ID, id, Quantity);
                var redirecTo = Constant.Routes.VIEW_CART_ROUTE;
                Response.Redirect(redirecTo);
            }
        }
    }
}