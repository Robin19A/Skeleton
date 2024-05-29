<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 253px">
    &nbsp;<form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 11px; top: 35px; position: absolute; right: 1316px" Text="Order ID"></asp:Label>
        <asp:TextBox ID="txtShippingAddress" runat="server" Height="17px" OnTextChanged="txtOrderId_TextChanged" style="z-index: 1; left: 143px; top: 192px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 11px; top: 66px; position: absolute" Text="Customer ID"></asp:Label>
        <p>
            <asp:TextBox ID="txtCustomerId" runat="server" Height="17px" style="z-index: 1; left: 144px; top: 61px; position: absolute; height: 19px"></asp:TextBox>
        </p>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 10px; top: 97px; position: absolute" Text="Order Date"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" Height="17px" style="z-index: 1; left: 144px; top: 95px; position: absolute; margin-top: 0px"></asp:TextBox>
        <asp:Label ID="lblDeliveredStatus" runat="server" style="z-index: 1; left: 10px; top: 130px; position: absolute" Text="Delivered Status"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblTotalAmount" runat="server" style="z-index: 1; left: 11px; top: 162px; position: absolute; bottom: 547px;" Text="Total Amount"></asp:Label>
        <asp:Label ID="lblShippingAddress" runat="server" style="z-index: 1; left: 12px; top: 194px; position: absolute" Text="Shipping Address"></asp:Label>
        <p>
            &nbsp;</p>
        <p style="height: 44px">
            <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 11px; top: 225px; position: absolute" Text="Staff ID"></asp:Label>
        </p>
        <p style="height: 36px">
            <asp:TextBox ID="txtOrderId" runat="server" Height="17px" OnTextChanged="txtOrderId_TextChanged" style="z-index: 1; left: 144px; top: 32px; position: absolute"></asp:TextBox>
            <asp:CheckBox ID="chkComplete" runat="server" style="z-index: 1; left: 139px; top: 250px; position: absolute" Text="Complete" />
        </p>
        <asp:TextBox ID="txtDeliveredStatus" runat="server" Height="17px" style="z-index: 1; left: 144px; top: 129px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtTotalAmount" runat="server" style="z-index: 1; left: 144px; top: 161px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 143px; top: 222px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 22px; top: 281px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 23px; top: 315px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 77px; top: 315px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
