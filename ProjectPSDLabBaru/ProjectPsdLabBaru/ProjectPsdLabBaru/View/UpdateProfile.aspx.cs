using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectPsdLabBaru.Model;
using ProjectPsdLabBaru.Controller;
using ProjectPsdLabBaru.Handler;

namespace ProjectPsdLabBaru.View
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tableUpdateProfile.Visible = false;
            UpdateProfileData.Visible = false;
            updateErrorLabel.Visible = false;
            if (Session[Constant.Keys.AUTH] != null)
            {
                User user = (User)Session[Constant.Keys.AUTH];
                if (user.RoleID == 1 || user.RoleID == 2)
                {
                    tableUpdateProfile.Visible = true;
                    UpdateProfileData.Visible = true;
                    updateErrorLabel.Visible = true;
                    UserUpdateEmail.Text = user.Email;
                    UserUpdateName.Text = user.Name;
                    UserUpdateGender.Text = user.Gender;
                }
            }
            else
            {
                var redirecTo = Constant.Routes.HOME_ROUTE;
                Response.Redirect(redirecTo);
            }
        }

        protected void UpdateProfileData_Click(object sender, EventArgs e)
        {
            User user = (User)Session[Constant.Keys.AUTH];
            String Email = UserUpdateEmail.Text, Name = UserUpdateName.Text, Gender = UserUpdateGender.Text, messageError = "", Password;
            int ID = user.ID;
            Password = user.Password;
            
            messageError = UserController.updateProfile(ID, Email, Name, Gender);
            if (messageError != "")
                updateErrorLabel.Text = messageError;
            else
            {
                UserHandler.updateProfile(ID, Email, Name, Gender);
                updateErrorLabel.Text = "Your profile has been updated";
                Session[Constant.Keys.AUTH] = UserHandler.get(Email, Password);
            }
        }
    }
}