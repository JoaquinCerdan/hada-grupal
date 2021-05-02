<%@ Page Title="" Language="C#" MasterPageFile="~/Carrito.master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="iqueaWeb.Formulario_web17" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <asp:CheckBoxList ID="CheckBoxList1" runat="server" style="text-align: justify" Width="1126px">
        <asp:ListItem>Sofa ejemplo</asp:ListItem>
        <asp:ListItem>Sillon Electrico</asp:ListItem>
        <asp:ListItem>Cama de matrimonio</asp:ListItem>
        <asp:ListItem>Lampara de noche</asp:ListItem>
    </asp:CheckBoxList> 
    <p>
            </p>
    &nbsp; 
    <input id="Button1" type="button" value="Vaciar" />&nbsp; 
    <input id="Button2" type="button" value="Comprar" />
    <p>
            </p>
</asp:Content>