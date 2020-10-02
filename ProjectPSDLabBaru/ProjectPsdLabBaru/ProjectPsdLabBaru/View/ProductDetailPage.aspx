<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDetailPage.aspx.cs" Inherits="ProjectPsdLabBaru.View.ProductDetailPage" %>

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
                    <asp:Label ID="lblOldName" runat="server" Text="Current Name"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="oldName" runat="server"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="lblOldPrice" runat="server" Text="Current Price"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="oldPrice" runat="server"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="lblOldStock" runat="server" Text="Current Stock"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="oldStock" runat="server"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="lblName" runat="server" Text="New Name"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="lblPrice" runat="server" Text="New Price"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="tbPrice" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="lblStock" runat="server" Text="New Stock"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="tbStock" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="lblErrorUpdateProduct" runat="server" Text=""></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="updateCurrentProduct" runat="server" Text="Update Product" OnClick="updateCurrentProduct_Click" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </form>
</body>
</html>
