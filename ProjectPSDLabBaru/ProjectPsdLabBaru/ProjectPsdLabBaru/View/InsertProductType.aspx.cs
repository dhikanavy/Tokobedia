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
    public partial class InsertProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[Constant.Keys.AUTH] != null)
            {
                User user = (User)Session[Constant.Keys.AUTH];
                if (user.RoleID != 1)
                {
                    Response.Redirect(Constant.Routes.HOME_ROUTE);
                }
            }
        }

        protected void insertProductType_Click(object sender, EventArgs e)
        {
            String ProductTypeName = insTypeNameTxt.Text, Description = insDescriptionTxt.Text, messageError="";
            messageError = ProductTypeController.insert(ProductTypeName, Description);

            if (messageError != "")
                insLabelTypeError.Text = messageError;
            else
            {
                ProductTypeHandler.insertProductType(ProductTypeName, Description);
                insLabelTypeError.Text = "Your product type has been added";
            }
        }
    }
}