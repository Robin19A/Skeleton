<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

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
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 206px; top: 117px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 224px; top: 193px; position: absolute; width: 65px; right: 416px" Text="Yes" />
        </p>
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 388px; top: 192px; position: absolute; width: 59px" Text="No" />
    </form>
</body>
</html>
