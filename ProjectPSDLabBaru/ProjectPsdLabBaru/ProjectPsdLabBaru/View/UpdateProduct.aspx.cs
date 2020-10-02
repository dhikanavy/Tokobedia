﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectPsdLabBaru.Model;
using ProjectPsdLabBaru.Handler;

namespace ProjectPsdLabBaru.View
{
    public partial class UpdateProduct : System.Web.UI.Page
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
                else
                {
                    allProductData.DataSource = ProductHandler.getAllProduct();
                    allProductData.DataBind();
                }
            }
        }

        protected void allProductData_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[2].Visible = false;
        }

        protected void lbRedirect_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse((sender as LinkButton).CommandArgument);
            Response.Redirect("ProductDetailPage.aspx?id=" + id);
        }
    }
}