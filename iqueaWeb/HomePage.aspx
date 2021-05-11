<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="iqueaWeb.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="HomePage.css">
        <asp:Menu ID="Menu1" runat="server" OnMenuItemClick="Menu1_MenuItemClick1" StaticSubMenuIndent="40px" BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98">
        <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <DynamicMenuStyle BackColor="#B5C7DE" />
        <DynamicSelectedStyle BackColor="#507CD1" />
        <Items>
            <asp:MenuItem Text="Categorias" Value="Categorias">
                <asp:MenuItem Text="Exterior" Value="Exterior" NavigateUrl="~/Exterior.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Interior" Value="Nuevo elemento" NavigateUrl="~/Interior.aspx"></asp:MenuItem>
                <asp:MenuItem Text="etc..." Value="Nuevo elemento" NavigateUrl="~/etc.aspx"></asp:MenuItem>
            </asp:MenuItem>
        </Items>
        <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <StaticSelectedStyle BackColor="#507CD1" />
    </asp:Menu>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
      <footer class ="footer"> 
              <p>Bienvenido</p>
      </footer>
    <center>
    <h1>Lo ultimo de la temporada</h1>
        <p>Descubre el conjunto de articulos de los diferentes salones solo haciendo un clik!</p>
        </center>
    <div class ="slider">
    <center>
          <asp:ImageButton ID="ImageButton4" runat="server" Height="244px" ImageUrl="https://casaydiseno.com/wp-content/uploads/2016/05/biblioteca-peque%C3%B1a-salon-monimalista.jpg" ImageAlign="Left" Width="296px" />
          <asp:ImageButton ID="ImageButton1" runat="server" Height="244px" ImageUrl="https://casaydiseno.com/wp-content/uploads/2016/05/bibliotecas-modernas-compartimentos-salon.jpg" ImageAlign="Right" style="margin-left: 0px" Width="278px" />
          <asp:ImageButton ID="ImageButton2" runat="server" Height="244px" ImageUrl="https://casaydiseno.com/wp-content/uploads/2016/05/bonita.deco_.estilo.retro_.jpg" ImageAlign="Middle" Width="299px" />
        </center>
     </div>
    <div class="final">
    <h2>El producto mas vendidos</h2>
    <br />
        <asp:ImageButton ID="ImageButton3" runat="server" Height="207px" ImageUrl="https://www.muebleselparaiso.es/102171-large_default/sofa-cama-de-3-plazas-tessa.jpg"  Width="299px" PostBackUrl="~/Articulo.aspx" />
    </div>
    <div class="final2">
        <h2>El producto mejor valorado</h2>
    <br />
        <asp:ImageButton ID="ImageButton5" runat="server" Height="206px" ImageUrl="https://www.muebleselparaiso.es/102171-large_default/sofa-cama-de-3-plazas-tessa.jpg"  Width="299px" PostBackUrl="~/Articulo.aspx" />
    </div>
    <div class="oferta">
        <h2>Y la mejor oferta!</h2>
        <asp:ImageButton ID="ImageButton6" runat="server" Height="201px" ImageUrl="https://www.muebleselparaiso.es/102171-large_default/sofa-cama-de-3-plazas-tessa.jpg"  Width="299px" PostBackUrl="~/Articulo.aspx" />
    </div>
    <div class="arreglo">
        Antes 190€<br />
        Ahora 149!!!!
    </div>
    <br />
    
    
    

</asp:Content>
