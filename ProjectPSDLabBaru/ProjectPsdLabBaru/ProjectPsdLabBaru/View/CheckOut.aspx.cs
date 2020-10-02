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
    public partial class CheckOut : System.Web.UI.Page
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
            viewPaymentTypeGrid.DataSource = PaymentTypeHandler.getAll();
            viewPaymentTypeGrid.DataBind();
        }

        protected void checkOutBtn_Click(object sender, EventArgs e)
        {
            string messageError = "";
            int PaymentTypeID=0;

            messageError = CartController.checkPaymentTypes(paymentTypecheckOutTxt.Text);
            if(messageError != "")
            {
                lblErrorCheckOut.Text = messageError;
            }
            else
            {
                User user = (User)Session[Constant.Keys.AUTH];
                PaymentTypeID = int.Parse(paymentTypecheckOutTxt.Text);
                TransactionHandler.insertTransaction(CartHandler.getAllCurrentUserCart(user.ID), PaymentTypeID, user.ID);
                CartHandler.removeAll(user.ID);
                var redirecTo = Constant.Routes.HOME_ROUTE;
                Response.Redirect(redirecTo);
            }
        }
    }
}