<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddToCart.aspx.cs" Inherits="ProjectPsdLabBaru.View.AddToCart" %>

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
                    <asp:Label ID="labelNameAddToCart" runat="server" Text="Name"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="addToCartNameTxt" runat="server"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="labelStockAddToCart" runat="server" Text="Stock"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="addToCartStockTxt" runat="server"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="labelPriceAddToCart" runat="server" Text="Price"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="addToCartPriceTxt" runat="server"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="labelProductTypeAddToCart" runat="server" Text="Product Type"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="addToCartProductTypeTxt" runat="server"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="labelQuantityAddToCart" runat="server" Text="Quantity"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="addToCartQuantityTxt" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="labelErrorAddToCart" runat="server" Text=""></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="addToCartButton" runat="server" Text="Add To Cart" OnClick="addToCartButton_Click"></asp:Button>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
