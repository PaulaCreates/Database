<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OptionalCourses.aspx.cs" Inherits="Database_M3.OptionalCourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="id" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label2" runat="server" Text="CurrentSemesterCode"></asp:Label>
            <asp:TextBox ID="currentSemCode" runat="server"></asp:TextBox>
            <br />
            
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />
            
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
