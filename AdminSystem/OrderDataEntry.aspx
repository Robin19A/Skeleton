<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 253px">
    &nbsp;<form id="form1" runat="server">
        <div>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; top: 32px; position: absolute; right: 1023px; height: 26px;" Text="Find" Width="60px" />
        </div>
        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 10px; top: 35px; position: absolute; right: 1342px" Text="Order ID"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" Height="17px" OnTextChanged="txtOrderId_TextChanged" style="z-index: 1; left: 143px; top: 192px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 11px; top: 66px; position: absolute" Text="Customer ID"></asp:Label>
        <p>
            <asp:TextBox ID="txtCustomerId" runat="server" Height="17px" style="z-index: 1; left: 144px; top: 61px; position: absolute; height: 19px"></asp:TextBox>
        </p>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 10px; top: 97px; position: absolute" Text="Order Date"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" Height="17px" style="z-index: 1; left: 144px; top: 95px; position: absolute; margin-top: 0px"></asp:TextBox>
        <asp:Label ID="lblTotalAmount" runat="server" style="z-index: 1; left: 10px; top: 130px; position: absolute; right: 1338px;" Text="Total Amount"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblShippingAddress" runat="server" style="z-index: 1; left: 11px; top: 162px; position: absolute; bottom: 533px;" Text="Shipping Address"></asp:Label>
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 12px; top: 194px; position: absolute" Text="Staff ID"></asp:Label>
        <p>
            &nbsp;</p>
        <p style="height: 44px">
            &nbsp;</p>
        <p style="height: 36px">
            <asp:TextBox ID="txtOrderId" runat="server" Height="17px" OnTextChanged="txtOrderId_TextChanged" style="z-index: 1; left: 144px; top: 32px; position: absolute"></asp:TextBox>
            <asp:CheckBox ID="chkDeliveryStatus" runat="server" style="z-index: 1; left: 139px; top: 250px; position: absolute" Text="Delivery Status" />
        </p>
        <asp:TextBox ID="txtTotalAmount" runat="server" Height="17px" style="z-index: 1; left: 144px; top: 129px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtShippingAddress" runat="server" style="z-index: 1; left: 144px; top: 161px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 11px; top: 286px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 315px; position: absolute" Text="OK" Width="60px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 113px; top: 314px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
