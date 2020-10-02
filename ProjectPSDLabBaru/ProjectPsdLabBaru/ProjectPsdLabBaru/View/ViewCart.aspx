<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="ProjectPsdLabBaru.View.ViewCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="viewCartGrid" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton OnClick="labelRedirects_Click" ID="labelRedirects" CommandArgument='<%# Eval("Id")%>' runat="server">Update</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <Columns>
                    <asp:BoundField HeaderText="PRODUCT ID" DataField="ID"/>
                    <asp:BoundField HeaderText="PRODUCT NAME" DataField="Name"/>
                    <asp:BoundField HeaderText="PRODUCT PRICE" DataField="Price"/>
                    <asp:BoundField HeaderText="QUANTITY" DataField="Quantity"/>
                    <asp:BoundField HeaderText="SUBTOTAL" DataField="Subtotal"/>
                </Columns>
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton OnClick="labelDeletes_Click" ID="labelDeletes" CommandArgument='<%# Eval("Id")%>' runat="server">Delete</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <div>

                        <asp:Label ID="labelGrandTotal" runat="server" Text="Grand Total"></asp:Label>

                        <asp:Label ID="grandTotal" runat="server" Text=""></asp:Label>

                        <asp:Label ID="labelErrorDeleteViewCart" runat="server" Text=""></asp:Label>

        </div>
        <div>
             <asp:Button ID="viewCartCheckOutProductTypeButton" runat="server" Text="CheckOut" OnClick="viewCartCheckOutProductTypeBtn_Click" />
        </div>
    </form>
</body>
</html>
