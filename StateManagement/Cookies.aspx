<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookies.aspx.cs" Inherits="StateManagement.Cookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Add A Note To Remind Me next time"></asp:Label>
            <asp:TextBox ID="txtRemindMe" runat="server"></asp:TextBox>
            <asp:Button ID="btnRememberThisNote" runat="server" Text="Button" OnClick="btnRememberThisNote_Click" />
        </div>
    </form>
</body>
</html>
