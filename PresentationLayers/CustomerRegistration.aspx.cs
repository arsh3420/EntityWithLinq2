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
    public partial class StudentRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CustomerID"] == null)
                Response.Redirect("index.aspx?msg=Please Login to enter in to system.");
            if (!IsPostBack)
            { FillRooms(); }
        }

        protected void Btn_insert_Click(object sender, EventArgs e)
        {
            CustomerRegestration insertreg = new CustomerRegestration { FirstNAME = tbx_Fname.Text, LastNAME = tbx_Lname.Text, EMAILID = tbx_Email.Text, PHONE = tbx_Phone.Text };
            int id = BAL.InsertRegister(insertreg);

            foreach (ListItem li in chklists.Items)
            {
                if (li.Selected)
                {
                    checkout checkoutdetails = new checkout { Address_id = id, Room_id = Convert.ToInt32(li.Value) };
                    BAL.InsertRoomsBooked(checkoutdetails);
                }
            }
            Customeraddress insertadd = new Customeraddress { city = tbx_City.Text, state = tbx_State.Text, street = tbx_Street.Text, Address_id = id };
            BAL.InsertAddress(insertadd);
            Response.Redirect("default.aspx?msg=Customer Details inserted successfully.");
        }

        private void FillRooms()
        {
            List<Room> dt = BAL.GetAllRooms();
            if (dt != null && dt.Count > 0)
            {
                for (int i = 0; i < dt.Count; i++)
                {
                    ListItem li = new ListItem(dt[i].Roomno + " (" + dt[i].Type + ")", dt[i].Room_id.ToString());
                    chklists.Items.Add(li);
                }
            }
            else
            {
                chklists.Items.Clear();
            }
        }
    }
}