<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Lista_deseos.aspx.cs" Inherits="iqueaWeb.Lista_deseos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="centrar">Listas de deseos</h1>
    
    <div>
        <u><strong>Nombre de la lista 1</strong></u> <br />
        Número artículos
    </div>
    <div>
        <u><strong>Nombre de la lista 2</strong></u> <br />
        Número artículos
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Crear nueva lista" OnClick="Button1_Click" />
    </div>


</asp:Content>
