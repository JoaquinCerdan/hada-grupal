<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Comentar.aspx.cs" Inherits="iqueaWeb.Comentar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>
        <strong>&nbsp;&nbsp;<asp:Label ID="enunciado_comentario" runat="server" Text="Comentario:"></asp:Label></strong>
        <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="ComentarioRequired" runat="server" ErrorMessage="Tienes que introducir un comentario." ControlToValidate="TextBox2" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    </p>
    <p>
        <strong>&nbsp;&nbsp;<asp:Label ID="enunciado_valoracion" runat="server" Text="Valoración:"></asp:Label></strong>
        <asp:DropDownList ID="Valoracion"  style="margin-bottom:10px; width:10%; height:40px;"  AutoPostBack="true" runat="server">
                        
                <asp:ListItem Value="1"> 1 </asp:ListItem>
                <asp:ListItem Value="2"> 2 </asp:ListItem>
                <asp:ListItem Value="3"> 3 </asp:ListItem>
                <asp:ListItem Value="4"> 4 </asp:ListItem>
                <asp:ListItem Value="5"> 5 </asp:ListItem>

        </asp:DropDownList>
    </p>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Crear" runat="server" Text="Crear el comentario" style="border-style: groove; border-width: 1px" OnClick="Comentar_Click" />&nbsp;&nbsp;
    

</asp:Content>
