<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 37px;
            left: 10px;
            z-index: 1;
            width: 394px;
            height: 314px;
        }
        .auto-style2 {
            position: absolute;
            top: 376px;
            left: 14px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 379px;
            left: 118px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 378px;
            left: 258px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 440px;
            left: 10px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 439px;
            left: 191px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 504px;
            left: 54px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 506px;
            left: 251px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 382px;
            left: 391px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 465px;
            left: 461px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnDelete" runat="server" CssClass="auto-style4" OnClick="btnDelete_Click" Text="Delete" />
        <asp:Button ID="btnClearFilter" runat="server" CssClass="auto-style8" OnClick="btnClearFilter_Click" Text="Clear Filter" />
        <asp:Button ID="btnMainMenu" runat="server" CssClass="auto-style9" OnClick="btnMainMenu_Click" Text="MainMenu" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style10" ForeColor="#FF3300"></asp:Label>
        <asp:ListBox ID="lstProductList" runat="server" CssClass="auto-style1"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style2" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" CssClass="auto-style3" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Label ID="lblName" runat="server" CssClass="auto-style5" Text="Enter Product Name"></asp:Label>
        <asp:TextBox ID="txtProductName" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" CssClass="auto-style7" OnClick="btnApplyFilter_Click" Text="Apply Filter" />
    </form>
</body>
</html>
