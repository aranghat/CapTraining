<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IntroToStyles.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Home</h1>
            <h1 class="contactus">Hello World</h1>
            <asp:Label ID="Label1" 
                CssClass="contactus" 
                runat="server" Text="Label"></asp:Label>

            <asp:Button ID="Button1" 
                CssClass="btn btn-primary"
                runat="server" Text="Button" />
            <asp:TextBox ID="TextBox1" 
                CssClass="form-control"
                runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
