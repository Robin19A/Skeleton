<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstSupplierList" runat="server" Height="254px" Width="261px" OnSelectedIndexChanged="lstSupplierList_SelectedIndexChanged"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="margin-left: 32px" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="height: 26px; margin-left: 34px" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="lblPhoneNumber" runat="server" height="22px" Text="Enter a Phone Number" width="142px"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" Height="16px" OnTextChanged="txtFilter_TextChanged" style="margin-left: 25px" Width="159px"></asp:TextBox>
            <asp:Button ID="btnReturn1" runat="server" OnClick="btnReturn1_Click" style="z-index: 1; left: 344px; top: 397px; position: absolute; width: 160px; height: 26px" Text="Return to Main Menu" />
        </p>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" Height="26px" OnClick="btnClearFilter_Click" style="margin-left: 68px" Text="Clear Filter" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
