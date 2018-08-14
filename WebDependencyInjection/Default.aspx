<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebDependencyInjection._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Products</h1>
    </div>

    <div class="row">
        <div class="col-md-12">
            <h2>Look at my favorite products :)</h2>
            <br/>

            <asp:GridView runat="server" ID="grdProdcuts" ItemType="WebDependencyInjection.Repositories.Product"
                          SelectMethod="Select" 
                          CssClass="table table-hover table-striped" 
                          UseAccessibleHeader="True"
                          UseGridLines="None"
                          >
            </asp:GridView>
        </div>
    </div>

</asp:Content>
