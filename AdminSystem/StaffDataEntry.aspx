<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 20px; width: 409px">
    <form id="form1" runat="server">
        <p>
            <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 111px; top: 48px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 12px; top: 50px; position: absolute; bottom: 596px" Text="StaffId"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 12px; top: 90px; position: absolute" Text="Name" width="41px"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 111px; top: 87px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 111px; top: 126px; position: absolute" width="128px"></asp:TextBox>
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 12px; top: 129px; position: absolute" Text="Email" width="41px"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 12px; top: 191px; position: absolute" Text="DateOfBirth" width="41px"></asp:Label>
        <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 111px; top: 189px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblGender" runat="server" style="z-index: 1; left: 12px; top: 219px; position: absolute" Text="Gender" width="41px"></asp:Label>
        <asp:TextBox ID="txtGender" runat="server" style="z-index: 1; left: 111px; top: 219px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 12px; top: 249px; position: absolute" Text="Address" width="41px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 111px; top: 246px; position: absolute" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 23px; top: 293px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 28px; top: 345px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 22px; top: 393px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 123px; top: 392px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
