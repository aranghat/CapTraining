<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataGrid.aspx.cs" Inherits="DataControls.DataGrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="card m-4 shadow-sm">
            <div class="card-header">Customer List</div>
            <div class="card-body p-0">
                 <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="CustomerId" DataSourceID="sqlCustomerDataSource" PageSize="5" CssClass="table table-striped">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <img src="<%# Eval("Photo") %>" class="img-thumbnail border-1 rounded-4" 
                                width="64" height="64" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="CustomerId" HeaderText="CustomerId" InsertVisible="False" ReadOnly="True" SortExpression="CustomerId" Visible="False" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                </Columns>
            </asp:GridView>
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
        </div>
    </form>
</body>
</html>
