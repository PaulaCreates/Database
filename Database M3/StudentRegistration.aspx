<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegistration.aspx.cs" Inherits="Database_M3.StudentRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter your information here:"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="First Name:"></asp:Label>
            <asp:TextBox ID="first_name" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Last Name:"></asp:Label>
            <asp:TextBox ID="last_name" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Faculty:"></asp:Label>
            <asp:TextBox ID="faculty" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Major:"></asp:Label>
            <asp:TextBox ID="major" runat="server"></asp:TextBox>            
            <br />
            <asp:Label ID="Label8" runat="server" Text="Semester:"></asp:Label>
            <asp:TextBox ID="semester" runat="server"></asp:TextBox>
            <br/>
            <asp:Button ID="bt_register" runat="server" Text="Register!" OnClick="Bt_register_Click"/>
            <br />
            <asp:Label ID="student_id" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
