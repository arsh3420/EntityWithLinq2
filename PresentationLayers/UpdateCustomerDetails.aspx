<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateCustomerDetails.aspx.cs" Inherits="PresentationLayers.UpdateCustomerDetails" %>

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
                <legend>Update Customer Details</legend>
                <asp:DropDownList ID="ddlCustomer" runat="server" OnSelectedIndexChanged="ddlCustomer_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                &nbsp;<asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" /><br />
                <fieldset>
                    <legend>Customer Registration:</legend>
                    <table>
                        <tr>
                            <td>
                                <label>First Name</label></td>
                            <td>
                                <asp:TextBox CssClass="form-control" ID="tbx_UFname" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ValidationGroup="updatecustomer" ID="RequiredFieldValidator7" runat="server" ControlToValidate="tbx_UFname" ErrorMessage="First Name" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label>Last Name</label></td>
                            <td>
                                <asp:TextBox CssClass="form-control" ID="tbx_ULname" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ValidationGroup="updatecustomer" ID="RequiredFieldValidator8" runat="server" ControlToValidate="tbx_ULname" ErrorMessage="Last Name" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>

                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label>Email</label></td>
                            <td>
                                <asp:TextBox CssClass="form-control" ID="tbx_UEmail" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ValidationGroup="updatecustomer" ID="RequiredFieldValidator9" runat="server" ControlToValidate="tbx_UEmail" ErrorMessage="Email" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ValidationGroup="updatecustomer" ID="RegularExpressionValidator1" runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="tbx_UEmail" ErrorMessage="Invalid Email" Display="None" SetFocusOnError="true"></asp:RegularExpressionValidator>

                            </td>
                        </tr>
                        <tr>
                            <td>
                                <label>Phone</label>
                            </td>
                            <td>
                                <asp:TextBox CssClass="form-control" ID="tbx_Phone" runat="server" TextMode="Phone"></asp:TextBox>
                                <asp:RequiredFieldValidator ValidationGroup="updatecustomer" ID="RequiredFieldValidator10" runat="server" ControlToValidate="tbx_Phone" ErrorMessage="Phone" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>

                            </td>
                        </tr>
                    </table>
                </fieldset>
            </fieldset>
            <hr />
            <asp:Button ID="btnupdate" runat="server" OnClick="Btnupdate_Click" Text="Update" ValidationGroup="updatecustomer" />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowSummary="false" ShowMessageBox="true" HeaderText="Please make below fields entry valid" ValidationGroup="updatecustomer" />
            <hr />
            <a href="default.aspx">Home</a>
        </div>
    </form>
</body>
</html>
