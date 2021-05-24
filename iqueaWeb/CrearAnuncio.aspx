<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="CrearAnuncio.aspx.cs" Inherits="iqueaWeb.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
    &nbsp;Descripción del Anuncio:&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="Descripción" runat="server" ErrorMessage="*Campo Obligatorio" forecolor="red" ControlToValidate="TextBox2">                 
                  </asp:RequiredFieldValidator>
    </p>
&nbsp;Enlace del Anuncio:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Campo Obligatorio" forecolor="red" ControlToValidate="TextBox3">                 
                  </asp:RequiredFieldValidator>
    <br />
    <br />
&nbsp;<asp:Button ID="Button1" runat="server" Class="btn btn-primary" Text="Crear" />
&nbsp;
    <br />
    <br />
</asp:Content>
