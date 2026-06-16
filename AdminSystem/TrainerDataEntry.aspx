<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TrainerDataEntry.aspx.cs" Inherits="TrainerDataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trainer Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">

        <div>

            <asp:Label ID="lblTrainerID" runat="server" Text="Trainer ID"></asp:Label>
            <asp:TextBox ID="txtTrainerID" runat="server"></asp:TextBox>

            <br /><br />

            <asp:Button ID="btnFind"
                runat="server"
                Text="Find"
                OnClick="btnFind_Click" />

            <br /><br />

            <asp:Label ID="lblFullName" runat="server" Text="Full Name"></asp:Label>
            <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>

            <br /><br />

            <asp:Label ID="lblSpecialty" runat="server" Text="Specialty"></asp:Label>
            <asp:TextBox ID="txtSpecialty" runat="server"></asp:TextBox>

            <br /><br />

            <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number"></asp:Label>
            <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>

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