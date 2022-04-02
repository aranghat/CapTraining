<%@ Page Language="C#" 
    EnableViewState="true" 
    EnableViewStateMac="true" 
    AutoEventWireup="true" 
    CodeBehind="Default.aspx.cs" 
    Inherits="StateManagement.Default"
    ViewStateMode="Enabled" 
    ViewStateEncryptionMode="Always" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblServerTime" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblShowPageVisitCount" runat="server" Text=""></asp:Label>

            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
