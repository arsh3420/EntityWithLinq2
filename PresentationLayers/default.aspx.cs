using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseLayer;
using BusinessLayer;
using System.Data;

namespace PresentationLayers
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CustomerID"] == null)
                Response.Redirect("index.aspx?msg=Please Login to enter in to system.");

            if (!IsPostBack)
            {
                FillRooms();
                FillCustomerDetails();
                if (Request.QueryString["message"] != null)
                {
                    ltrAlertMessage.Text = Request.QueryString["message"];
                }
            }
        }



        private void FillCustomerDetails()
        {
            List<CustomerRegestration> dt = BAL.GetAllCustomers();
            if (dt != null && dt.Count > 0)
            {
                gridCustomer.DataSource = dt;
                gridCustomer.DataBind();

                for (int i = 0; i < dt.Count; i++)
                {
                    ListItem li = new ListItem(dt[i].FirstNAME + " " + dt[i].LastNAME, dt[i].CustomerID.ToString());
                }
            }
            else
            {
                gridCustomer.DataSource = null;
                gridCustomer.DataBind();
            }

            List<Customeraddress> dt1 = BAL.GetAlladdress();
            if (dt1 != null && dt1.Count > 0)
            {
                gridaddress.DataSource = dt1;
                gridaddress.DataBind();
            }
            else
            {
                gridaddress.DataSource = null;
                gridaddress.DataBind();
            }

            List<checkout> dt2 = BAL.GetAllBooked();
            if (dt2 != null && dt2.Count > 0)
            {

                gridRoomsBooked.DataSource = dt2;
                gridRoomsBooked.DataBind();
            }
            else
            {
                gridRoomsBooked.DataSource = null;
                gridRoomsBooked.DataBind();
            }

        }

        protected void BtnGet_Click(object sender, EventArgs e)
        {
            FillCustomerDetails();
        }

        private void FillRooms()
        {
            List<Room> dt = BAL.GetAllRooms();
            if (dt != null && dt.Count > 0)
            {
                gridRooms.DataSource = dt;
                gridRooms.DataBind();
            }
            else
            {
                gridRooms.DataSource = null;
                gridRooms.DataBind();
            }
        }

       
    }
}