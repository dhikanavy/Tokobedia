using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectPsdLabBaru.Handler;
using ProjectPsdLabBaru.Controller;
using ProjectPsdLabBaru.Model;

namespace ProjectPsdLabBaru.View
{
    public partial class UpdatePaymentType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Table1.Visible = false;
            Updatebtn.Visible = false;
            lblerror.Visible = false;
            lblPaymentTypeOld.Visible = false;
            lblOldPayment.Visible = false;
            if (Session[Constant.Keys.AUTH] != null)
            {
                int id = Int32.Parse(Request.QueryString["id"]);
                User user = (User)Session[Constant.Keys.AUTH];
                if (user.RoleID == 1)
                {
                    Table1.Visible = true;
                    Updatebtn.Visible = true;
                    lblerror.Visible = true;
                    lblPaymentTypeOld.Visible = true;
                    lblOldPayment.Visible = true;
                    lblOldPayment.Text = PaymentTypeHandler.getName(id);
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

        protected void Updatebtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"]);
            string messageError = "";

            messageError = PaymentTypeController.update(updateTxt.Text);

            if (messageError != "")
            {
                lblerror.Text = messageError;
            }
            else
            {
                PaymentTypeHandler.update(id, updateTxt.Text);
                lblerror.Text = "Update Success";
            }
        }
    }
}