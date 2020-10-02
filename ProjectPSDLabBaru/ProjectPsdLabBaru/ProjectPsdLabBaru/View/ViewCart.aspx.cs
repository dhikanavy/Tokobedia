using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectPsdLabBaru.Model;
using ProjectPsdLabBaru.Handler;
using ProjectPsdLabBaru.Controller;
using ProjectPsdLabBaru.Constant;

namespace ProjectPsdLabBaru.View
{
    public partial class ViewCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[Constant.Keys.AUTH] != null)
            {
                User user = (User)Session[Constant.Keys.AUTH];
                if (user.RoleID == 2)
                {
                    loadData();
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
        private void loadData()
        {
            User user = (User)Session[Constant.Keys.AUTH];
            var CartList = CartHandler.getCartCustomView(user.ID);
            viewCartGrid.DataSource = CartList;
            viewCartGrid.DataBind();
            int grandTotalCart=0;
            for(int i=0; i<CartList.Count(); i++)
            {
                grandTotalCart += CartList[i].SubTotal;
            }
            grandTotal.Text = "Rp. "+grandTotalCart.ToString();
        }
        protected void viewCartCheckOutProductTypeBtn_Click(object sender, EventArgs e)
        {
            User user = (User)Session[Constant.Keys.AUTH];
            if (CartHandler.getCartCustomView(user.ID).Count()==0)
            {
                lblErrorDeleteViewCart.Text = "You cannot do check out because your cart is empty";
            }
            else
            {
                var redirecTo = Constant.Routes.CHECK_OUT_ROUTE;
                Response.Redirect(redirecTo);
            }
        }

        protected void lbRedirects_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            Response.Redirect("UpdateCart.aspx?id=" + id);
        }

        protected void lblDeletes_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            User user = (User)Session[Constant.Keys.AUTH];
            int ID=id;
            
            CartHandler.remove(user.ID, ID);
            loadData();
            lblErrorDeleteViewCart.Text = "Product successfully deleted from your  cart";
        }
    }
}