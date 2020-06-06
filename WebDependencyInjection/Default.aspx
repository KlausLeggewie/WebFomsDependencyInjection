<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebDependencyInjection._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Products</h1>
    </div>

    <div class="row">
        <div class="col-md-12">
            <h2>My favorite products :)</h2>
            <br />
            <p>
                <asp:Label runat="server" id="lbOrderMessage"/>
            </p>
            <asp:ListView runat="server" ID="lvProducts" ItemType="WebDependencyInjection.Repositories.Product"
                SelectMethod="Select"
                          OnItemCommand="lvProducts_OnItemCommand"
                          >
                <LayoutTemplate>
                    <table class="table table-hover table-striped">
                        <thead>
                            <tr class="d-flex">
                                <th class="col-2">Product #</th>
                                <th class="col-6">Name</th>
                                <th class="col-2 text-right">Price</th>
                                <th class="col-2">&nbsp;</th>
                            </tr>
                        </thead>
                        <tr runat="server" id="itemPlaceholder"></tr>
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr runat="server" class="d-flex">
                        <td class="col-2">
                            <%#: Item.ProductId %>
                        </td>
                        <td class="col-6">
                            <%#: Item.ProductName %>
                        </td>
                        <td class="col-2 text-right">
                            <%#: Item.Price %>
                        </td>
                        <td class="col-2">
                            <asp:Button ID="Button1" runat="server" CausesValidation="false" CommandName="Order"
                                Text="Order" CommandArgument="<%# Item.ProductId %>" />
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>

</asp:Content>
