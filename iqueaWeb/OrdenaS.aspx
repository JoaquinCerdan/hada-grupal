﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OrdenaS.aspx.cs" Inherits="iqueaWeb.OrdenarS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h1>Muebles de salón tipo sencillo</h1>
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
        <asp:Button ID="Ordenar" runat="server" PostBackUrl="~/OrdenaS.aspx" Text="Ordenar" />
            
    </div>
     <br />
    Productos disponibles:<br />
    <br />
     <center>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="https://i.ibb.co/VYcx7pX/Articulo-sofa-sencillo-sin-marca-de-agua.png" Height="164px" Width="279px" ImageAlign="Left" PostBackUrl="Articulo.aspx" />
            <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/6/a/1/4/6a14dc460b3700644830b77108556eb6792cb4f1_CLPMAS004SMK_UK_Masako_Chandelier_Pendant_Light_Smoked_Opal_Glass_ar3_2_LB02_LS.jpg" Height="164px" Width="279px" ImageAlign="Right" PostBackUrl="Articulo.aspx" />
            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="https://static.westwingnow.de/image/upload//simple/74/932/1324021.jpg" Height="164px" Width="279px" ImageAlign="Middle" PostBackUrl="Articulo.aspx" />
     </center>
    <br />
    <center>
        <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/f/f/0/f/ff0f5e39a00db5658e47de29b63938b289dd1779_FLPCHI011ZSI_UK_Chicago_Tripod_Floor_Lamp_Black_and_Silver_ar3_2_LB02_LS.jpg" Height="160px" style="margin-left: 0px; margin-top: 0px" Width="290px" PostBackUrl="Articulo.aspx" />
    </center>
</asp:Content>