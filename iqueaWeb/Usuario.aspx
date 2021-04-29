<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="iqueaWeb.Formulario_web14" %>
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
        <asp:Button ID="Button3" runat="server" Text="Iniciar Sesion" PostBackUrl="~/Administrador.aspx" />
        &nbsp; <input id="Button2" type="button" value="Registrarse" /></p>
</asp:Content>
