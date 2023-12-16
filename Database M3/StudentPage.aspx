<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentPage.aspx.cs" Inherits="Database_M3.StudentPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Hello student"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Component 1"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Go" OnClick="Button1_Click"/>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Component 2"></asp:Label>
            <asp:Button ID="Button2" runat="server" Text="Go" OnClick="Button2_Click"/>
            <br />
        </div>
    </form>
</body>
</html>
