<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 232px;
            left: 478px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 276px;
            left: 604px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 276px;
            left: 537px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblmsg" runat="server" CssClass="auto-style1" Text="Confirm to Delete this Stock?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style3" OnClick="btnYes_Click" Text="Yes" />
        <p>
            <asp:Button ID="btnNo" runat="server" CssClass="auto-style2" OnClick="btnNo_Click" Text="No" />
        </p>
    </form>
</body>
</html>
