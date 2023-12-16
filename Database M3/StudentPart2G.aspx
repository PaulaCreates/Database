<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentPart2G.aspx.cs" Inherits="Database_M3.Part2G" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Course ID"></asp:Label>
            <asp:TextBox ID="course_id" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Instructor ID"></asp:Label>
            <asp:TextBox ID="instructor_id" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
            <br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
