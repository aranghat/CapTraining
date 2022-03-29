<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BasicHtmlForms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="containerHtmlForm" runat="server">
                <h1>Student Details</h1>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                    ForeColor="Red" Font-Size="Smaller" Font-Bold="True" DisplayMode="List" />
            <asp:Panel ID="pnlGeneralDetails" GroupingText="General Details" runat="server">
                <div bordercolor="#CC0000">
                    <asp:Label runat="server" ID="lblFirstName" Text="First Name *"></asp:Label>
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="valFirstName" 
                        ForeColor="Red"
                        ControlToValidate="txtFirstName"
                        runat="server" 
                        Display="None"
                        ErrorMessage="First Name is Mandatory"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="valFristNameRegEx" 
                        runat="server" 
                        ControlToValidate="txtFirstName"
                        ForeColor="Red"
                        Display="None"
                        ValidationExpression="^[A-Za-z]+$"
                        ErrorMessage="First name must be only alphabets"></asp:RegularExpressionValidator>
                </div>
                <div style="margin-top: 10px;">
                    <asp:Label runat="server" ID="lblAge" Text="Age *"></asp:Label>
                    <asp:TextBox ID="txtAge" TextMode="Number" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="valAge" 
                        ForeColor="Red"
                        ControlToValidate="txtAge"
                        runat="server" ErrorMessage="Age is Mandatory"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" 
                        runat="server" 
                         ControlToValidate="txtAge"
                        ErrorMessage="Age Must be between 18-40" 
                        ForeColor="Red" 
                        MaximumValue="40" 
                        MinimumValue="18"></asp:RangeValidator>

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
             </asp:Panel>
            <asp:Panel ID="pnlAdditionalDetails" GroupingText="Additional Information" runat="server">
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
            </asp:Panel>
            <asp:Panel ID="pnlSecurityDetails" GroupingText="Security" runat="server">
                <div>
                    <label>Enter Password</label><br />
                    <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
                    <label>Confirm Password</label>
                    <asp:TextBox ID="txtConfirmPassword" TextMode="Password" runat="server">
                    </asp:TextBox>
                    <asp:CompareValidator ID="valComparepasswords"
                        ControlToCompare="txtConfirmPassword"
                        ControlToValidate ="txtPassword"
                        ForeColor="Red"
                        runat="server"      
                        ErrorMessage="Passwords Done Match"></asp:CompareValidator>
                </div>
                <div>
                    <label>Fav Sports</label>
                    <asp:TextBox ID="txtFavOutDoorSports" runat="server"></asp:TextBox>
                    <asp:CustomValidator ID="customValidator" 
                        runat="server" 
                        ForeColor ="Red"
                        ControlToValidate="txtFavOutDoorSports"
                        ErrorMessage="Invalid Outdoor Sports" 
                        OnServerValidate="customValidator_ServerValidate"></asp:CustomValidator>
                </div>
                <div>
                    <asp:Button ID="btnSaveStudentDetails" runat="server" Text="Save" OnClick="btnSaveStudentDetails_Click" />
                    <br />
                    <br />
                </div>
            </asp:Panel>
       </asp:Panel>
        <asp:Panel runat="server" ID="containerMessageBox" 
            BorderStyle="Solid" 
            BorderWidth="1" 
            BorderColor="#009900"
            Visible="false"
            >
            <asp:Label ID="lblMessageBox" 
                runat="server" 
                Text="Data has been saved sucessfully" 
                ForeColor="#009900"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
