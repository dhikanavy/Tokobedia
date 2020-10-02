<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="ProjectPsdLabBaru.View.UpdateProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

                    <asp:Label ID="labelUpdateEmail" runat="server" Text="New Email"></asp:Label>

                    <asp:TextBox ID="updateUserEmailTxt" runat="server"></asp:TextBox>

                    <asp:Label ID="labelUpdateName" runat="server" Text="New Name"></asp:Label>

                    <asp:TextBox ID="updateUserName" runat="server"></asp:TextBox>

                    <asp:Label ID="labelUpdateGender" runat="server" Text="New Gender"></asp:Label>

                    <asp:TextBox ID="updateUserGenderTxt" runat="server"></asp:TextBox>


                    <asp:Label ID="labelUpdateError" runat="server" Text=""></asp:Label>

                <asp:TableCell>
                    <asp:Button ID="UpdateProfileDataButton" runat="server" Text="Update" OnClick="UpdateProfileData_Click" />
                </asp:TableCell>

    </form>
</body>
</html>
