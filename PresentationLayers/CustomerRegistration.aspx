<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerRegistration.aspx.cs" Inherits="PresentationLayers.StudentRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset>
                <legend>Customer Registration:</legend>
                <table>
                    <tr>
                        <td>
                            <label>First Name</label></td>
                        <td>
                            <asp:TextBox CssClass="form-control" ID="tbx_Fname" runat="server" MaxLength="50"></asp:TextBox>
                            <asp:RequiredFieldValidator ValidationGroup="insert" ID="reqName" runat="server" ControlToValidate="tbx_Fname" ErrorMessage="First Name" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>Last Name</label></td>
                        <td>
                            <asp:TextBox CssClass="form-control" ID="tbx_Lname" runat="server" MaxLength="50"></asp:TextBox>
                            <asp:RequiredFieldValidator ValidationGroup="insert" ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbx_Lname" ErrorMessage="Last Name" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>Email</label></td>
                        <td>
                            <asp:TextBox CssClass="form-control" ID="tbx_Email" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ValidationGroup="insert" ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbx_Email" ErrorMessage="Email" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ValidationGroup="insert" ID="regvalidator" runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="tbx_Email" ErrorMessage="Invalid Email" Display="None" SetFocusOnError="true"></asp:RegularExpressionValidator>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>Phone</label>
                        </td>
                        <td>
                            <asp:TextBox CssClass="form-control" ID="tbx_Phone" runat="server" MaxLength="50"></asp:TextBox>
                            <asp:RequiredFieldValidator ValidationGroup="insert" ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbx_Phone" ErrorMessage="Phone" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>

                        </td>
                    </tr>
                </table>
            </fieldset>
            <fieldset>
                <legend>Address:</legend>
                <table>
                    <tr>
                        <td>
                            <label>Street</label></td>
                        <td>
                            <asp:TextBox CssClass="form-control" ID="tbx_Street" runat="server" MaxLength="30"></asp:TextBox>
                            <asp:RequiredFieldValidator ValidationGroup="insert" ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbx_Street" ErrorMessage="Street" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>City</label></td>
                        <td>
                            <asp:TextBox CssClass="form-control" ID="tbx_City" runat="server" MaxLength="30"></asp:TextBox>
                            <asp:RequiredFieldValidator ValidationGroup="insert" ID="RequiredFieldValidator5" runat="server" ControlToValidate="tbx_City" ErrorMessage="City" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label>State</label></td>
                        <td>
                            <asp:TextBox CssClass="form-control" ID="tbx_State" runat="server" MaxLength="30"></asp:TextBox>
                            <asp:RequiredFieldValidator ValidationGroup="insert" ID="RequiredFieldValidator6" runat="server" ControlToValidate="tbx_State" ErrorMessage="State" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                </table>
            </fieldset>
            <fieldset>
                <legend>Rooms</legend>
                <asp:CheckBoxList ID="chklists" runat="server">
                </asp:CheckBoxList>
            </fieldset>
            <hr />
            <asp:Button ID="btn_insert" runat="server" OnClick="Btn_insert_Click" Text="Insert" ValidationGroup="insert" />
            <asp:ValidationSummary ID="valsum" runat="server" ShowSummary="false" ShowMessageBox="true" HeaderText="Please make below fields entry valid" ValidationGroup="insert" />
            <hr />
            <a href="default.aspx">Home</a>
        </div>
    </form>
</body>
</html>
