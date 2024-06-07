<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnAdd" runat="server" Height="26px" style="z-index: 1; left: 16px; top: 375px; position: absolute; right: 1024px" Text="Add" />
        <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 14px; top: 40px; position: absolute; height: 318px; width: 358px"></asp:ListBox>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnEdit" runat="server" Height="26px" style="z-index: 1; left: 91px; top: 375px; position: absolute" Text="Edit" />
        <p>
            <asp:Button ID="btnAdd0" runat="server" style="z-index: 1; left: 16px; top: 375px; position: absolute; right: 1024px" Text="Add" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 19px; top: 423px; position: absolute" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>
