<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="CrearAnuncio.aspx.cs" Inherits="iqueaWeb.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
    &nbsp;Descripción del Anuncio:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
&nbsp;Enlace del Anuncio:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <br />
&nbsp;<asp:Button ID="Button1" runat="server" Text="Crear" />
&nbsp;
</asp:Content>
