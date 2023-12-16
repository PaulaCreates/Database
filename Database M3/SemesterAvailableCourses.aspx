<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SemesterAvailableCourses.aspx.cs" Inherits="Database_M3.SemesterAvailableCourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="SemesterCode"></asp:Label>
            <asp:TextBox ID="CurSemCode" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="confirm" runat="server" Text="Confirm!" OnClick="confirm_Click"/>
            <br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
