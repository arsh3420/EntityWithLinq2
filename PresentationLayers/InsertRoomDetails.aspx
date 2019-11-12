<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertRoomDetails.aspx.cs" Inherits="PresentationLayers.InsertRoomDetails" %>

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
        <div>
            <fieldset>
                <legend>Update Room Details</legend>
                <asp:DropDownList ID="ddlRooms" runat="server" OnSelectedIndexChanged="ddlRooms_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                &nbsp;<asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" /><br />
                <fieldset>
                    <legend>Room Details:</legend>
                    <table>
                        <tr>
                            <td>
                                <label>Room Number</label></td>
                            <td>
                                <asp:TextBox CssClass="form-control" ID="tbx_RoomNo" runat="server" MaxLength="100"></asp:TextBox>
                                <asp:RequiredFieldValidator ValidationGroup="ROOMDETAILS" ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbx_RoomNo" ErrorMessage="Room Number" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label>Number of Beds</label></td>
                            <td>
                                <asp:TextBox CssClass="form-control" ID="tbx_Beds" runat="server" MaxLength="100"></asp:TextBox>
                                <asp:RequiredFieldValidator ValidationGroup="ROOMDETAILS" ID="RequiredFieldValidator5" runat="server" ControlToValidate="tbx_Beds" ErrorMessage="Number of Beds" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label>Floor Number</label></td>
                            <td>
                                <asp:TextBox CssClass="form-control" ID="tbx_floor" runat="server" MaxLength="12"></asp:TextBox>
                                <asp:RequiredFieldValidator ValidationGroup="ROOMDETAILS" ID="RequiredFieldValidator6" runat="server" ControlToValidate="tbx_floor" ErrorMessage="Floor Number" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label>Room Type</label></td>
                            <td>
                                <asp:DropDownList ID="DDLRoomType" runat="server">
                                    <asp:ListItem Text="Select" Value=""></asp:ListItem>
                                    <asp:ListItem Text="AC room" Value="AC"></asp:ListItem>
                                    <asp:ListItem Text="Non ac room" Value="NOAC"></asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ValidationGroup="ROOMDETAILS" ID="RequiredFieldValidator1" runat="server" ControlToValidate="DDLRoomType" ErrorMessage="Room Type" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </fieldset>
            <hr />
            <asp:Button ID="btn_insertDetails" runat="server" OnClick="btn_insertDetails_Click" Text="Insert" ValidationGroup="ROOMDETAILS" />&nbsp;<asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
            <asp:ValidationSummary ID="valsum" runat="server" ShowSummary="false" ShowMessageBox="true" HeaderText="Please make below fields entry valid" ValidationGroup="ROOMDETAILS" />
            <hr />
            <a href="default.aspx">Home</a>
        </div>
    </form>
</body>
</html>
