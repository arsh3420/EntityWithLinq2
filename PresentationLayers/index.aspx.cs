using BusinessLayer;
using DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayers
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["CustomerID"] != null)
                    Response.Redirect("default.aspx?msg=Successfully Logged in.");
            }
            if (Request.QueryString["message"] != null)
                ltrLoginmessage.Text = Request.QueryString["message"];
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text != "" && tbxPassword.Text != "")
            {
                List <DatabaseLayer.Login> dt = BAL.GetDataTable(IsSQLInjection(tbxUsername.Text), IsSQLInjection(tbxPassword.Text));
                if (dt != null && dt.Count > 0)
                {
                    Session["CustomerID"] = dt[0].id.ToString();
                    Response.Redirect("default.aspx?msg=Successfully Logged in.", true);
                }
                else
                {
                    ltrLoginmessage.Text = "<font color='red'>Username or Password may be incorrect!</font>";
                }
            }
        }

        private string IsSQLInjection(string text)
        {
            return text.Replace("'", "").Replace("(", "").Replace(")", "").Replace("\"", "").Replace("*", "").Replace("$", "").Replace("&", "").Replace("-", "").Replace(";", "").Replace("[", "").Replace("]", "").Replace("}", "").Replace("{", "").Replace("<", "").Replace(">", "").Replace("=", "");
        }
    }
}