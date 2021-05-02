<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="ModificarOferta.aspx.cs" Inherits="iqueaWeb.Formulario_web3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        &nbsp;Código de la Oferta:
        <input id="Text1" type="text" />&nbsp;</p>
    <p>
        &nbsp;Descuento:
        <input id="Text2" type="text" /></p>
    <p>
        &nbsp;Fecha de Validez: &nbsp;<input id="date" type="date" value="0000-00-00"></p>
    <p>
        &nbsp;<input id="Button1" type="button" value="Modificar" style="font-weight: 700" />&nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
