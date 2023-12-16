<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentViewGP.aspx.cs" Inherits="Database_M3.StudentViewGP" %>

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
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
