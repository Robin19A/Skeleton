<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockLogin.aspx.cs" Inherits="StockLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 401px;
            top: 60px;
            position: absolute;
        }
        .auto-style2 {
            z-index: 1;
            left: 406px;
            top: 144px;
            position: absolute;
        }
        .auto-style3 {
            z-index: 1;
            left: 406px;
            top: 119px;
            position: absolute;
        }
        .auto-style4 {
            z-index: 1;
            left: 409px;
            top: 227px;
            position: absolute;
        }
        .auto-style5 {
            z-index: 1;
            left: 412px;
            top: 200px;
            position: absolute;
        }
        .auto-style6 {
            z-index: 1;
            left: 446px;
            top: 271px;
            position: absolute;
        }
        .auto-style7 {
            z-index: 1;
            left: 533px;
            top: 322px;
            position: absolute;
        }
        .auto-style8 {
            z-index: 1;
            left: 420px;
            top: 321px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="auto-style4"></asp:TextBox>
<asp:Label ID="Label1" runat="server" Text="Stock Login Page" CssClass="auto-style1"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" Text="Password: " CssClass="auto-style5"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="auto-style2"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" CssClass="auto-style6"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" Text="Username: " CssClass="auto-style3"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="auto-style7" OnClick="btnCancel_Click" />
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" CssClass="auto-style8" />
    </form>
</body>
</html>
