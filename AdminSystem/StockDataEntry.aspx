<%@ Page Language="C#" AutoEventWireup="true" CodeFile="STOCKDataEntry.aspx.cs" Inherits="STOCKDataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 462px;
            left: 76px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 397px;
            left: 249px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="lblProductID" runat="server" Text="ProductID"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtProductID" runat="server" Width="170px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" Width="44px" />
            <br />
            <br />
        </div>
        <div>
            <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
        </div>
        <div>
            <br />
            <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <div>
            <asp:Label ID="lblDateAdded" runat="server" Text="DateAdded"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
            <br />
        </div>
        <div>
            <br />
            <asp:Label ID="lblSupplierID" runat="server" Text="SupplierID"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txtSupplierID" runat="server"></asp:TextBox>
        &nbsp;<br />
            <br />
        </div>
        <div>
            <asp:Label ID="lblUnitPrice" runat="server" Text="UnitPrice"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUnitPrice" runat="server"></asp:TextBox>
            <br />
        </div>
        <div>
            &nbsp;&nbsp;&nbsp;
            &nbsp;<br />
        </div>
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
            <br />
            <br />
        </div>
        <div>
            <asp:Button ID="btnOk" runat="server" Text="OK" OnClick="btnOk_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblError" runat="server" CssClass="auto-style1" ForeColor="Red"></asp:Label>
            <asp:Button ID="btnMainMenu" runat="server" CssClass="auto-style2" OnClick="btnMainMenu_Click" style="z-index: 1" Text="MainMenu" />
        </div>
    </form>
</body>
</html>
