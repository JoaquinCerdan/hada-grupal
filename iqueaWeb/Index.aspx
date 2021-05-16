<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="iqueaWeb.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="mystyle.css">
    <br />
 
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
          <asp:ImageButton ID="ImageButton4" runat="server" Height="244px" ImageUrl="https://casaydiseno.com/wp-content/uploads/2016/05/biblioteca-peque%C3%B1a-salon-monimalista.jpg" ImageAlign="Left" Width="296px" PostBackUrl="~/Sencillo.aspx" />
          <asp:ImageButton ID="ImageButton1" runat="server" Height="244px" ImageUrl="https://casaydiseno.com/wp-content/uploads/2016/05/bibliotecas-modernas-compartimentos-salon.jpg" ImageAlign="Right" style="margin-left: 0px" Width="278px" PostBackUrl="~/Moderno.aspx" />
          <asp:ImageButton ID="ImageButton2" runat="server" Height="244px" ImageUrl="https://casaydiseno.com/wp-content/uploads/2016/05/bonita.deco_.estilo.retro_.jpg" ImageAlign="Middle" Width="299px" PostBackUrl="~/Clasico.aspx" />
        </center>
     </div>
    <div class="final">
    <h2>El producto mas vendido</h2>
    <br />
        <asp:ImageButton ID="ImageButton3" runat="server" Height="207px" ImageUrl="https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/c/a/c/e/cacec5195cad86b692ae2b804bbd62bb3f41903a_FLPSWE007BLA_UK_Sweep_Arc_Overreach_Floor_Lamp_Matt_Black_Copper_ar3_2_LB02_LS.jpg"  Width="299px" PostBackUrl="~/Articulo.aspx" />
    </div>
    <div class="final2">
        <h2>El producto mejor valorado</h2>
    <br />
        <asp:ImageButton ID="ImageButton5" runat="server" Height="206px" ImageUrl="https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/f/f/0/f/ff0f5e39a00db5658e47de29b63938b289dd1779_FLPCHI011ZSI_UK_Chicago_Tripod_Floor_Lamp_Black_and_Silver_ar3_2_LB02_LS.jpg"  Width="299px" PostBackUrl="~/Articulo.aspx" />
    </div>
    <div class="oferta">
        <h2>Y la mejor oferta!</h2>
        <asp:ImageButton ID="ImageButton6" runat="server" Height="201px" ImageUrl="https://st01.ventamueblesonline.es/58096-thickbox_default/composicion-de-salon-argos-twin-sable.jpg"  Width="299px" PostBackUrl="~/Articulo.aspx" />
    </div>
    <div class="arreglo">
        Antes 1900€<br />
        Ahora 1490!!!!
    </div>
    <br />
    
    
    

</asp:Content>
