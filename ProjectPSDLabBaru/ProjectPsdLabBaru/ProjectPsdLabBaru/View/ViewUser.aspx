<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="ProjectPsdLabBaru.View.ViewUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="viewUserInformationGrid" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="USER ID" DataField="ID"/>
                    <asp:BoundField HeaderText="USER NAME" DataField="Name"/>
                    <asp:BoundField HeaderText="USER ROLE" DataField="Role"/>
                    <asp:BoundField HeaderText="USER STATUS" DataField="Status"/>
                </Columns>
            </asp:GridView>
        </div>
        <div>

                        <asp:Label ID="labelUserID" runat="server" Text="ID"></asp:Label>

                        <asp:TextBox ID="userIdTxt" runat="server"></asp:TextBox>

                        <asp:Label ID="labelUserRole" runat="server" Text="Role"></asp:Label>

                        <asp:RadioButtonList ID="RoleList" runat="server">
                            <asp:ListItem>Administrator</asp:ListItem>
                            <asp:ListItem>Member</asp:ListItem>
                            <asp:ListItem>Guest</asp:ListItem>
                        </asp:RadioButtonList>

                        <asp:Label ID="labelUserStatus" runat="server" Text="Status"></asp:Label>

                        <asp:RadioButtonList ID="StatusList" runat="server">
                            <asp:ListItem>Active</asp:ListItem>
                            <asp:ListItem>Blocked</asp:ListItem>
                        </asp:RadioButtonList>

                        <asp:TableCell>
                            <asp:Label ID="labelErrorViewUser" runat="server" Text=""></asp:Label>
                        </asp:TableCell>

                        <asp:TableCell>
                            <asp:Button ID="updateUserButton" runat="server" Text="Update User" OnClick="updateUserBtn_Click"/>
                        </asp:TableCell>

        </div>
    </form>
</body>
</html>
