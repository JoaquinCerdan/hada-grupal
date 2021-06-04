<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Exterior.aspx.cs" Inherits="iqueaWeb.Exterior" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <h1>Muebles de Exterior</h1>
    </center>

    

    <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" ShowHeader="False" Width="256px" HorizontalAlign="Center" OnSelectedIndexChanged="GridView_SelectedIndexChanged" AutoGenerateSelectButton="True">
        <Columns>
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
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
        <center><asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="https://eus3.aosomcdn.com/es/catalog/product/6/5/655759d03fb5c36bd6158f767bbde756_1.jpg" Height="160px" style="margin-left: 0px; margin-top: 0px" Width="290px" PostBackUrl="Articulo.aspx" />
        <br />
        Sofá cama 3 plazas, gris<br />
        Valoracion : <asp:Image ID="Image3" ImageUrl="http://assets.stickpng.com/thumbs/58738756f3a71010b5e8ef44.png" runat="server" Height="29px" Width="80px"></asp:Image> <br />
        Precio normal 190 €<br />
        Oferta: 149€<br />
        </center>
    </div>
     <br />
     El resto de productos:<br />
    <br />
        <center>
            <asp:ImageButton ID="ImageButton11" runat="server" ImageUrl="https://pictureserver.net/images/pic/c9/e0/undef_src_sa_picid_797775_x_1000_type_color_image.jpg?ver=8" Height="164px" Width="279px" ImageAlign="Left" PostBackUrl="Articulo.aspx" />
            <asp:ImageButton ID="ImageButton12" runat="server" ImageUrl="https://www.arteleya.es/media/catalog/product/cache/af0544a5658ce96f8bcab9d1e8dbb4f8/1/1/11834_oceana_daybed_terasse_2k.jpg" Height="164px" Width="279px" ImageAlign="Right" PostBackUrl="Articulo.aspx" />
            <asp:ImageButton ID="ImageButton13" runat="server" ImageUrl="https://medias.maisonsdumonde.com/image/upload/q_auto,f_auto/w_1000/img/sillon-de-jardin-de-resina-trenzada-1000-5-27-110522_4.jpg" Height="164px" Width="279px" ImageAlign="Middle" PostBackUrl="Articulo.aspx" />
        </center>
    -->
</asp:Content>
