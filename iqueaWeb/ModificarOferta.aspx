﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="ModificarOferta.aspx.cs" Inherits="iqueaWeb.Formulario_web3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        &nbsp;Código de la Oferta:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
            runat="server" ErrorMessage=" *Campo Obligatorio" 
            forecolor="red" ControlToValidate="TextBox2">
        </asp:RequiredFieldValidator>
        &nbsp;</p>
    <p>
        &nbsp;Descuento:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
            runat="server" ErrorMessage=" *Campo Obligatorio" 
            forecolor="red" ControlToValidate="TextBox3">
        </asp:RequiredFieldValidator>
    </p>
    <p>
        &nbsp;Fecha de Validez: &nbsp;<input id="date" type="date" value="0000-00-00"></p>
    <p>
        &nbsp;<asp:Button ID="Button1" runat="server" Text="Modificar" />
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
