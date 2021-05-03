<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="CrearArticulo.aspx.cs" Inherits="iqueaWeb.Formulario_web18" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        <br />
        &nbsp;
        Identificador:
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>
&nbsp; Descripción:
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </p>
    <p>
&nbsp; Precio:
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </p>
    <p>
&nbsp; Url Imagen:
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    </p>
    <p>
&nbsp; Stock:
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
    </p>
    <p>
&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Crear" />
    </p>
</asp:Content>
