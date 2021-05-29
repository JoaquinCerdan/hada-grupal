<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="BorrarCategoria.aspx.cs" Inherits="iqueaWeb.Formulario_web6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        <br />
    </p>
    <p>
        Nombre:
        <asp:TextBox ID="TextBox2" runat="server" MaxLength = "15"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Campo Obligatorio" forecolor="red" ControlToValidate="TextBox2">                 
                  </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID = "RegularExpressionValidator2" runat = "server"
        ControlToValidate = "TextBox2" ErrorMessage = "*Solo caracteres"
        ValidationExpression = "^ [a-zA-Z] {1,50} $" ValidationGroup =" a "> </asp:RegularExpressionValidator>
    </p>
    <p>
&nbsp;
        <asp:Button ID="Button1" runat="server" Class="btn btn-primary" Text="Borrar" />
    </p>
</asp:Content>
