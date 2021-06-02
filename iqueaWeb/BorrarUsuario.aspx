<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="BorrarUsuario.aspx.cs" Inherits="iqueaWeb.Formulario_web21" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        &nbsp;Email del Usuario: &nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
            runat="server" ErrorMessage=" *Campo Obligatorio" 
            forecolor="red" ControlToValidate="TextBox2">
        </asp:RequiredFieldValidator>
    <p>
        &nbsp;<asp:Button ID="Button1" runat="server" Text="Borrar" CssClass="btn btn-primary" OnClick="Button1_Click" />
        &nbsp;</p>
</asp:Content>
