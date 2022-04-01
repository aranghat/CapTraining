<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepeaterView.aspx.cs" Inherits="DataControls.RepeaterView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
</head>
<body>
    <div class="container">
        <form id="form1" runat="server">
            
            <div class="p-5">
                <div class="row">
                <asp:Repeater ID="Repeater1" runat="server" DataSourceID="sqlDataSourceRepater">
                    <ItemTemplate>
                        <div class="col-4">
                                <div class="card shadow-sm mb-3" style="width:300px;">
                                    <img src="<%# Eval("Photo") %>" width="300" height="300" />
                                    <div class="card-body">
                                        <h5 class="card-title"><%# Eval("Name") %></h5>
                                        <div class="card-text">
                                            <strong>Bio</strong><br />
                                            Donec rutrum congue leo eget malesuada. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
                                            Quisque velit nisi, pretium ut lacinia in, 
                                            elementum id enim. Mauris blandit aliquet elit, 
                                        </div>
                                    </div>
                                    <div class="card-footer">
                                       Email : <%# Eval("Email") %>  | Address : <%# Eval("Address") %>
                                    </div>
                                </div> 
                            </div>
                    </ItemTemplate>
                </asp:Repeater>
                </div>
                <asp:SqlDataSource ID="sqlDataSourceRepater" runat="server" ConnectionString="<%$ ConnectionStrings:ecom_tempConnectionString %>" SelectCommand="SELECT [CustomerId], [Name], [Email], [Address], [Photo] FROM [Customers]"></asp:SqlDataSource>
            </div>
        </form>
    </div>
</body>
</html>
