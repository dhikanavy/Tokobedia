<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertProduct.aspx.cs" Inherits="ProjectPsdLabBaru.View.InsertProduct" %>

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
                    <asp:Label runat="server" Text="Insert Product Page Form" Font-Bold="true"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="labelName" runat="server" Text="Name"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="insNameTxt" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="labelStock" runat="server" Text="Stock"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="insStockTxt" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="labelPrice" runat="server" Text="Price"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="insPriceTxt" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <br />
                    <br />
                    <asp:Label ID="labelData" runat="server" Text="List All Product Type" Font-Bold="true"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            </asp:Table>
            <asp:GridView ID="viewProductTypeGrid" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="PRODUCT TYPE ID" DataField="ID"/>
                    <asp:BoundField HeaderText="PRODUCT TYPE NAME" DataField="Name"/>
                    <asp:BoundField HeaderText="PRODUCT TYPE DESCRIPTION" DataField="Description"/>
                </Columns>
            </asp:GridView>
        <asp:Table Width="550" BorderWidth="0" CellPadding="5" CellSpacing="5" runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" Text="Insert Product ID" Font-Bold="true"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="labelProductType" runat="server" Text="Product Type ID"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="getProductTypeID" runat="server" Width ="50"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="insLabelError" runat="server" Text=""></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="insertProduct" runat="server" Text="Insert Product" OnClick="insertProduct_Click" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
