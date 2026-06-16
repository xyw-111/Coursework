<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MembershipPlanList.aspx.cs" Inherits="MembershipPlanList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Membership Plan List</title>
</head>
<body>
    <form id="form1" runat="server">

        <div>

            <asp:ListBox ID="lstMembershipPlans"
                runat="server"
                Height="300px"
                Width="450px">
            </asp:ListBox>

            <br /><br />

            <asp:Button ID="btnAdd"
                runat="server"
                Text="Add"
                OnClick="btnAdd_Click" />

            <asp:Button ID="btnEdit"
                runat="server"
                Text="Edit"
                OnClick="btnEdit_Click" />

            <asp:Button ID="btnDelete"
                runat="server"
                Text="Delete"
                OnClick="btnDelete_Click" />

        </div>

    </form>
</body>
</html>