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
    public partial class ViewUser : System.Web.UI.Page
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
                loadData();
            }
        }
        private void loadData()
        {
            viewUserInformationGrid.DataSource = UserHandler.getUserCustomView();
            viewUserInformationGrid.DataBind();
        }

        protected void updateUserBtn_Click(object sender, EventArgs e)
        {
            String Role = RoleList.Text, Status = StatusList.Text, messageError = "";
            User user = (User)Session[Constant.Keys.AUTH];
            int ID = 0, currentUserID=user.ID;
            
            messageError = UserController.updateUser(userIDTxt.Text, RoleList.Text, StatusList.Text, currentUserID);

            if (messageError != "")
                lblErrorViewUser.Text = messageError;
            else
            {
                ID = int.Parse(userIDTxt.Text);
                UserHandler.updateUser(ID, Role, Status);
                loadData();
                lblErrorViewUser.Text = "Current user information has been updated";
            }
        }
    }
}