<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 335px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label runat="server" Text="Staff Login Page"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" BackColor="White" BorderColor="White" ForeColor="#FF3300" style="z-index: 1; left: 422px; top: 135px; position: absolute" Text="lblError"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 141px; top: 216px; position: absolute" Text="Login" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 218px; top: 215px; position: absolute" Text="Cancel" />
        </p>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 46px; top: 116px; position: absolute" Text="Username:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 48px; top: 158px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 136px; top: 115px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 136px; top: 161px; position: absolute" TextMode="Password"></asp:TextBox>
    </form>
</body>
</html>
