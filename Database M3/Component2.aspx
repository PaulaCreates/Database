<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Component2.aspx.cs" Inherits="Database_M3.Component2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label3" runat="server" Text="Component2"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="A) View graduation plan along with assigned courses"></asp:Label>
            <asp:Button ID="Button3" runat="server" Text="Go" OnClick="Button3_Click"/>
            <br />
            <asp:Label ID="Label5" runat="server" Text="B) View the upcoming not paid installment"></asp:Label>
            <asp:Button ID="Button4" runat="server" Text="Go" OnClick="Button4_Click"/>
            <br />
            <asp:Label ID="Label6" runat="server" Text="C) View all courses along with their exams details"></asp:Label>
            <asp:Button ID="Button5" runat="server" Text="Go" OnClick="Button5_Click"/>
            <br />
            <asp:Label ID="Label7" runat="server" Text="D) Register for first makeup exam"></asp:Label>
            <asp:Button ID="Button6" runat="server" Text="Go" OnClick="Button6_Click"/>
            <br />
            <asp:Label ID="Label8" runat="server" Text="E) Register for second makeup exam"></asp:Label>
            <asp:Button ID="Button7" runat="server" Text="Go" OnClick="Button7_Click"/>
            <br />
            <asp:Label ID="Label9" runat="server" Text="F) View all courses along with their corresponding slots details and instructors"></asp:Label>
            <asp:Button ID="Button8" runat="server" Text="Go" OnClick="Button8_Click"/>
            <br />
            <asp:Label ID="Label1" runat="server" Text="G) View the slots of a certain course that is taught by a certain instructor"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Go" OnClick="Button9_Click"/>
            <br />
            <asp:Label ID="Label2" runat="server" Text="H) Choose the instructor for a certain course "></asp:Label>
            <asp:Button ID="Button2" runat="server" Text="Go" OnClick="Button10_Click"/>
            <br />
            <asp:Label ID="Label10" runat="server" Text="I) View all details of all courses with their prerequisites"></asp:Label>
            <asp:Button ID="Button9" runat="server" Text="Go" OnClick="Button11_Click"/>
            <br />
        </div>
    </form>
</body>
</html>
