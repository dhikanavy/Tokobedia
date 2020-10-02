using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectPsdLabBaru.Model;
using ProjectPsdLabBaru.Handler;

namespace ProjectPsdLabBaru.View
{
    public partial class Home : System.Web.UI.Page
    {
        protected static List<Product> List = ProductHandler.getFiveRandomProduct();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[Constant.Keys.AUTH] != null)
            {
                User user = (User)Session[Constant.Keys.AUTH];
                labelWelcome.Text = "Welcome, " + user.Name;
                if (user.RoleID == 1)
                {
                    viewProductButton.Visible = true;
                    viewProfileButton.Visible = true;
                    logOutButton.Visible = true;
                    viewUserButton.Visible = true;
                    insertProductButton.Visible = true;
                    updateProductButton.Visible = true;
                    viewPaymentTypeButton.Visible = true;
                    insertPaymentTypeButton.Visible = true;
                    updatePaymentTypeButton.Visible = true;
                    viewProductTypeButton.Visible = true;
                    insertProductTypeButton.Visible = true;
                    updateProductTypeButton.Visible = true;
                    viewTransactionHistoryButton.Visible = true;
                }
                else if (user.RoleID == 2)
                {
                    viewProductButton.Visible = true;
                    viewProfileButton.Visible = true;
                    logOutButton.Visible = true;
                    viewCartButton.Visible = true;
                    viewTransactionHistoryButton.Visible = true;
                    loadData(2);
                }
            }
            else
            {
                labelWelcome.Text = "Welcome, Guest";
                viewProductButton.Visible = true;
                logInButton.Visible = true;
                loadData(3);
            }
        }

        public void loadData(int Role)
        {
            if (Role == 3) randomProductGridView.Columns[0].Visible = false;
            randomProductGridView.DataSource = List;
            randomProductGridView.DataBind();
        }

        protected void logOutButton_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Cookies["email"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["password"].Expires = DateTime.Now.AddDays(-1);
            //redirect
            var redirecTo = Constant.Routes.HOME_ROUTE;
            Response.Redirect(redirecTo);
        }

        protected void viewProductButton_Click(object sender, EventArgs e)
        {
            var redirecTo = Constant.Routes.VIEW_PRODUCT_ROUTE;
            Response.Redirect(redirecTo);
        }

        protected void viewProfileButton_Click(object sender, EventArgs e)
        {
            var redirecTo = Constant.Routes.VIEW_PROFILE_ROUTE;
            Response.Redirect(redirecTo);
        }

        protected void viewUserButton_Click(object sender, EventArgs e)
        {
            var redirecTo = Constant.Routes.VIEW_USER_ROUTE;
            Response.Redirect(redirecTo);
        }

        protected void insertProductButton_Click(object sender, EventArgs e)
        {
            var redirecTo = Constant.Routes.INSERT_PRODUCT_ROUTE;
            Response.Redirect(redirecTo);
        }

        protected void updateProductButton_Click(object sender, EventArgs e)
        {
            var redirecTo = Constant.Routes.UPDATE_PRODUCT_ROUTE;
            Response.Redirect(redirecTo);
        }

        protected void viewProductTypeButton_Click(object sender, EventArgs e)
        {
            var redirecTo = Constant.Routes.VIEW_PRODUCTTYPE_ROUTE;
            Response.Redirect(redirecTo);
        }

        protected void insertProductTypeButton_Click(object sender, EventArgs e)
        {
            var redirecTo = Constant.Routes.INSERT_PRODUCTTYPE_ROUTE;
            Response.Redirect(redirecTo);
        }

        protected void updateProductTypeButton_Click(object sender, EventArgs e)
        {
            var redirecTo = Constant.Routes.UPDATE_PRODUCTTYPE_ROUTE;
            Response.Redirect(redirecTo);
        }

        protected void logInButton_Click(object sender, EventArgs e)
        {
            //redirect
            var redirecTo = Constant.Routes.LOGIN_ROUTE;
            Response.Redirect(redirecTo);
        }

        protected void changePasswordButton_Click(object sender, EventArgs e)
        {
            var redirecTo = Constant.Routes.CHANGE_PASSWORD_ROUTE;
            Response.Redirect(redirecTo);
        }
        
        protected void viewCartButton_Click(object sender, EventArgs e)
        {
            Response.Redirect(Constant.Routes.VIEW_CART_ROUTE);
        }

        protected void viewTransactionHistoryButton_Click(object sender, EventArgs e)
        {

        }

        protected void viewPaymentTypeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect(Constant.Routes.VIEW_PAYMENT_TYPE);
        }

        protected void insertPaymentTypeButton_Click(object sender, EventArgs e)
        {
            var redirecTo = Constant.Routes.INSERT_PAYMENT_TYPE;
            Response.Redirect(redirecTo);
        }

        protected void updatePaymentTypeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect(Constant.Routes.VIEW_PAYMENT_TYPE);
        }

        protected void viewTransactionReportButton_Click(object sender, EventArgs e)
        {

        }

        protected void AddCart_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            Response.Redirect("AddToCart.aspx?id=" + id);
        }
    }
}