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
    public partial class ViewPaymentType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListPaymentType.Visible = false;
            lblErrorViewPaymentType.Visible = false;
            Insert.Visible = false;
            if (Session[Constant.Keys.AUTH] != null)
            {
                User user = (User)Session[Constant.Keys.AUTH];
                if (user.RoleID == 1)
                {
                    ListPaymentType.Visible = true;
                    lblErrorViewPaymentType.Visible = true;
                    Insert.Visible = true;
                    Load_PaymentType();
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

        protected void Load_PaymentType()
        {
            ListPaymentType.DataSource = PaymentTypeHandler.getAll();
            ListPaymentType.DataBind();
        }
        protected void Update_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            Response.Redirect("UpdatePaymentType.aspx?id=" + id);
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            string messageError = PaymentTypeController.delete(id);

            if (messageError != "")
            {
                lblErrorViewPaymentType.Text = messageError;
            }
            else
            {
                PaymentTypeHandler.remove(id);
                Load_PaymentType();
                Response.Redirect(Constant.Routes.VIEW_PAYMENT_TYPE);
                lblErrorViewPaymentType.Text = "Payment type has been deleted";
            }
        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            Response.Redirect(Constant.Routes.INSERT_PAYMENT_TYPE);
        }
    }
}