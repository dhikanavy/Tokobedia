<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjectPsdLabBaru.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Table Width="550" BorderWidth="0" CellPadding="5" CellSpacing="5" runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="labelEmail" runat="server" Text="Email"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="logEmailTxt" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="labelPassword" runat="server" Text="Password"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="logPasswordTxt" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="labelRememberMe" runat="server" Text="Remember Me"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:CheckBox ID="rememberMeCheckBox" runat="server"></asp:CheckBox>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    <div>
        <asp:Label ID="logErrorLabel" runat="server"></asp:Label>
    </div>
    <div>
        <asp:HyperLink ID="regFirst" runat="server" NavigateUrl="~/View/Register.aspx">Dont Have Account? Register Here</asp:HyperLink>
    </div>
    <div>
        <asp:Button ID="logInButton" runat="server" Text="LOG IN" OnClick="logInButton_Click"/>
    </div>
    </form>
</body>
</html>
