﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="iqueaWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <p></p>
        <p>
            Correo:&nbsp;<asp:TextBox ID="Correo" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="CorreoRequired" runat="server" ErrorMessage="Tienes que introducir un correo." ControlToValidate="Correo" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </p>
        <p>
            Contraseña:&nbsp;<asp:TextBox ID="Contraseña1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="PasswordRequired1" runat="server" ErrorMessage="Tienes que introducir una contraseña." ControlToValidate="Contraseña1" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        
        </p>
        <p>
            Repetir Contraseña:&nbsp;<asp:TextBox ID="Contraseña2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="PasswordRequired2" runat="server" ErrorMessage="Tienes que introducir una contraseña." ControlToValidate="Contraseña2" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            
        </p>
        <p>Nombre:&nbsp;<asp:TextBox ID="Nombre" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="NombreRequired" runat="server" ErrorMessage="Tienes que introducir tu nombre." ControlToValidate="Nombre" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </p>
        <p>Dirección:&nbsp;<asp:TextBox ID="Direccion" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="DireccionRequired" runat="server" ErrorMessage="Tienes que introducir una direccion." ControlToValidate="Direccion" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </p>
        <p>Teléfono:&nbsp;<asp:TextBox ID="Telefono" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="TelefonoRequired" runat="server" ErrorMessage="Tienes que introducir un Teléfono." ControlToValidate="Telefono" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </p>
        <p>Numero Bancario:&nbsp;<asp:TextBox ID="Banco" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="BancoRequired" runat="server" ErrorMessage="Tienes que introducir una cuenta bancaria." ControlToValidate="Banco" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </p>

        &nbsp;&nbsp;&nbsp;<asp:Button ID="CrearUsuario" runat="server" Text="Registrar" OnClick="CrearUsuario_Click" />
        <asp:Label ID="etiqueta" runat="server" Text="Aviso"></asp:Label>

    </div>

</asp:Content>
