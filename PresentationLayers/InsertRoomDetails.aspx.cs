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
    public partial class InsertRoomDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CustomerID"] == null)
                Response.Redirect("index.aspx?msg=Please Login to enter in to system.");
            if (!IsPostBack)
            {
                btnCancel.Visible = false;
                FillRooms();
                if (Request.QueryString["message"] != null)
                {
                    ltrAlertMessage.Text = Request.QueryString["message"];
                }
            }
        }

        protected void btn_insertDetails_Click(object sender, EventArgs e)
        {
            if (btn_insertDetails.Text == "Insert")
            {
                Room insertROOM = new Room { Roomno = tbx_RoomNo.Text, Beds = tbx_Beds.Text, Floor = tbx_floor.Text, Type = DDLRoomType.SelectedValue };
                BAL.InsertRoomDetails(insertROOM);
                Response.Redirect("default.aspx?msg=Room Details Inserted Successfully.");
            }
            else
            {
                Room insertreg = new Room { Room_id = Convert.ToInt32(ddlRooms.SelectedValue), Roomno = tbx_RoomNo.Text, Beds = tbx_Beds.Text, Floor = tbx_floor.Text, Type = DDLRoomType.SelectedValue };
                BAL.UpdateRoomDetails(insertreg);
                Response.Redirect("default.aspx?msg=Room details updated successfully.");
            }
        }

        private void FillRooms()
        {
            List<Room> dt = BAL.GetAllRooms();
            if (dt != null && dt.Count > 0)
            {
                for (int i = 0; i < dt.Count; i++)
                {
                    ListItem li = new ListItem(dt[i].Roomno + " (B:" + dt[i].Beds + "," + dt[i].Type + ")", dt[i].Room_id.ToString());
                    ddlRooms.Items.Add(li);
                }
                ddlRooms.Items.Insert(0, new ListItem("select Room", ""));
            }
            else
            {
                ddlRooms.Items.Clear();
            }
        }


        protected void ddlRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Room> lst = BAL.getRoomDetails(ddlRooms.SelectedValue);
            if (lst != null && lst.Count > 0)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    tbx_RoomNo.Text = lst[i].Roomno;
                    tbx_Beds.Text = lst[i].Beds;
                    tbx_floor.Text = lst[i].Floor;
                    DDLRoomType.SelectedValue = lst[i].Type.Trim();
                }
                btnCancel.Visible = true;
                btn_insertDetails.Text = "Update";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            BAL.DeleteRoom(ddlRooms.SelectedValue);
            Response.Redirect("insertRoomDetails.aspx?message=Room deleted successfully.");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ddlRooms.SelectedValue = "";
            btnCancel.Visible = false;
            btn_insertDetails.Text = "Insert";
            tbx_RoomNo.Text = "";
            tbx_Beds.Text = "";
            tbx_floor.Text = "";
            DDLRoomType.SelectedValue = "";
        }
    }
}