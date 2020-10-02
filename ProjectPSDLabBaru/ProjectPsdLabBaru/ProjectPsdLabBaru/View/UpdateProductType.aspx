<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProductType.aspx.cs" Inherits="ProjectPsdLabBaru.View.UpdateProductType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="allProductTypeData" runat="server" OnRowDataBound="allProductTypeData_RowDataBound" Height="249px" Width="286px">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton OnClick="labelRedirect_Click" ID="lbRedirect" CommandArgument='<%# Eval("Id")%>' runat="server">Select</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
