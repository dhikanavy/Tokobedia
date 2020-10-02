<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="ProjectPsdLabBaru.View.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
            <asp:Table ID="tableChangePassword"  Width="550" BorderWidth="0" CellPadding="5" CellSpacing="5" runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblUpdateOld" runat="server" Text="Old Password"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="PasswordlamaTxt" runat="server" ></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblUpdateNew" runat="server" Text="New Password"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="NewPasswords" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblUpdateConf" runat="server" Text="Confirm Password"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="ConfirmPasswords" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        <div>
            <asp:Label ID="updatePasswordErrorLabel" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="UpdatePassword" runat="server" Text="Update" OnClick="UpdatePassword_Click1" />
        </div>
    </form>
</body>
</html>
