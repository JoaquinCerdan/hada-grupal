<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="ModificarAnuncio.aspx.cs" Inherits="iqueaWeb.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        &nbsp;ID del Anuncio:
        &nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
            runat="server" ErrorMessage=" *Campo Obligatorio" 
            forecolor="red" ControlToValidate="TextBox2">
        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
        ControlToValidate="TextBox2" runat="server"
        ErrorMessage=" *Solo números"
        ForeColor="Red"
        ValidationExpression="\d+">
        </asp:RegularExpressionValidator>
    </p>
    <p>
        &nbsp;Descripción del Anuncio:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
            runat="server" ErrorMessage=" *Campo Obligatorio" 
            forecolor="red" ControlToValidate="TextBox3">
        </asp:RequiredFieldValidator>
        &nbsp;</p>
    <p>
        &nbsp;Enlace del Anuncio:
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
            runat="server" ErrorMessage=" *Campo Obligatorio" 
            forecolor="red" ControlToValidate="TextBox4">
        </asp:RequiredFieldValidator>
    </p>
    <p>
        &nbsp;<asp:Button ID="Button1" Class="btn btn-primary" runat="server" Text="Modificar" OnClick="Button1_Click" />
        &nbsp;<asp:Label ID="Label1" runat="server" ></asp:Label>
    </p>
</asp:Content>
