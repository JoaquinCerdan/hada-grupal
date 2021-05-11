<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Pedido.aspx.cs" Inherits="iqueaWeb.Pedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <div>
        <strong style="height: 33px; width: 129px">1 Dirección de envio</strong>
        <div class ="centrar">
            Nombre del usuario <br />
            Calle del usuario <br />
            Piso del usuario <br />
            Ciudad del usuario
        </div>
    </div>

    <div>
        <strong  style="width: 127px">2 Método de pago</strong>
         <div class ="centrar">
            Tarjeta del usuario <br />
            Añadir un cheque de regalo o código promocional <br />
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             &nbsp;<asp:Button ID="Button2" runat="server" Text="Aplicar" />
           
        </div>
    </div>

    <div>    
        <strong style="width: 248px">3 Revisar productos y opciones de envío</strong>
        <div class ="centrar">
            Nombre del producto (ID producto) <br />
            Precio del producto <br />
           
        </div>
    </div>
   
    <div class ="centrar">
     
        <br /> <asp:Button ID="Button1" runat="server" Text="Comprar ahora" style="text-align: center" />   &nbsp;   Precio total
        <br />
        <br />
    </div>

</asp:Content>


