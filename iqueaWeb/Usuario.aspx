﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="iqueaWeb.Formulario_web14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center><h1>Tu perfil</h1></center>
    <div>
         Nombre de usuario <asp:TextBox ID="TextBox1" runat="server" Width="114px" Enabled="False"></asp:TextBox>
    </div>
    <br />
    <div>
         Email <asp:TextBox ID="TextBox2" runat="server" Width="203px" Enabled="False"></asp:TextBox>
    </div>
    <br />
    <div>
         Contraseña <asp:TextBox ID="TextBox3" runat="server" Width="167px" Enabled="False"></asp:TextBox> 
    </div>
    <br />
    <div>
         Cuenta bancaria <asp:TextBox ID="TextBox4" runat="server" Width="137px" Enabled="False"></asp:TextBox>
    </div>
    <br />
    <div>
         Dirección <asp:TextBox ID="TextBox5" runat="server" Width="175px" Enabled="False"></asp:TextBox>
    </div>
    <br />
    <div>
         Número de teléfono <asp:TextBox ID="TextBox6" runat="server" Width="108px" Enabled="False"></asp:TextBox>
    </div>

    <br /> 
    <center><asp:Button ID="Button" runat="server" Text="Modificar todo" OnClick="Button_Click" /></center>
    <div>
    <center><asp:Button ID="Button1" runat="server" Text="Borrar usuario" OnClick="Button_Click1" /></center>
    </div>
</asp:Content>
