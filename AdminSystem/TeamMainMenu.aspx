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
            left: 267px;
            z-index: 1;
            width: 116px;
        }
    </style>
</head>
<body style="height: 219px; width: 745px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style1" Font-Size="20pt" Text="Team Main Menu"></asp:Label>
        </p>
        <asp:Button ID="btnStock" runat="server" CssClass="auto-style2" OnClick="btnStock_Click" Text="Stock Management" />
        <p>
       
        <p>
            <asp:Button ID="btnStaffManagement" runat="server" OnClick="btnStaffManagement_Click" style="z-index: 1; left: 94px; top: 129px; position: absolute" Text="Staff Management" />
        </p>
        <p>
            <asp:Button ID="btnOrder" runat="server" OnClick="btnOrder_Click" style="z-index: 1; left: 538px; top: 129px; position: absolute; width: 79px" Text="Order" />
            <asp:Button ID="btnCustomer" runat="server" OnClick="btnCustomer_Click" style="z-index: 1; left: 649px; top: 129px; position: absolute" Text="Customer" />
        </p>
        <asp:Button ID="btnSupplier" runat="server" OnClick="btnSupplier_Click" style="z-index: 1; left: 416px; top: 130px; position: absolute; width: 89px; right: 165px" Text="Supplier" />
    </form>
</body>
</html>
