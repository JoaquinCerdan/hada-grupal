<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="iqueaWeb.Modificar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>Contraseña:&nbsp;<asp:TextBox ID="Contraseña1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="PasswordRequired1" runat="server" ErrorMessage="Tienes que introducir una contraseña." ControlToValidate="Contraseña1" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    </p>
    <p>Nombre:&nbsp;<asp:TextBox ID="Nombre" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="NombreRequired" runat="server" ErrorMessage="Tienes que introducir tu nombre." ControlToValidate="Nombre" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </p>
        <p>Dirección:&nbsp;<asp:TextBox ID="Direccion" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="DireccionRequired" runat="server" ErrorMessage="Tienes que introducir una direccion." ControlToValidate="Direccion" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </p>
        <p>Teléfono:&nbsp;<asp:TextBox ID="Telefono" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="TelefonoRequired" runat="server" ErrorMessage="Tienes que introducir un Teléfono." ControlToValidate="Telefono" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="Telefono" ValidationExpression="(\d{9})" runat="server" ErrorMessage="Formato incorrecto del teléfono (Tienen que ser 9 números)"></asp:RegularExpressionValidator>
        </p>
        <p>Numero Bancario:&nbsp;ES<asp:TextBox ID="Banco" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="BancoRequired" runat="server" ErrorMessage="Tienes que introducir una cuenta bancaria." ControlToValidate="Banco" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ControlToValidate="Banco" ValidationExpression="(\d{22})" runat="server" ErrorMessage="Formato incorrecto de cuenta bancaria (Ej:1212341234121234567890) "></asp:RegularExpressionValidator>
        
        </p>
    <br /> <br />
    <center><asp:Button ID="Button" runat="server" Text="Aceptar Cambios" OnClick="Button_Click" /></center>
</asp:Content>
