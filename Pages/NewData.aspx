<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="NewData.aspx.cs" Inherits="Pages_NewData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2><br />Enter Name</h2>
    <div>
        <asp:TextBox ID="SearchBox" runat="server"></asp:TextBox>
        <asp:Button ID="subButton" runat="server" Text="Submit" OnClick="subButton_Click" />
    </div>
    
    <div>
        <asp:Label ID="lblResults" runat="server" Text=""></asp:Label>
        <br />
    </div>
</asp:Content>

