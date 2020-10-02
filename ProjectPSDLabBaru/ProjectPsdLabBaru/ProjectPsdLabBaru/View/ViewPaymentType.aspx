<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewPaymentType.aspx.cs" Inherits="ProjectPsdLabBaru.View.ViewPaymentType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:GridView ID="ListPaymentType" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:TemplateField HeaderText="">
                    <ItemTemplate>
                        <asp:LinkButton ID="UpdatePaymentType" CommandArgument='<%# Eval("id") %>' runat="server" OnClick="Update_Click" Text="Update"></asp:LinkButton>
                        <asp:LinkButton ID="DeletePaymentType" CommandArgument='<%# Eval("id") %>' runat="server" OnClick="Delete_Click" Text="Remove"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <Columns>
                <asp:BoundField HeaderText="ID" DataField="ID"/>
                <asp:BoundField HeaderText="Type" DataField="Type"/>
            </Columns>
        </asp:GridView>
    </div>
        <asp:Label ID="lblErrorViewPaymentType" runat="server" Text="" />
        <asp:Button ID="Insert" runat="server" OnClick="Insert_Click" Text="Insert New Payment Type" />
    </form>
</body>
</html>
