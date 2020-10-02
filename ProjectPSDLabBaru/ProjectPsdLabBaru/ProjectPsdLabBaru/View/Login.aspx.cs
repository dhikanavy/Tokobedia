using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectPsdLabBaru.Controller;
using ProjectPsdLabBaru.Handler;

namespace ProjectPsdLabBaru.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //check session already logged in or not 
            if (Session[Constant.Keys.AUTH] != null)
                Response.Redirect(Constant.Routes.HOME_ROUTE);
            //if user check remember me, username field will be autofulfill
            if (!IsPostBack)
                if (Response.Cookies["email"] != null && Response.Cookies["password"] != null)
                {
                    logEmailTxt.Text = Request.Cookies["email"].Value;
                    logPasswordTxt.Text = Request.Cookies["password"].Value;
                }
        }

        protected void logInButton_Click(object sender, EventArgs e)
        {
            String email = logEmailTxt.Text;
            String password = logPasswordTxt.Text;
            String messageError = "";

            messageError = UserController.login(email, password);

            if (messageError != "") {
                logErrorLabel.Text = messageError;
                Response.Redirect(Constant.Routes.HOME_ROUTE);
            }
                
                
            else
            {
                Session[Constant.Keys.AUTH] = UserHandler.get(email, password);
                //add cookies if user checked remember me
                if (rememberMeCheckBox.Checked)
                {
                    Response.Cookies["email"].Value = logEmailTxt.Text;
                    Response.Cookies["password"].Value = logPasswordTxt.Text;
                    Response.Cookies["email"].Expires = DateTime.Now.AddDays(1);
                    Response.Cookies["password"].Expires = DateTime.Now.AddDays(1);
                }
                else
                {
                    Response.Cookies["email"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["password"].Expires = DateTime.Now.AddDays(-1);
                }

                //redirect
                var redirecTo = Constant.Routes.HOME_ROUTE;
                Response.Redirect(redirecTo);
            }
        }
    }
}