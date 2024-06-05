<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 37px;
            left: 357px;
            z-index: 1;
            width: 254px;
            height: 40px;
        }
        .auto-style2 {
            position: absolute;
            top: 129px;
            left: 212px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style1" Font-Size="20pt" Text="Team Main Menu"></asp:Label>
        </p>
        <asp:Button ID="btnStock" runat="server" CssClass="auto-style2" OnClick="btnStock_Click" Text="Stock Management" />
    </form>
</body>
</html>
