<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductTypeDetailPage.aspx.cs" Inherits="ProjectPsdLabBaru.View.ProductTypeDetailPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Table Width="550" BorderWidth="0" CellPadding="5" CellSpacing="5" runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="lblOldNameType" runat="server" Text="Current Name"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="oldNameType" runat="server"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="lblOldDescriptionType" runat="server" Text="Current Description"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="oldDescriptionType" runat="server"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="lblNameType" runat="server" Text="New Name"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="tbNameType" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="lblDescriptionType" runat="server" Text="New Description"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="tbDescriptionType" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="lblErrorUpdateProductType" runat="server" Text=""></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="updateCurrentProductType" runat="server" Text="Update Product Type" OnClick="updateCurrentProductType_Click" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </form>
</body>
</html>
