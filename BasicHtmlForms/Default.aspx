<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BasicHtmlForms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Student Details</h1>
        <div>
            <asp:Label runat="server" ID="lblFirstName" Text="First Name"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        </div>
        <div style="margin-top: 10px;">
            <asp:Label runat="server" ID="lblAge" Text="Age"></asp:Label>
            <asp:TextBox ID="txtAge" TextMode="Number" runat="server"></asp:TextBox>
        </div>
        <div style="margin-top: 10px;">
        <asp:Label runat="server" ID="lblGender" Text="Gender"></asp:Label>
            <asp:DropDownList ID="ddlGender"  runat="server">
                <asp:ListItem Text="Select Gender" Value="Select Gender"></asp:ListItem>
                <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                <asp:ListItem Text="Others" Value="Others"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div style="margin-top: 10px;">
            <asp:Label runat="server" ID="lblSelectSeat" Text="Seat Type"></asp:Label>
            <asp:RadioButton ID="rdoMerit" GroupName="SeatType" runat="server" /> Merit
            <asp:RadioButton ID="rdoManagement" GroupName="SeatType" runat="server" /> Management
        </div>
        <div style="margin-top: 10px;">
            <asp:Label runat="server" ID="Label1" Text="Languages"></asp:Label>
            <asp:CheckBox ID="chkEnglish" runat="server" /> English
            <asp:CheckBox ID="chkHindi" runat="server" /> Hindi
            <asp:CheckBox ID="chkFrench" runat="server" /> French
            <asp:CheckBox ID="chkGerman" runat="server" /> German
        </div>
        <div>
        <asp:Label runat="server" ID="Label2" Text="Choice of City"></asp:Label>
            <asp:ListBox ID="lbChoiceOfLocation" SelectionMode="Multiple" runat="server">
                <asp:ListItem Text="Mumbai" Value="Mumbai"></asp:ListItem>
                <asp:ListItem Text="Bangalore" Value="Bangalore"></asp:ListItem>
                <asp:ListItem Text="Chennei" Value="Chennei"></asp:ListItem>
                <asp:ListItem Text="Trivandrum" Value="Trivandrum"></asp:ListItem>
                <asp:ListItem Text="Kolkata" Value="Kolkata"></asp:ListItem>
                <asp:ListItem Text="Kochi" Value="Kochi"></asp:ListItem>
            </asp:ListBox>
        </div>
        <div>
            <asp:Button ID="btnSaveStudentDetails" runat="server" Text="Save" OnClick="btnSaveStudentDetails_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
