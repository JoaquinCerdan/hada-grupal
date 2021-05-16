﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OrdenaM.aspx.cs" Inherits="iqueaWeb.OrdenarM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h1>Muebles de salón tipo moderno</h1>
    </center>
    
    
    
    <div>  
        <p>Ordenar por:</p>

        <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal">
        <asp:ListItem>Precio</asp:ListItem>
        <asp:ListItem>Valoracion</asp:ListItem>
        <asp:ListItem>Nombre</asp:ListItem>
        <asp:ListItem>Popularidad</asp:ListItem>
    </asp:CheckBoxList>
        <p>Tipo de mueble : 
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Todos</asp:ListItem>
            <asp:ListItem>Sofa</asp:ListItem>
            <asp:ListItem>Silla</asp:ListItem>
            <asp:ListItem>Mesa</asp:ListItem>
        </asp:DropDownList>
            </p>
        <p>Color : <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>Cualquiera</asp:ListItem>
            <asp:ListItem>Rojo</asp:ListItem>
            <asp:ListItem>Amarillo</asp:ListItem>
            <asp:ListItem>Azul</asp:ListItem>
            <asp:ListItem>Verde</asp:ListItem>
            <asp:ListItem>Morado</asp:ListItem>
            <asp:ListItem>Naranja</asp:ListItem>
        </asp:DropDownList>
            </p>
        <asp:Button ID="Ordenar" runat="server" PostBackUrl="~/OrdenaM.aspx" Text="Ordenar" />
            
    </div>
     <br />
    Productos disponibles:<br />
    <br />
    <center>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="https://static.westwingnow.de/image/upload//simple/81/5511/1186712.jpg" Height="164px" Width="279px" ImageAlign="Left" PostBackUrl="Articulo.aspx" />
            <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="https://medias.maisonsdumonde.com/image/upload/q_auto,f_auto/w_1000/img/sofa-de-2-3-plazas-de-terciopelo-azul-1000-9-30-188097_9.jpg" Height="164px" Width="279px" ImageAlign="Right" PostBackUrl="Articulo.aspx" />
            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="https://www.muebledesign.com/img/cms/mesa-noguche-coffe-mueble-design.jpg" Height="164px" Width="279px" ImageAlign="Middle" PostBackUrl="Articulo.aspx" />
    </center>
    <br />
    <center>
        <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/c/a/c/e/cacec5195cad86b692ae2b804bbd62bb3f41903a_FLPSWE007BLA_UK_Sweep_Arc_Overreach_Floor_Lamp_Matt_Black_Copper_ar3_2_LB02_LS.jpg" Height="160px" style="margin-left: 0px; margin-top: 0px" Width="290px" PostBackUrl="Articulo.aspx" />
    </center>
</asp:Content>
