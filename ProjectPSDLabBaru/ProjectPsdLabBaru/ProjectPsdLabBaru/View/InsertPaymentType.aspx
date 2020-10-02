<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertPaymentType.aspx.cs" Inherits="ProjectPsdLabBaru.View.InsertPaymentType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        INSERT NEW PAYMENT TYPE<br />
        <br />
        <asp:Table ID="Table1" runat="server" Width="446px">
            <asp:TableRow>
                 <asp:TableCell>
                    <asp:Label ID="Namalabel" runat="server" Text="Name"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="Typetxt" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    
    </div>
        <p>
            <asp:Button ID="NewPaymentbtn" runat="server" OnClick="NewPaymentbtn_Click" Text="Insert" />
        </p>
        <asp:Label ID="insLabelError" runat="server"></asp:Label>
    </form>
</body>
</html>
