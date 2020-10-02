<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ProjectPsdLabBaru.View.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="labelWelcome" Font-Size="Large" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Button ID="viewProductButton" runat="server" Visible ="false" Text="View Product" OnClick="viewProductButton_Click"/>
        <!--Guest -->
        <asp:Button ID="logInButton" runat="server" Visible ="false" Text="Log In" OnClick="logInButton_Click"/>
        <!--Member -->
        <asp:Button ID="viewProfileButton" runat="server" Visible ="false" Text="View Profile" OnClick="viewProfileButton_Click"/>
        <asp:Button ID="logOutButton" runat="server" Visible ="false" Text="Log Out" OnClick="logOutButton_Click"/>
        <asp:Button ID="viewCartButton" runat="server" Visible ="false" Text="View Cart" OnClick="viewCartButton_Click"/>
        <asp:Button ID="viewTransactionHistoryButton" Visible ="false" runat="server" Text="View Transaction History" OnClick="viewTransactionHistoryButton_Click"/>
        <asp:Button ID="changePasswordButton" runat="server" Visible ="false" Text="Change Password" OnClick="changePasswordButton_Click"/>
        <!--admin -->
        <asp:Button ID="viewUserButton" runat="server" Visible ="false" Text="View User" OnClick="viewUserButton_Click"/>
        <asp:Button ID="insertProductButton" runat="server" Visible ="false" Text="Insert Product" OnClick="insertProductButton_Click"/>
        <asp:Button ID="updateProductButton" runat="server" Visible ="false" Text="Update Product" OnClick="updateProductButton_Click"/>
        <asp:Button ID="viewPaymentTypeButton" runat="server" Visible ="false" Text="View Payment Type" OnClick="viewPaymentTypeButton_Click"/>
        <asp:Button ID="insertPaymentTypeButton" runat="server" Visible ="false" Text="Insert Payment Type" OnClick="insertPaymentTypeButton_Click"/>
        <asp:Button ID="updatePaymentTypeButton" runat="server" Visible ="false" Text="Update Payment Type" OnClick="updatePaymentTypeButton_Click"/>
        <asp:Button ID="viewProductTypeButton" runat="server" Visible ="false" Text="View Product Type" OnClick="viewProductTypeButton_Click"/>
        <asp:Button ID="insertProductTypeButton" runat="server" Visible ="false" Text="Insert Product Type" OnClick="insertProductTypeButton_Click"/>
        <asp:Button ID="updateProductTypeButton" runat="server" Visible ="false" Text="Update Product Type" OnClick="updateProductTypeButton_Click"/>
        <asp:Button ID="viewTransactionReportButton" runat="server" Visible ="false" Text="View Transaction Report" OnClick="viewTransactionReportButton_Click"/>
    </div>
    <br />
    <br />
    <div>
        <asp:GridView ID="randomProductGridView" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:TemplateField HeaderText="Add">
                    <ItemTemplate>
                        <asp:LinkButton ID="AddCart" CommandArgument='<%# Eval("id") %>' runat="server" OnClick="AddCart_Click" Text="Add To Cart"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <Columns>
                <asp:BoundField HeaderText="PRODUCT NAME" DataField="Name"/>
                <asp:BoundField HeaderText="PRODUCT PRICE" DataField="Price"/>
                <asp:BoundField HeaderText="PRODUCT STOCK" DataField="Stock"/>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
