<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegisterFirstMakeup.aspx.cs" Inherits="Database_M3.StudentRegisterFirstMakeup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="studentID"></asp:Label>
            <asp:TextBox ID="student_id" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label2" runat="server" Text="courseID"></asp:Label>
            <asp:TextBox ID="course_id" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label3" runat="server" Text="student Current Semester"></asp:Label>
            <asp:TextBox ID="student_cur_sem" runat="server"></asp:TextBox>
            <br />

            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
        </div>
    </form>
</body>
</html>
