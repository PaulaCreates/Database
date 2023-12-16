<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentSendingCHRequest.aspx.cs" Inherits="Database_M3.StudentSendingCHRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Credit Hour Request Information:"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="ID:"></asp:Label>
            <asp:TextBox ID="student_id" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Credit Hours:"></asp:Label>
            <asp:TextBox ID="credit_hours" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Request type:"></asp:Label>
            <asp:TextBox ID="type" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="comment:"></asp:Label>
            <asp:TextBox ID="comment" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="bt_request" runat="server" Text="Request!" OnClick="Bt_request_Click"/>
            <br />
        </div>
    </form>
</body>
</html>
