<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePaymentType.aspx.cs" Inherits="ProjectPsdLabBaru.View.UpdatePaymentType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>UPDATE PAYMENT TYPE</div>

                    <asp:Label ID="labelPaymentTypeOld" runat="server" Text="Old Payment Name"></asp:Label>

                    <asp:Label ID="labelOldPayment" runat="server" Text=""></asp:Label>

                    <asp:Label ID="labelPaymentTypeUpdateCart" runat="server" Text="Product Type"></asp:Label>

                    <asp:TextBox ID="updateTxt" runat="server"></asp:TextBox>

        <asp:Button ID="updateButton" runat="server" Text="Update" OnClick="Updatebtn_Click" />

        <p>
            <asp:Label ID="lblerror" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
