<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            text-align: left;
        }
        .auto-style3 {
            text-align: left;
            margin-bottom: 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div class="auto-style2" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 27px; width: 1814px">
        </div>
        <asp:Label ID="IbIProductID" runat="server" style="z-index: 1; left: 3px; top: 55px; position: absolute; height: 27px; width: 131px; bottom: 329px;" Text="Product ID"></asp:Label>
        <p style="height: 30px" class="auto-style2">
            <asp:TextBox ID="txtProductID" runat="server" OnTextChanged="txtProductID_TextChanged" style="z-index: 1; left: 152px; top: 41px; position: absolute; right: 1543px; height: 38px" width="131px"></asp:TextBox>
        </p>
        <p class="auto-style2">
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 154px; top: 105px; position: absolute; width: 131px; height: 35px; margin-top: 0px"></asp:TextBox>
        </p>
        <p style="height: 7px; width: 12px; margin-bottom: 0px">
            <asp:Label ID="ProductName" runat="server" style="z-index: 1; left: 5px; position: absolute; top: 115px; height: 33px; width: 131px" Text="Name"></asp:Label>
            <asp:Label ID="TEXT" runat="server" height="27px" style="z-index: 1; left: 2px; top: 186px; position: absolute; margin-top: 0px" Text="Description" width="131px"></asp:Label>
        </p>
        <p style="height: 30px; margin-bottom: 0px">
            &nbsp;</p>
            <p style="height: 7px; width: 12px; margin-bottom: 0px">
            <asp:TextBox ID="txtDescription" runat="server" height="35px" style="z-index: 1; left: 154px; top: 179px; position: absolute" width="131px"></asp:TextBox>
        </p>
        <asp:Label ID="Date" runat="server" height="27px" style="z-index: 1; left: 1px; top: 255px; position: absolute" Text="DateAdded	" width="131px"></asp:Label>
        <asp:TextBox ID="Dateadded" runat="server" height="35px" style="z-index: 1; left: 153px; top: 246px; position: absolute" width="131px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p class="auto-style2" style="z-index: 1; left: 25px; top: 291px; position: absolute; height: 27px; width: 1814px">
            <asp:TextBox ID="Decimal" runat="server" height="41px" OnTextChanged="Decimal_TextChanged" style="z-index: 1; top: 63px; position: absolute; left: 125px; width: 131px"></asp:TextBox>
        </p>
        <p class="auto-style3">
            <asp:TextBox ID="IbISupplierID" runat="server" height="35px" style="z-index: 1; left: 151px; top: 307px; position: absolute; margin-bottom: 19px" width="131px"></asp:TextBox>
        </p>
        <p style="z-index: 1; left: 10px; top: 333px; position: absolute; height: 27px; width: 131px">
            <asp:Label ID="ID" runat="server" style="z-index: 1; left: -8px; top: -12px; position: absolute; height: 27px" Text="SupplierID" width="1814px"></asp:Label>
        </p>
        <asp:Label ID="boolean" runat="server" style="z-index: 1; left: 5px; position: absolute; width: 131px; top: 431px; height: 27px" Text="Available"></asp:Label>
        <asp:TextBox ID="Available" runat="server" height="35px" style="z-index: 1; left: 148px; top: 424px; position: absolute" width="131px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 175px; top: 486px; position: absolute" Text="Active" width="122px" />
            <asp:Label ID="Price" runat="server" style="z-index: 1; left: 5px; top: 374px; position: absolute; height: 59px" Text="UnitPrice" width="131px"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 17px; top: 585px; position: absolute; height: 60px; width: 122px" Text="OK" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 196px; top: 584px; position: absolute; height: 60px; width: 122px" Text="Cancel" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 539px; position: absolute" width="122px"></asp:Label>
        </p>
        </div>
    </form>
</body>
</html>
