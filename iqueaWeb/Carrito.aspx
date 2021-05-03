<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="iqueaWeb.Formulario_web17" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <asp:CheckBoxList ID="CheckBoxList1" runat="server" style="text-align: justify" Width="1126px">
        <asp:ListItem>Sofa ejemplo - 125€</asp:ListItem>
        <asp:ListItem>Sillon Electrico - 200€</asp:ListItem>
        <asp:ListItem>Cama de matrimonio - 225€</asp:ListItem>
        <asp:ListItem>Lampara de noche - 19,99€</asp:ListItem>
    </asp:CheckBoxList> 
    <p>
            </p>
    &nbsp; 
    <asp:Button ID="Button3" runat="server" Text="Vaciar" />
    &nbsp; 
    <asp:Button ID="Button4" runat="server" Text="Comprar" />
&nbsp;<p>
            </p>
</asp:Content>