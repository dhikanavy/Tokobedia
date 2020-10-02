<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckOut.aspx.cs" Inherits="ProjectPsdLabBaru.View.CheckOut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="viewPaymentTypeGrid" runat="server">
        </asp:GridView>
        <asp:Table Width="550" BorderWidth="0" CellPadding="5" CellSpacing="5" runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblPaymentTypeCheckOut" runat="server" Text="Insert Payment Type ID"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="paymentTypecheckOutTxt" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID ="lblErrorCheckOut" runat="server" Text=""></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        <asp:Button ID="checkOutBtn" runat="server" Text="CheckOut" OnClick="checkOutBtn_Click" />          
    </div>
    </form>
</body>
</html>
