<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblQuestion" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" Width="82px" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="margin-left: 45px" Text="No" Width="72px" />
    </form>
</body>
</html>
