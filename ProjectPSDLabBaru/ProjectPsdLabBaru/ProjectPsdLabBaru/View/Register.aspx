<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ProjectPsdLabBaru.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

                    <asp:Label ID="labelEmail" runat="server" Text="Email"></asp:Label>

                    <asp:TextBox ID="regemailTxt" runat="server"></asp:TextBox>

                    <asp:Label ID="labelUsername" runat="server" Text="Username"></asp:Label>

                    <asp:TextBox ID="regunameTxt" runat="server"></asp:TextBox>

                    <asp:Label ID="labelPassword" runat="server" Text="Password"></asp:Label>

                    <asp:TextBox ID="regpassTxt" runat="server"></asp:TextBox>

                    <asp:Label ID="labelConfirmPassword" runat="server" Text="Confirm Password"></asp:Label>

                    <asp:TextBox ID="regcnfrmTxt" runat="server"></asp:TextBox>

                    <asp:Label ID="labelGender" runat="server" Text="Select Your Gender"></asp:Label>

                    <asp:RadioButtonList ID="genderList" runat="server">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>

    </div>
    <div>
        <asp:Label ID="regErrorLabel" runat="server"></asp:Label>
    </div>
    <div>
        <asp:Button ID="registerButton" runat="server" Text="REGISTER" OnClick="registerButton_Click"/>
    </div>
    </form>
</body>
</html>
