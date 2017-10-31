<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="Pages_Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    <div>
    <asp:Label ID="searchLbl" runat="server" Text="Product Name"></asp:Label>
    </div>

    <div>
    <asp:TextBox ID="searchTxt" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Search" />
    </div>
    
    <asp:Panel ID="PnlData" runat="server"></asp:Panel>
</asp:Content>

