<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OrdenaE.aspx.cs" Inherits="iqueaWeb.OrdenaE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h1>Muebles de Exterior</h1>
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
        <asp:Button ID="Ordenar" runat="server" PostBackUrl="~/OrdenaE.aspx" Text="Ordenar" />
            
    </div>
     <br />
    Productos disponibles:<br />
    <br />
    <center>
            <asp:ImageButton ID="ImageButton11" runat="server" ImageUrl="https://pictureserver.net/images/pic/c9/e0/undef_src_sa_picid_797775_x_1000_type_color_image.jpg?ver=8" Height="164px" Width="279px" ImageAlign="Left" PostBackUrl="Articulo.aspx" />
            <asp:ImageButton ID="ImageButton12" runat="server" ImageUrl="https://www.arteleya.es/media/catalog/product/cache/af0544a5658ce96f8bcab9d1e8dbb4f8/1/1/11834_oceana_daybed_terasse_2k.jpg" Height="164px" Width="279px" ImageAlign="Right" PostBackUrl="Articulo.aspx" />
            <asp:ImageButton ID="ImageButton13" runat="server" ImageUrl="https://medias.maisonsdumonde.com/image/upload/q_auto,f_auto/w_1000/img/sillon-de-jardin-de-resina-trenzada-1000-5-27-110522_4.jpg" Height="164px" Width="279px" ImageAlign="Middle" PostBackUrl="Articulo.aspx" />
        </center>
    <br />
    <center>
        <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="https://eus3.aosomcdn.com/es/catalog/product/6/5/655759d03fb5c36bd6158f767bbde756_1.jpg" Height="160px" style="margin-left: 0px; margin-top: 0px" Width="290px" PostBackUrl="Articulo.aspx" />
    </center>
</asp:Content>
