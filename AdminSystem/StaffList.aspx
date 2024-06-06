<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" Height="427px" Width="502px"></asp:ListBox>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 190px; top: 482px; position: absolute" Text="Delete" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 6px; top: 538px; position: absolute" Text="Enter a Address"></asp:Label>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 107px; top: 480px; position: absolute" Text="Edit" />
        </p>
        <p>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 136px; top: 539px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 9px; top: 569px; position: absolute" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 174px; top: 570px; position: absolute" Text="Clear Filter" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 20px; top: 611px; position: absolute" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
