<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="ModificarCategoria.aspx.cs" Inherits="iqueaWeb.Formulario_web5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        <br />
    </p>
    <p>
        Nombre:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
            runat="server" ErrorMessage=" *Campo Obligatorio" 
            forecolor="red" ControlToValidate="TextBox2">
        </asp:RequiredFieldValidator>
    </p>
    <p>
        Descripción:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
            runat="server" ErrorMessage=" *Campo Obligatorio" 
            forecolor="red" ControlToValidate="TextBox3">
        </asp:RequiredFieldValidator>
    </p>
    <p>
&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Modificar" />
    </p>
</asp:Content>
