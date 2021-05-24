<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="iqueaWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <p></p>
        <p>
            Correo:&nbsp;<asp:TextBox ID="Correo" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="CorreoRequired" runat="server" ErrorMessage="Tienes que introducir un correo." ControlToValidate="Correo" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionCorreo" runat="server" ErrorMessage="Los datos dados no son un email." ControlToValidate="Correo" ForeColor="#CC0000" ValidationExpression="/^(([^<>()\[\]\.,;:\s@\”]+(\.[^<>()\[\]\.,;:\s@\”]+)*)|(\”.+\”))@(([^<>()[\]\.,;:\s@\”]+\.)+[^<>()[\]\.,;:\s@\”]{2,})$/"></asp:RegularExpressionValidator>
        </p>
        <p>
            Contraseña:&nbsp;<asp:TextBox ID="Contraseña1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="PasswordRequired1" runat="server" ErrorMessage="Tienes que introducir una contraseña." ControlToValidate="Contraseña1" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;<asp:RangeValidator ID="RangePassword1" runat="server" ErrorMessage="La contraseña tiene que tener entre 8 y 20 dígitos." ForeColor="#CC0000" ControlToValidate="Contraseña1" MinimumValue="20" MaximumValue="8"></asp:RangeValidator>
        </p>
        <p>
            Repetir Contraseña:&nbsp;<asp:TextBox ID="Contraseña2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="PasswordRequired2" runat="server" ErrorMessage="Tienes que introducir una contraseña." ControlToValidate="Contraseña2" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;<asp:RangeValidator ID="RangePassword2" runat="server" ErrorMessage="La contraseña tiene que tener entre 8 y 20 dígitos." ForeColor="#CC0000" ControlToValidate="Contraseña2" MaximumValue="8" MinimumValue="20"></asp:RangeValidator>
        </p>
        <p>Nombre:&nbsp;<asp:TextBox ID="Nombre" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="NombreRequired" runat="server" ErrorMessage="Tienes que introducir tu nombre." ControlToValidate="Nombre" ForeColor="#CC0000"></asp:RequiredFieldValidator></p>
        <p>Dirección:&nbsp;<asp:TextBox ID="Direccion" runat="server"></asp:TextBox>(No necesario)</p>
        <p>Teléfono:&nbsp;<asp:TextBox ID="Telefono" runat="server"></asp:TextBox>(No necesario)</p>
        <p>Numero Bancario:&nbsp;<asp:TextBox ID="Banco" runat="server"></asp:TextBox>(No necesario)</p>

        &nbsp;&nbsp;&nbsp;<asp:Button ID="CrearUsuario" runat="server" Text="Registrar" />

    </div>

</asp:Content>
