<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="ModificarArticulo.aspx.cs" Inherits="iqueaWeb.Formulario_web4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        <br />
    </p>
    <p>
        &nbsp;
        Identificador:
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
            runat="server" ErrorMessage=" *Campo Obligatorio" 
            forecolor="red" ControlToValidate="TextBox4">
        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
        ControlToValidate="TextBox4" runat="server"
        ErrorMessage=" *Solo números"
        ForeColor="Red"
        ValidationExpression="\d+">
        </asp:RegularExpressionValidator>
    </p>
    <p>
&nbsp; Descripción:
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
            runat="server" ErrorMessage=" *Campo Obligatorio" 
            forecolor="red" ControlToValidate="TextBox5">
        </asp:RequiredFieldValidator>
    </p>
    <p>
&nbsp; Precio:
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" 
            runat="server" ErrorMessage=" *Campo Obligatorio" 
            forecolor="red" ControlToValidate="TextBox6">
        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
        ControlToValidate="TextBox6" runat="server"
        ErrorMessage=" *Solo números"
        ForeColor="Red"
        ValidationExpression="\d+">
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
    </p>
    <p>
&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Modificar" />
    </p>
</asp:Content>
