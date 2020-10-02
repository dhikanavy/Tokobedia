using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectPsdLabBaru.Controller;
using ProjectPsdLabBaru.Model;
using ProjectPsdLabBaru.Handler;
using ProjectPsdLabBaru.Factory;

namespace ProjectPsdLabBaru.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[Constant.Keys.AUTH] != null)
                Response.Redirect(Constant.Routes.HOME_ROUTE);
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            String email = regEmailTxt.Text;
            String name = regUsernameTxt.Text;
            String password = regPasswordTxt.Text;
            String confirmPassword = regConfirmPasswordTxt.Text;
            String gender = genderList.Text;
            String messageError = "";

            messageError = UserController.register(email, name, password, confirmPassword, gender);

            if (messageError != "")
                regErrorLabel.Text = messageError;
            else
            {
                UserHandler.addUser(email, name, password, gender);

                regErrorLabel.Text = "Your account has been registered";
            }
        }
    }
}