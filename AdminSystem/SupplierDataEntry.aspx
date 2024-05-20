<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSupplierId" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Supplier ID"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 88px; top: 15px; position: absolute; width: 142px"></asp:TextBox>
        </div>
        <p>
            SupplierName<asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 105px; top: 53px; position: absolute; width: 132px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
