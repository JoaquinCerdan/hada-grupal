<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="CrearCategoria.aspx.cs" Inherits="iqueaWeb.Formulario_web31" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        <br />
        Nombre:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Descripción:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Crear" />
    </p>
</asp:Content>
