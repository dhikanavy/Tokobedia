<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="ProjectPsdLabBaru.View.ViewProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

                        <asp:Label ID="labelEmail" runat="server" Text="Email : "></asp:Label>
                        <asp:Label ID="userEmail" runat="server" Text=""></asp:Label>


                        <asp:Label ID="labelName" runat="server" Text="Name : "></asp:Label>
                        <asp:Label ID="userName" runat="server" Text=""></asp:Label>


                        <asp:Label ID="labelGender" runat="server" Text="Gender : "></asp:Label>
                        <asp:Label ID="userGender" runat="server" Text=""></asp:Label>

        </div>

        <div>
            <asp:Button ID="UpdateProfileButton" runat="server" Text="Update my profile" OnClick="UpdateProfile_Click"/>
        </div>
    </form>
</body>
</html>
