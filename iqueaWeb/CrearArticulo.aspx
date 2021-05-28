<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="CrearArticulo.aspx.cs" Inherits="iqueaWeb.Formulario_web18" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
&nbsp; Descripción:
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
            runat="server" ErrorMessage=" *Campo Obligatorio" 
            forecolor="red" ControlToValidate="TextBox5">
        </asp:RequiredFieldValidator>
    </p>
    <p>
&nbsp; Precio:
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
            runat="server" ErrorMessage=" *Campo Obligatorio" 
            forecolor="red" ControlToValidate="TextBox6">
        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
        ControlToValidate="TextBox6" runat="server"
        ErrorMessage=" *Solo números"
        ForeColor="Red"
        ValidationExpression="((\d+)((\,\d{1,2})?))$">
        </asp:RegularExpressionValidator>
    </p>
    <p>
&nbsp; Url Imagen:
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
            runat="server" ErrorMessage=" *Campo Obligatorio" 
            forecolor="red" ControlToValidate="TextBox7">
        </asp:RequiredFieldValidator>
    </p>
    <p>
&nbsp; Stock:
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
            runat="server" ErrorMessage=" *Campo Obligatorio" 
            forecolor="red" ControlToValidate="TextBox8">
        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
        ControlToValidate="TextBox8" runat="server"
        ErrorMessage=" *Solo números"
        ForeColor="Red"
        ValidationExpression="\d+">
        </asp:RegularExpressionValidator>
    </p>
    <p>
&nbsp;
        <asp:Button ID="Button2" Class="btn btn-primary" runat="server" Text="Crear" OnClick="Button2_Click" />
    </p>
</asp:Content>
