<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="iqueaWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <p style="text-align: center">
        Nombre de Usuario:
        <input id="Text1" type="text" /></p>
    <p style="text-align: center">
        Contraseña:
        <input id="Text2" type="text" /></p>
    <p style="text-align: center">
        <asp:Button ID="Button1" runat="server" Text="Iniciar como Administrador" PostBackUrl="~/Administrador.aspx" />
        &nbsp; <asp:Button ID="Button2" runat="server" Text="Iniciar Sesion" PostBackUrl="~/Usuario.aspx" />
        &nbsp; <input id="Button3" type="button" value="Registrarse" /></p>
</asp:Content>
