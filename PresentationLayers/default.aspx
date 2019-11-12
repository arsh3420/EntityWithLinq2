<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PresentationLayers._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hotel Booking system DSD-06</title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <b>
                <asp:Literal ID="ltrAlertMessage" runat="server"></asp:Literal></b>
        </p>
        <hr />
        <fieldset>
            <legend>Menu</legend>
            <a href="InsertRoomDetails.aspx">Rooms Details</a> | <a href="CustomerRegistration.aspx">Register Customer</a> | <a href="UpdateCustomerDetails.aspx">Update Customer Details</a> | (<a href="logout.aspx">Logout</a>)
        </fieldset>
        <hr />
        <div>
            Customers<br />
            <asp:GridView ID="gridCustomer" runat="server"></asp:GridView>
            <br />
            Customer Addresses<br />
            <asp:GridView ID="gridaddress" runat="server"></asp:GridView>
            <br />
            Rooms Booked
            <asp:GridView ID="gridRoomsBooked" runat="server"></asp:GridView>
            <br />
            Rooms List
            <asp:GridView ID="gridRooms" runat="server"></asp:GridView>
            <br />
            <br />
            <asp:Button ID="btnGet" runat="server" OnClick="BtnGet_Click" Text="Get Details" />
            <hr />

        </div>
    </form>
</body>
</html>
