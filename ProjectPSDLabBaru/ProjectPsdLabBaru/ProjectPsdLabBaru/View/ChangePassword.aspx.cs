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
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tableChangePassword.Visible = false;
            UpdatePassword.Visible = false;
            if (Session[Constant.Keys.AUTH] != null)
            {
                User user = (User)Session[Constant.Keys.AUTH];
                if (user.RoleID == 1 || user.RoleID == 2)
                {
                    tableChangePassword.Visible = true;
                    UpdatePassword.Visible = true;
                }
            }
            else
            {
                var redirecTo = Constant.Routes.HOME_ROUTE;
                Response.Redirect(redirecTo);
            }
        }

        protected void UpdatePassword_Click1(object sender, EventArgs e)
        {
            User user = (User)Session[Constant.Keys.AUTH];
            String messageError = "";

            messageError = UserController.changePassword(NewPasswords.Text, PasswordlamaTxt.Text, ConfirmPasswords.Text, user.Password);
            if (messageError != "")
                updatePasswordErrorLabel.Text = messageError;
            else
            {
                String OldPassword = PasswordlamaTxt.Text;
                String NewPassword = NewPasswords.Text;
                String ConfirmPassword = ConfirmPasswords.Text;
                String Email = user.Email;
                int ID = user.ID;
                updatePasswordErrorLabel.Text = "Your password has been updated";
                UserHandler.changePassword(ID, NewPassword);
                Session[Constant.Keys.AUTH] = UserHandler.get(Email, NewPassword);
            }
        }
    }
}