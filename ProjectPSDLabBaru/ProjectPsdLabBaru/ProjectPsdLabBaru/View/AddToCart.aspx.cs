using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectPsdLabBaru.Model;
using ProjectPsdLabBaru.Handler;
using ProjectPsdLabBaru.Constant;
using ProjectPsdLabBaru.Controller;

namespace ProjectPsdLabBaru.View
{
    public partial class AddToCart : System.Web.UI.Page
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
                    addToCartNameTxt.Text = p.Name;
                    addToCartPriceTxt.Text = p.Price.ToString();
                    addToCartStockTxt.Text = p.Stock.ToString();
                    addToCartProductTypeTxt.Text = ProductTypeHandler.getProductType(p.ProductTypeID);
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
        protected void addToCartButton_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"]), Quantity = 0;
            string messageError = "";

            messageError = CartController.Add(addToCartQuantityTxt.Text, id);

            if (messageError != "")
            {
                labelErrorAddToCart.Text = messageError;
            }
            else
            {
                User user = (User)Session[Constant.Keys.AUTH];
                Quantity = int.Parse(addToCartQuantityTxt.Text);
                Product product = ProductHandler.get(id);
                if (CartHandler.get(user.ID, product.ID) != null)
                {
                    CartHandler.updateQuantity(user.ID, id, Quantity);
                }
                else
                {
                    CartInformation currentProduct = new CartInformation();
                    currentProduct.ID = product.ID;
                    currentProduct.Name = product.Name;
                    currentProduct.Price = product.Price;
                    currentProduct.Quantity = Quantity;
                    currentProduct.SubTotal = currentProduct.Quantity * currentProduct.Price;
                    CartHandler.add(user.ID, id, Quantity);
                }
                var redirecTo = Constant.Routes.VIEW_CART_ROUTE;
                Response.Redirect(redirecTo);
            }
        }
    }
}