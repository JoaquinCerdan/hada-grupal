<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="ModificarAnuncio.aspx.cs" Inherits="iqueaWeb.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        &nbsp;ID del Anuncio:
        &nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;Descripción del Anuncio:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        &nbsp;</p>
    <p>
        &nbsp;Enlace del Anuncio:
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;<asp:Button ID="Button1" runat="server" Text="Modificar" />
        &nbsp;</p>
</asp:Content>
