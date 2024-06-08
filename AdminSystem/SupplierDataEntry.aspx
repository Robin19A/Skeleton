<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSupplierId" runat="server" style="z-index: 1; left: 5px; top: 14px; position: absolute; height: 23px; width: 75px;" Text="Supplier ID"></asp:Label>
            <asp:TextBox ID="txtSupplierId" runat="server" style="margin-left: 80px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Height="26px" OnClick="Button1_Click" style="margin-left: 42px" Text="Find" Width="83px" />
        </div>
        <p>
            <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 88px; top: 55px; position: absolute; width: 127px; height: 22px; margin-top: 0px; margin-bottom: 0px;"></asp:TextBox>
            <asp:Label ID="lblSupplierName" runat="server" style="z-index: 1; left: 0px; top: 52px; position: absolute; height: 42px; width: 69px" Text="SupplierName"></asp:Label>
        </p>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 10px; top: 95px; position: absolute; height: 21px" Text="Address" width="70px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" height="22px" style="z-index: 1; left: 88px; top: 91px; position: absolute; width: 127px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblPhone" runat="server" style="z-index: 1; left: 10px; top: 123px; position: absolute; height: 19px; right: 1080px" Text="Phone" width="70px"></asp:Label>
        <asp:TextBox ID="txtPhone" runat="server" style="z-index: 1; left: 88px; top: 124px; position: absolute; width: 127px; height: 22px"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 10px; top: 160px; position: absolute; height: 19px; right: 1082px" Text="Email" width="70px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 88px; top: 159px; position: absolute; width: 127px; height: 22px"></asp:TextBox>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 10px; top: 193px; position: absolute; height: 19px" Text="DateAdded" width="70px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 88px; top: 191px; position: absolute; height: 22px; width: 127px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 102px; top: 231px; position: absolute; height: 17px; width: 106px" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 261px; position: absolute; height: 20px; width: 45px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 13px; top: 304px; position: absolute; height: 30px; width: 40px" Text="OK" />
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 305px; position: absolute; width: 65px; height: 30px; right: 1010px; left: 79px" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="z-index: 1; left: 181px; top: 306px; position: absolute; height: 29px; width: 171px" Text="Return to Main Menu" />
        </p>
    </form>
</body>
</html>
