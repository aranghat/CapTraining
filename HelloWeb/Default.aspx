<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HelloWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMessage" runat="server" Text="Hello Web" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="txtSampleMessage" runat="server" ForeColor="Blue"></asp:TextBox>
            <asp:Button ID="btnChangeTheMessage" runat="server" 
                Text="Click to Change the Message" 
                OnClick="btnChangeTheMessage_Click" />
        </div>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lblPostBackMessage" runat="server" ForeColor="Red" Text="Label"></asp:Label>
    </form>
</body>
</html>
