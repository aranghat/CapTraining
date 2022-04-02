<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginBasics.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Login</h1>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label ID="lblMessage" ForeColor="Red" runat="server" Text=""></asp:Label>
            </div>
            <div>
                <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
           </div>
            <div>
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
           </div>
            <div>
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </div>
        </div>
    </form>
</body>
</html>
