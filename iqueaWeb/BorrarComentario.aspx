<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="BorrarComentario.aspx.cs" Inherits="iqueaWeb.Formulario_web16" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        &nbsp;ID del Comentario:
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Campo Obligatorio" forecolor="red" ControlToValidate="TextBox9">                 
                  </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
        ControlToValidate="TextBox9" runat="server"
        ErrorMessage=" *Solo números"
        ForeColor="Red"
        ValidationExpression="\d+">
        </asp:RegularExpressionValidator>
    <p>
        &nbsp;<asp:Button ID="Button3" Class="btn btn-primary"  runat="server" Text="Borrar" />
        &nbsp;</p>
</asp:Content>
