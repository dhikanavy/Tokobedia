using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectPsdLabBaru.Model;

namespace ProjectPsdLabBaru.View
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tableProfile.Visible = false;
            UpdateProfile.Visible = false;
            if (Session[Constant.Keys.AUTH] != null)
            {
                User user = (User)Session[Constant.Keys.AUTH];
                if (user.RoleID == 1 || user.RoleID == 2)
                {
                    UserEmail.Text = user.Email;
                    UserName.Text = user.Name;
                    UserGender.Text = user.Gender;
                    tableProfile.Visible = true;
                    UpdateProfile.Visible = true;
                }
            }
            else
            {
                var redirecTo = Constant.Routes.HOME_ROUTE;
                Response.Redirect(redirecTo);
            }
        }

        protected void UpdateProfile_Click(object sender, EventArgs e)
        {
            var redirecTo = Constant.Routes.UPDATE_PROFILE_ROUTE;
            Response.Redirect(redirecTo);
        }
    }
}