using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseLayer;
using BusinessLayer;
namespace PresentationLayers
{
    public partial class UpdateCustomerDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CustomerID"] == null)
                Response.Redirect("index.aspx?msg=Please Login to enter in to system.");
            if (!IsPostBack)
            {
                FillDetails();
                if (Request.QueryString["message"] != null)
                {
                    ltrAlertMessage.Text = Request.QueryString["message"];
                }
            }
        }

        private void FillDetails()
        {
            List<CustomerRegestration> lst = BAL.GetAllCustomers();
            if (lst != null && lst.Count > 0)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    ListItem li = new ListItem(lst[i].FirstNAME + " " + lst[i].LastNAME, lst[i].CustomerID.ToString());
                    ddlCustomer.Items.Add(li);
                }
                ddlCustomer.Items.Insert(0, new ListItem("select Customer", ""));
            }
            else
            {
                ddlCustomer.Items.Clear();
            }
        }

        protected void Btnupdate_Click(object sender, EventArgs e)
        {
            CustomerRegestration insertreg = new CustomerRegestration { CustomerID = Convert.ToInt32(ddlCustomer.SelectedValue), FirstNAME = tbx_UFname.Text, LastNAME = tbx_ULname.Text, EMAILID = tbx_UEmail.Text, PHONE = tbx_Phone.Text };
            BAL.UpdateStudentDetails(insertreg);
            Response.Redirect("default.aspx?msg=Customer details updated successfully.");

        }

        protected void ddlCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<CustomerRegestration> lst = BAL.GetUser(ddlCustomer.SelectedValue);
            if (lst != null && lst.Count > 0)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    tbx_UFname.Text = lst[i].FirstNAME;
                    tbx_ULname.Text = lst[i].LastNAME;
                    tbx_UEmail.Text = lst[i].EMAILID;
                    tbx_Phone.Attributes.Add("Value", lst[i].PHONE);
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            BAL.DeleteRecord(ddlCustomer.SelectedValue);
            Response.Redirect("updatecustomerdetails.aspx?message=Customer deleted successfully.");
        }

    }
}