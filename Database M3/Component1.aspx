<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Component1.aspx.cs" Inherits="Database_M3.Component1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label3" runat="server" Text="Component1"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="C) Add telephone numbers"></asp:Label>
            <asp:Button ID="Button3" runat="server" Text="Go" OnClick="Button3_Click"/>
            <br />
            <asp:Label ID="Label5" runat="server" Text="D) View all optional courses in the current semester"></asp:Label>
            <asp:Button ID="Button4" runat="server" Text="Go" OnClick="Button4_Click"/>
            <br />
            <asp:Label ID="Label6" runat="server" Text="E) View all available courses in the current semester"></asp:Label>
            <asp:Button ID="Button5" runat="server" Text="Go" OnClick="Button5_Click"/>
            <br />
            <asp:Label ID="Label1" runat="server" Text="F) View the required courses within the current semester"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Go" OnClick="Button6_Click"/>
            <br />
            <asp:Label ID="Label7" runat="server" Text="G) View the missing courses"></asp:Label>
            <asp:Button ID="Button6" runat="server" Text="Go" OnClick="Button7_Click"/>
            <br />
            <asp:Label ID="Label8" runat="server" Text="H) Send a course request"></asp:Label>
            <asp:Button ID="Button7" runat="server" Text="Go" OnClick="Button8_Click"/>
            <br />
            <asp:Label ID="Label9" runat="server" Text="I) Send a credit hour request "></asp:Label>
            <asp:Button ID="Button8" runat="server" Text="Go" OnClick="Button9_Click"/>
            <br />
        </div>
    </form>
</body>
</html>
