<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MembershipPlanDataEntry.aspx.cs" Inherits="MembershipPlanDataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Membership Plan Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">

        <div>

            <asp:Label ID="lblMembershipPlanID" runat="server" Text="Membership Plan ID"></asp:Label>
            <asp:TextBox ID="txtMembershipPlanID" runat="server"></asp:TextBox>

            <br /><br />

            <asp:Button ID="btnFind"
                runat="server"
                Text="Find"
                OnClick="btnFind_Click" />

            <br /><br />

            <asp:Label ID="lblPlanName" runat="server" Text="Plan Name"></asp:Label>
            <asp:TextBox ID="txtPlanName" runat="server"></asp:TextBox>

            <br /><br />

            <asp:Label ID="lblDuration" runat="server" Text="Duration"></asp:Label>
            <asp:TextBox ID="txtDuration" runat="server"></asp:TextBox>

            <br /><br />

            <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>

            <br /><br />

            <asp:Button ID="btnOK"
                runat="server"
                Text="OK"
                OnClick="btnOK_Click" />

            <br /><br />

            <asp:Label ID="lblError"
                runat="server"
                ForeColor="Red">
            </asp:Label>

        </div>

    </form>
</body>
</html>