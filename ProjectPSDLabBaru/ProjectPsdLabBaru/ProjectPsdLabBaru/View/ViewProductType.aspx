<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProductType.aspx.cs" Inherits="ProjectPsdLabBaru.View.ViewProductType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="viewProductTypeGrid" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton OnClick="lblDeletes_Click" ID="lblDeletes" CommandArgument='<%# Eval("Id")%>' runat="server">Delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <Columns>
                <asp:BoundField HeaderText="PRODUCT TYPE ID" DataField="ID"/>
                <asp:BoundField HeaderText="PRODUCT TYPE" DataField="Name"/>
                <asp:BoundField HeaderText="DESCRIPTION" DataField="Description"/>
            </Columns>
        </asp:GridView>
    </div>

    <div>
        <asp:Label ID="labelErrorDeleteType" runat="server" Text=""></asp:Label>
    </div>

    <div>
        <asp:Button ID="viewInsertProductType" runat="server" Text="Insert Product Type" OnClick="viewInsertProductType_Click"/>
        <asp:Button ID="viewUpdateProductType" runat="server" Text="Update Product Type" OnClick="viewUpdateProductType_Click" />
    </div>

    </form>
</body>
</html>
