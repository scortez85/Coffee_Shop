<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Management.aspx.cs" Inherits="Pages_Management" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h3 style="list-style-type: none">
        <li><a ID="productList" runat="server" href="~/Pages/Management?id=1" style="list-style-type: none; list-style-image: none; color: #686868; float: left; width: 250px;">Product Inventory</a></li>       
        <li><a ID="customerList" runat="server" href="~/Pages/Management?id=2" style="list-style-type: none; list-style-image: none; color: #686868; float: left; width: 200px;">Customers</a></li>       
        <li><a ID="salesList" runat="server" href="~/Pages/Management?id=3" style="list-style-type: none; list-style-image: none; color: #686868; float: left; width: 200px;">Sales</a></li>       
        <br /><br />

    </h3>
    <asp:Panel ID="PnlData" runat="server"></asp:Panel>
    
</asp:Content>

