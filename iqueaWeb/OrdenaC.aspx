<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OrdenaC.aspx.cs" Inherits="iqueaWeb.OrdenarC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h1>Muebles de salón tipo clasico</h1>
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
        <asp:Button ID="Ordenar" runat="server" PostBackUrl="~/OrdenaC.aspx" Text="Ordenar" />
            
    </div>
     <br />

    <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" ShowHeader="False" Width="256px" HorizontalAlign="Center" OnRowCommand="GridView_RowCommand1">
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

    <!--<asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Database %>" SelectCommand="SELECT [Imagen], [Nombre] FROM [Articulo]"></asp:SqlDataSource>-->

    <!--Productos disponibles:<br />
    <br />
    <center>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="https://st01.ventamueblesonline.es/58096-thickbox_default/composicion-de-salon-argos-twin-sable.jpg" Height="164px" Width="279px" ImageAlign="Left" PostBackUrl="Articulo.aspx" />
            <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="https://lw-cdn.com/images/D9963761E243/k_f8a7d8b0a190c36347dbba136cee5b27;w_1600;h_1600;q_70/lampara-de-pared-luca-de-cristal-rustica-blanca.webp" Height="164px" Width="279px" ImageAlign="Right" PostBackUrl="Articulo.aspx" />
            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="https://cdn.sklum.com/es/875214/planta-artificial-monstera.jpg?cf-resize=gallery" Height="164px" Width="279px" ImageAlign="Middle" PostBackUrl="Articulo.aspx" />
    </center>
    <br />
    <center>
        <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="https://pictureserver.net/images/pic/d9/76/undef_src_sa_picid_749405_x_1800_type_color_image.jpg?ver=14" Height="160px" style="margin-left: 0px; margin-top: 0px" Width="290px" PostBackUrl="Articulo.aspx" />
    </center>
    -->
</asp:Content>
