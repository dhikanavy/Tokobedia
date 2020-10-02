using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectPsdLabBaru.Controller;
using ProjectPsdLabBaru.Handler;
using ProjectPsdLabBaru.Model;

namespace ProjectPsdLabBaru.View
{
    public partial class InsertPaymentType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Table1.Visible = false;
            NewPaymentbtn.Visible = false;
            insLabelError.Visible = false;
            if (Session[Constant.Keys.AUTH] != null)
            {
                User user = (User)Session[Constant.Keys.AUTH];
                if (user.RoleID == 1)
                {
                    Table1.Visible = true;
                    NewPaymentbtn.Visible = true;
                    insLabelError.Visible = true;
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

        protected void NewPaymentbtn_Click(object sender, EventArgs e)
        {
            String type = Typetxt.Text;

            String messageError = "";
            messageError = PaymentTypeController.insert(type);


            if (messageError != "")
                insLabelError.Text = messageError;
            else
            {
                PaymentTypeHandler.add(type);
                insLabelError.Text = "Payment type has been registered";
            }
        }
    }
}