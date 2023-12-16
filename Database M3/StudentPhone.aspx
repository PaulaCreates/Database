<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentPhone.aspx.cs" Inherits="Database_M3.StudentPhone" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="label1" runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="id" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="label2" runat="server" Text="phone"></asp:Label>
            <asp:TextBox ID="phone" runat="server"></asp:TextBox>
            <br />


            <asp:Button ID="Confirm" runat="server" Text="Button" OnClick="Bt_Confirm" />
        </div>
    </form>
</body>
</html>
