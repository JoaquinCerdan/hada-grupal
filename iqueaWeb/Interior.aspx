<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Interior.aspx.cs" Inherits="iqueaWeb.Interior" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h1>Muebles de Interior</h1>
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
        <asp:Button ID="Ordenar" runat="server" PostBackUrl="~/OrdenaI.aspx" Text="Ordenar" />
            
    </div>

    <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" ShowHeader="False" Width="256px" HorizontalAlign="Center" OnRowCommand="GridView_RowCommand1" OnSelectedIndexChanged="GridView_SelectedIndexChanged">
        <Columns>
            <asp:ButtonField DataTextField="Nombre" Text="Botón_nombre" CommandName="id" >
            <FooterStyle HorizontalAlign="Center" />
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:ButtonField>
            <asp:ImageField DataImageUrlField="Imagen" HeaderText="Imagen">
                <FooterStyle HorizontalAlign="Center" />
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:ImageField>
        </Columns>
    </asp:GridView>

    <!--
    <div>
        <center><p><asp:Image ID="Image2" ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/Estrella_roja.svg/400px-Estrella_roja.svg.png" runat="server" Height="21px" Width="23px" />El producto estrella<asp:Image ID="Image1" ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/Estrella_roja.svg/400px-Estrella_roja.svg.png" runat="server" Height="21px" Width="23px" />
            </p></center>
        <center><asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/f/f/0/f/ff0f5e39a00db5658e47de29b63938b289dd1779_FLPCHI011ZSI_UK_Chicago_Tripod_Floor_Lamp_Black_and_Silver_ar3_2_LB02_LS.jpg" Height="160px" style="margin-left: 0px; margin-top: 0px" Width="290px" PostBackUrl="Articulo.aspx" />
        <br />
        Sofá cama 3 plazas, gris<br />
             Valoracion : <asp:Image ID="Image3" ImageUrl="http://assets.stickpng.com/thumbs/58738756f3a71010b5e8ef44.png" runat="server" Height="29px" Width="80px"></asp:Image> <br />
        Precio normal 190 €<br />
        Oferta: 149€<br />
        </center>
    </div>
     <br />
    Los productos mas destacados de la temporada:<br />
    <br />
        <center>
            <asp:ImageButton ID="ImageButton11" runat="server" ImageUrl="https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/f/f/0/f/ff0f5e39a00db5658e47de29b63938b289dd1779_FLPCHI011ZSI_UK_Chicago_Tripod_Floor_Lamp_Black_and_Silver_ar3_2_LB02_LS.jpg" Height="164px" Width="279px" ImageAlign="Left" PostBackUrl="Articulo.aspx" />
            <asp:ImageButton ID="ImageButton12" runat="server" ImageUrl="https://pictureserver.net/images/pic/d9/76/undef_src_sa_picid_749405_x_1800_type_color_image.jpg?ver=14" Height="164px" Width="279px" ImageAlign="Right" PostBackUrl="Articulo.aspx" />
            <asp:ImageButton ID="ImageButton13" runat="server" ImageUrl="https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/c/a/c/e/cacec5195cad86b692ae2b804bbd62bb3f41903a_FLPSWE007BLA_UK_Sweep_Arc_Overreach_Floor_Lamp_Matt_Black_Copper_ar3_2_LB02_LS.jpg" Height="164px" Width="279px" ImageAlign="Middle" PostBackUrl="Articulo.aspx" />
            
        </center>
    <br />
    El resto de productos:<br />
    <br />
    
        <center>
            <<asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="https://static.westwingnow.de/image/upload//simple/81/5511/1186712.jpg" Height="164px" Width="279px" ImageAlign="Left" PostBackUrl="Articulo.aspx" />
            <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="https://medias.maisonsdumonde.com/image/upload/q_auto,f_auto/w_1000/img/sofa-de-2-3-plazas-de-terciopelo-azul-1000-9-30-188097_9.jpg" Height="164px" Width="279px" ImageAlign="Right" PostBackUrl="Articulo.aspx" />
            <asp:ImageButton ID="ImageButton7" runat="server" ImageUrl="https://www.muebledesign.com/img/cms/mesa-noguche-coffe-mueble-design.jpg" Height="164px" Width="279px" ImageAlign="Middle" PostBackUrl="Articulo.aspx" />
        </center>
    <br />
        <center>
           <asp:ImageButton ID="ImageButton8" runat="server" ImageUrl="https://st01.ventamueblesonline.es/58096-thickbox_default/composicion-de-salon-argos-twin-sable.jpg" Height="164px" Width="279px" ImageAlign="Left" PostBackUrl="Articulo.aspx" />
            <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="https://lw-cdn.com/images/D9963761E243/k_f8a7d8b0a190c36347dbba136cee5b27;w_1600;h_1600;q_70/lampara-de-pared-luca-de-cristal-rustica-blanca.webp" Height="164px" Width="279px" ImageAlign="Right" PostBackUrl="Articulo.aspx" />
            <asp:ImageButton ID="ImageButton10" runat="server" ImageUrl="https://cdn.sklum.com/es/875214/planta-artificial-monstera.jpg?cf-resize=gallery" Height="164px" Width="279px" ImageAlign="Middle" PostBackUrl="Articulo.aspx" />
        </center>
    <br />
        <center>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="https://i.ibb.co/VYcx7pX/Articulo-sofa-sencillo-sin-marca-de-agua.png" Height="164px" Width="279px" ImageAlign="Left" PostBackUrl="Articulo.aspx" />
            <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/6/a/1/4/6a14dc460b3700644830b77108556eb6792cb4f1_CLPMAS004SMK_UK_Masako_Chandelier_Pendant_Light_Smoked_Opal_Glass_ar3_2_LB02_LS.jpg" Height="164px" Width="279px" ImageAlign="Right" PostBackUrl="Articulo.aspx" />
            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="https://static.westwingnow.de/image/upload//simple/74/932/1324021.jpg" Height="164px" Width="279px" ImageAlign="Middle" PostBackUrl="Articulo.aspx" />
        </center>
        -->

</asp:Content>