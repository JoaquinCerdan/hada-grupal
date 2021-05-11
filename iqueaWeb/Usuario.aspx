<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="iqueaWeb.Formulario_web14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center><h1>Tu perfil</h1></center>
    <div>
         Nombre de usuario <asp:TextBox ID="TextBox1" runat="server" Width="114px"></asp:TextBox>  <asp:Button ID="Button1" runat="server" Text="Modificar" />
    </div>
    <br />
    <div>
         Email <asp:TextBox ID="TextBox4" runat="server" Width="203px"></asp:TextBox>  <asp:Button ID="Button4" runat="server" Text="Modificar" />
    </div>
    <br />
    <div>
         Contraseña <asp:TextBox ID="TextBox5" runat="server" Width="167px"></asp:TextBox>  <asp:Button ID="Button5" runat="server" Text="Modificar" />
    </div>
    <br />
    <div>
         Cuenta bancaria <asp:TextBox ID="TextBox2" runat="server" Width="137px"></asp:TextBox>  <asp:Button ID="Button2" runat="server" Text="Modificar" />
    </div>
    <br />
    <div>
         Ciudad <asp:TextBox ID="TextBox6" runat="server" Width="189px"></asp:TextBox>  <asp:Button ID="Button6" runat="server" Text="Modificar" />
    </div>
    <br />
    <div>
         Dirección <asp:TextBox ID="TextBox3" runat="server" Width="175px"></asp:TextBox>  <asp:Button ID="Button3" runat="server" Text="Modificar" />
    </div>
    <br />
    <div>
         Número de teléfono <asp:TextBox ID="TextBox7" runat="server" Width="108px"></asp:TextBox>  <asp:Button ID="Button7" runat="server" Text="Modificar" />
    </div>
    <br /> <br />
    <center><asp:Button ID="Button8" runat="server" Text="Modificar todo" /></center>
</asp:Content>
