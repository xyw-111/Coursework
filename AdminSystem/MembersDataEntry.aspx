<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MembersDataEntry.aspx.cs" Inherits="MembersDataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Member Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">

        <div>

            <!-- Member ID -->
            <asp:Label ID="lblMemberID" runat="server" Text="Member ID"></asp:Label>
            <asp:TextBox ID="txtMemberID" runat="server"></asp:TextBox>

            <br /><br />

            <!-- Find button -->
            <asp:Button ID="btnFind"
                runat="server"
                Text="Find"
                OnClick="btnFind_Click" />

            <br /><br />

            <!-- First Name -->
            <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>

            <br /><br />

            <!-- Last Name -->
            <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>

            <br /><br />

            <!-- Phone Number -->
            <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number"></asp:Label>
            <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>

            <br /><br />

            <!-- Email -->
            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>

            <br /><br />

            <!-- Date Joined -->
            <asp:Label ID="lblDateJoined" runat="server" Text="Date Joined"></asp:Label>
            <asp:TextBox ID="txtDateJoined" runat="server"></asp:TextBox>

            <br /><br />

            <!-- Membership Plan ID -->
            <asp:Label ID="lblMembershipPlanID" runat="server" Text="Membership Plan ID"></asp:Label>
            <asp:TextBox ID="txtMembershipPlanID" runat="server"></asp:TextBox>

            <br /><br />

            <!-- OK Button -->
            <asp:Button ID="btnOK"
                runat="server"
                Text="OK"
                OnClick="btnOK_Click" />

            &nbsp;

            <!-- Cancel Button -->
            <asp:Button ID="btnCancel"
                runat="server"
                Text="Cancel" />

            <br /><br />

            <!-- Error Message Label -->
            <asp:Label ID="lblError"
                runat="server"
                ForeColor="Red"></asp:Label>

        </div>

    </form>
</body>
</html>