<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormsView.aspx.cs" Inherits="DataControls.FormsView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FormView ID="FormView1" runat="server" AllowPaging="True" CssClass="table" DataKeyNames="CustomerId" DataSourceID="sqlCustomerDataSource">
                <EditItemTemplate>
                    CustomerId:
                    <asp:Label ID="CustomerIdLabel1" runat="server" Text='<%# Eval("CustomerId") %>' />
                    <br />
                    Name:
                    <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                    <br />
                    Email:
                    <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                    <br />
                    Address:
                    <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
                    <br />
                    Photo:
                    <asp:TextBox ID="PhotoTextBox" runat="server" Text='<%# Bind("Photo") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" CssClass="btn btn-sm btn-primary" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <InsertItemTemplate>
                    <div class="card m-4">
                        <div class="card-header">Add New Customer</div>
                        <div class="card-body">
                    <div class="mb-3">
                      <label for="NameTextBox" class="form-label">Name</label>
                      <asp:TextBox ID="NameTextBox" CssClass="form-control" runat="server" Text='<%# Bind("Name") %>' placeholder="Enter your name" />
                    </div>
                    
                    <br />
                    Email:
                    <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                    <br />
                    Address:
                    <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
                    <br />
                    Photo:
                    <asp:TextBox ID="PhotoTextBox" runat="server" Text='<%# Bind("Photo") %>' />
                    <br />
                    </div>
                        <div class="card-footer">
                            <asp:LinkButton ID="InsertButton" CssClass="btn btn-primary btn-sm" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                            <asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                        </div>
                    </div>
                </InsertItemTemplate>
                <ItemTemplate>
                    CustomerId:
                    <asp:Label ID="CustomerIdLabel" runat="server" Text='<%# Eval("CustomerId") %>' />
                    <br />
                    Name:
                    <asp:Label ID="NameLabel" runat="server" Text='<%# Bind("Name") %>' />
                    <br />
                    Email:
                    <asp:Label ID="EmailLabel" runat="server" Text='<%# Bind("Email") %>' />
                    <br />
                    Address:
                    <asp:Label ID="AddressLabel" runat="server" Text='<%# Bind("Address") %>' />
                    <br />
                    Photo:
                    <asp:Label ID="PhotoLabel" runat="server" Text='<%# Bind("Photo") %>' />
                    <br />
                    <div class="mt-3">
                    <asp:LinkButton ID="EditButton" CssClass="btn btn-sm btn-secondary" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                   <asp:LinkButton ID="DeleteButton" CssClass="btn btn-sm btn-danger" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                    <asp:LinkButton ID="NewButton" CssClass="btn btn-sm btn-primary" runat="server" CausesValidation="False" CommandName="New" Text="New" />
                    </div>

                         </ItemTemplate>
            </asp:FormView>
            <asp:SqlDataSource ID="sqlCustomerDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ecom_tempConnectionString %>" DeleteCommand="DELETE FROM [Customers] WHERE [CustomerId] = @CustomerId" InsertCommand="INSERT INTO [Customers] ([Name], [Email], [Address], [Photo]) VALUES (@Name, @Email, @Address, @Photo)" SelectCommand="SELECT [CustomerId], [Name], [Email], [Address], [Photo] FROM [Customers]" UpdateCommand="UPDATE [Customers] SET [Name] = @Name, [Email] = @Email, [Address] = @Address, [Photo] = @Photo WHERE [CustomerId] = @CustomerId">
                <DeleteParameters>
                    <asp:Parameter Name="CustomerId" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="Address" Type="String" />
                    <asp:Parameter Name="Photo" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="Address" Type="String" />
                    <asp:Parameter Name="Photo" Type="String" />
                    <asp:Parameter Name="CustomerId" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
