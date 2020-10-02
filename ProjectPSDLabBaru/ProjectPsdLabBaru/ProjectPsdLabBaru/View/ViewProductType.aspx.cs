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
    public partial class ViewProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            viewInsertProductType.Visible = false;
            viewUpdateProductType.Visible = false;
            lblErrorDeleteType.Visible = false;
            if (Session[Constant.Keys.AUTH] != null)
            {
                User user = (User)Session[Constant.Keys.AUTH];
                if (user.RoleID == 1)
                {
                    viewInsertProductType.Visible = true;
                    viewUpdateProductType.Visible = true;
                    lblErrorDeleteType.Visible = true;
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
            viewProductTypeGrid.DataSource = ProductTypeHandler.getAllProductType();
            viewProductTypeGrid.DataBind();
        }

        protected void viewUpdateProductType_Click(object sender, EventArgs e)
        {
            var redirecTo = Constant.Routes.UPDATE_PRODUCTTYPE_ROUTE;
            Response.Redirect(redirecTo);
        }

        protected void viewInsertProductType_Click(object sender, EventArgs e)
        {
            var redirecTo = Constant.Routes.INSERT_PRODUCTTYPE_ROUTE;
            Response.Redirect(redirecTo);
        }

        protected void lblDeletes_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse((sender as LinkButton).CommandArgument);
            string messageError = ProductTypeController.delete(ID);

            if (messageError != "")
            {
                lblErrorDeleteType.Text = messageError;
            }
            else
            {
                ProductTypeHandler.remove(ID);
                loadData();
                lblErrorDeleteType.Text = "Product type has been deleted";
            }
        }
    }
}