<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PresentationLayers.index" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hotel Booking Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <table width="100%" border="0" style="padding-top: 100px;">
            <tr>
                <td align="center">
                    <table border="1" width="500px">
                        <tr>
                            <td colspan="2" align="center">
                                <h1>Hotel Bookings</h1>
                            </td>
                        </tr>
                        <tr>
                            <td>Username</td>
                            <td>
                                <asp:TextBox ID="tbxUsername" runat="server" Width="99%"></asp:TextBox></td>
                            <asp:RequiredFieldValidator ID="reqName" runat="server" ControlToValidate="tbxUsername" ErrorMessage="Username" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
                        </tr>
                        <tr>
                            <td>Password</td>
                            <td>
                                <asp:TextBox ID="tbxPassword" TextMode="Password" runat="server" Width="99%"></asp:TextBox></td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbxPassword" ErrorMessage="Password" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
                        </tr>
                        <tr>
                            <td align="right" colspan="2">
                                <br /><asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Width="20%" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /><br />
                                <asp:ValidationSummary ID="valsum" runat="server" ShowSummary="false" ShowMessageBox="true" HeaderText="Please make below fields entry valid" />
                            </td>
                        </tr>
                    </table>
                    <br />
                    <asp:Literal ID="ltrLoginmessage" runat="server"></asp:Literal>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
