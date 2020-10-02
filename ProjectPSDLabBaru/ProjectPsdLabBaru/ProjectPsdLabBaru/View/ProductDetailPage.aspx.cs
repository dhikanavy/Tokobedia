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
    public partial class ProductDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"]);
            Product p = ProductHandler.get(id);
            oldName.Text = p.Name;
            oldPrice.Text = p.Price.ToString();
            oldStock.Text = p.Stock.ToString();
        }

        protected void updateCurrentProduct_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"]);
            Product p = ProductHandler.get(id);
            String Name = tbName.Text, messageError="";
            int ID = p.ID, Stock, Price;
            messageError = ProductController.update(Name, tbStock.Text, tbPrice.Text);

            if (messageError != "")
                lblErrorUpdateProduct.Text = messageError;
            else
            {
                Stock = int.Parse(tbStock.Text);
                Price = int.Parse(tbPrice.Text);
                ProductHandler.updateProduct(ID, Name, Price, Stock);
                lblErrorUpdateProduct.Text = "Your product has been updated";
            }
        }
    }
}