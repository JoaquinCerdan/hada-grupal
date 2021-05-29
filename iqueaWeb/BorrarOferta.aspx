<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="BorrarOferta.aspx.cs" Inherits="iqueaWeb.Formulario_web2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        &nbsp;Codigo de la Oferta:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Campo Obligatorio" forecolor="red" ControlToValidate="TextBox2">                 
                  </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
        ControlToValidate="TextBox2" runat="server"
        ErrorMessage=" *Solo números"
        ForeColor="Red"
        ValidationExpression="\d+">
        </asp:RegularExpressionValidator>
    <p>
        &nbsp;<asp:Button ID="Button1" Class="btn btn-primary"  runat="server" Text="Borrar" />
        &nbsp;</p>
</asp:Content>
