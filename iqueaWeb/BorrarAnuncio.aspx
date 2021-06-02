<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="BorrarAnuncio.aspx.cs" Inherits="iqueaWeb.BorrarAnuncio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        &nbsp;
        ID del anuncio:
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Campo Obligatorio" forecolor="red" ControlToValidate="TextBox9">                 
                  </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
        ControlToValidate="TextBox9" runat="server"
        ErrorMessage=" *Solo números"
        ForeColor="Red"
        ValidationExpression="\d+">
        </asp:RegularExpressionValidator>
    </p>
    <p>
        &nbsp;
        <asp:Button ID="Button3" runat="server" Class="btn btn-primary" Text="Borrar" />
    </p>
</asp:Content>
