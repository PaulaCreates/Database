<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentUpcomingInstallment.aspx.cs" Inherits="Database_M3.StudentUpcomingInstallment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="StudentID"></asp:Label>
            <asp:TextBox ID="student_id" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
            <br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
