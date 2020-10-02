<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateCart.aspx.cs" Inherits="ProjectPsdLabBaru.View.UpdateCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>UPDATE PAYMENT TYPE</div>
    
        <div>
                <asp:Label ID="labelUpdateNameCart" runat="server" Text="Name"></asp:Label>

                <asp:Label ID="updateCartNameTxt" runat="server"></asp:Label>

                <asp:Label ID="labelUpdateStockCart" runat="server" Text="Stock"></asp:Label>

                <asp:Label ID="updateCartStockTxt" runat="server"></asp:Label>

                <asp:Label ID="labelUpdatePriceCart" runat="server" Text="Price"></asp:Label>

                <asp:Label ID="updateCartPriceTxt" runat="server"></asp:Label>

                <asp:Label ID="labelUpdateProductTypeCart" runat="server" Text="Product Type"></asp:Label>

                <asp:Label ID="updateCartProductTypeTxt" runat="server"></asp:Label>
 
                <asp:Label ID="labelUpdateQuantityCart" runat="server" Text="Quantity"></asp:Label>

                <asp:TextBox ID="updateCartQuantityTxt" runat="server"></asp:TextBox>

                <asp:Label ID="labelErrorUpdateCart" runat="server" Text=""></asp:Label>

                <asp:TableCell>
                    <asp:Button ID="updateCartButton" runat="server" Text="Update Cart" OnClick="updateCartButton_Click"></asp:Button>
                </asp:TableCell>

        </div>
    </form>
</body>
</html>
