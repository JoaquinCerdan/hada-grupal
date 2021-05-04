<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="CrearOferta.aspx.cs" Inherits="iqueaWeb.Formulario_web15" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        &nbsp;Código de Oferta:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;Descuento:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;Fecha de Validez: &nbsp;<input id="date" type="date" value="0000-00-00"></p>
    <p>
        &nbsp;<asp:Button ID="Button1" runat="server" Text="Crear" />
        &nbsp;</p>
    &nbsp;</asp:Content>
