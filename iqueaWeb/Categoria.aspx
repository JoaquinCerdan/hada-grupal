<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Categoria.aspx.cs" Inherits="iqueaWeb.Categoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Menu ID="Menu1" runat="server" OnMenuItemClick="Menu1_MenuItemClick1" StaticSubMenuIndent="40px" BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98">
        <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <DynamicMenuStyle BackColor="#B5C7DE" />
        <DynamicSelectedStyle BackColor="#507CD1" />
        <Items>
            <asp:MenuItem Text="Categorias" Value="Categorias">
                <asp:MenuItem Text="Exterior" Value="Exterior" NavigateUrl="~/Exterior.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Interior" Value="Nuevo elemento" NavigateUrl="~/Interior.aspx"></asp:MenuItem>
                <asp:MenuItem Text="ext..." Value="Nuevo elemento" NavigateUrl="~/ext.aspx"></asp:MenuItem>
            </asp:MenuItem>
        </Items>
        <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <StaticSelectedStyle BackColor="#507CD1" />
    </asp:Menu>
    <br />
    <br />
    <br />
</asp:Content>
