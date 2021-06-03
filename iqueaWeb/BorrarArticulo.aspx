<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="BorrarArticulo.aspx.cs" Inherits="iqueaWeb.Formulario_web22" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        <br />
    </p>
    <p>
        &nbsp;
        Identificador:
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Campo Obligatorio" forecolor="red" ControlToValidate="TextBox4">                 
                  </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
        ControlToValidate="TextBox4" runat="server"
        ErrorMessage=" *Solo números"
        ForeColor="Red"
        ValidationExpression="\d+">
        </asp:RegularExpressionValidator>
    </p>
    <p>
&nbsp;
        <asp:Button ID="Button2" runat="server" Class="btn btn-primary" Text="Borrar" />
    </p>
</asp:Content>
