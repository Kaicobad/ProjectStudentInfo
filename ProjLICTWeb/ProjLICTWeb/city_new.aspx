<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="city_new.aspx.cs" Inherits="ProjLICTWeb.city_new" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
    <br />
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <asp:Label ID="lbleName" runat="server" Font-Bold="True" Font-Italic="True" Font-Overline="False" ForeColor="Red"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
</asp:Content>
