<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentDataEntry.aspx.cs" Inherits="PaymentDataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payment Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">

        <div>

            <asp:Label ID="lblPaymentID" runat="server" Text="Payment ID"></asp:Label>
            <asp:TextBox ID="txtPaymentID" runat="server"></asp:TextBox>

            <br />
            <br />

            <asp:Button ID="btnFind"
                runat="server"
                Text="Find"
                OnClick="btnFind_Click" />

            <br />
            <br />

            <asp:Label ID="lblMemberID" runat="server" Text="Member ID"></asp:Label>
            <asp:TextBox ID="txtMemberID" runat="server"></asp:TextBox>

            <br />
            <br />

            <asp:Label ID="lblAmount" runat="server" Text="Amount"></asp:Label>
            <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>

            <br />
            <br />

            <asp:Label ID="lblPaymentDate" runat="server" Text="Payment Date"></asp:Label>
            <asp:TextBox ID="txtPaymentDate" runat="server"></asp:TextBox>

            <br />
            <br />

            <asp:Label ID="lblPaymentMethod" runat="server" Text="Payment Method"></asp:Label>
            <asp:TextBox ID="txtPaymentMethod" runat="server"></asp:TextBox>

            <br />
            <br />

            <asp:Button ID="btnOK"
                runat="server"
                Text="OK"
                OnClick="btnOK_Click" />

            <br />
            <br />

            <asp:Label ID="lblError"
                runat="server"
                ForeColor="Red">
            </asp:Label>

        </div>

    </form>
</body>
</html>