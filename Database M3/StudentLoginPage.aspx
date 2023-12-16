<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentLoginPage.aspx.cs" Inherits="Database_M3.StudentLoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter your credentials:"></asp:Label> <br />
            <br />
            ID:_____
            <asp:TextBox ID="id" runat="server"></asp:TextBox>
            <br/>
            Password:
            <asp:TextBox ID="password" runat="server"></asp:TextBox> <br /> <br />
            <asp:Button ID="bt_login" runat="server" Text="Login" OnClick="Bt_login_Click" />
         </div>
    </form>
</body>
</html>
