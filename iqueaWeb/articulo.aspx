<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.master" AutoEventWireup="true" CodeBehind="Articulo.aspx.cs" Inherits="iqueaWeb.Articulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
    <!--
    <br />
    &nbsp;&nbsp;<asp:Image ID="Image1" runat="server" ImageUrl="https://www.muebleselparaiso.es/102171-large_default/sofa-cama-de-3-plazas-tessa.jpg" />
    <p>
        <strong>&nbsp;&nbsp;<asp:Label ID="enunciado_nombre" runat="server" Text="Nombre del artículo:"></asp:Label></strong>
        <asp:TextBox ID="nombre" runat="server"></asp:TextBox>
    </p>
    <p>
        <strong>&nbsp;&nbsp;<asp:Label ID="enunciado_descripcion" runat="server" Text="Descripción del artículo:"></asp:Label></strong>
        <asp:TextBox ID="descripcion" runat="server"></asp:TextBox>
    </p>
    <p>
        <strong>&nbsp;&nbsp;<asp:Label ID="enunciado_precio" runat="server" Text="Precio del articulo:"></asp:Label></strong>
        <asp:TextBox ID="precio" runat="server"></asp:TextBox>
    </p>
    <p>
        <strong>&nbsp;&nbsp;<asp:Label ID="enunciado_stock" runat="server" Text="Stock del artículo:"></asp:Label></strong>
        <asp:CheckBox ID="stock" runat="server" />
    </p>

    <p>
        &nbsp;&nbsp;
        <asp:Button ID="comprar" runat="server" Text="comprar" style="border-style: groove; border-width: 1px" /> &nbsp;&nbsp;
        <asp:Button ID="lista_deseos" runat="server" Text="añadir a lista de deseos" style="border-style: groove; border-width: 1px" />&nbsp;&nbsp;
    </p>

    <br />
    <p>
        <strong>&nbsp;&nbsp;<asp:Label ID="enunciado_comentarios" runat="server" Text="COMENTARIOS:"></asp:Label></strong>
    </p>
    <p>
        <strong>&nbsp;&nbsp;<asp:Label ID="enunciado_usuario" runat="server" Text="Usuario:"></asp:Label></strong>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        <strong>&nbsp;&nbsp;<asp:Label ID="enunciado_comentario" runat="server" Text="Comentario:"></asp:Label></strong>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        <strong>&nbsp;&nbsp;<asp:Label ID="enunciado_valoracion" runat="server" Text="Valoración:"></asp:Label></strong>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;<asp:Button ID="anterior_com" runat="server" Text="anterior comentario" style="border-style: groove; border-width: 1px" /> &nbsp;&nbsp;
        <asp:Button ID="siguiente_com" runat="server" Text="siguiente comentario" style="border-style: groove; border-width: 1px"  />&nbsp;&nbsp;
    </p>

    -->


     <div class="col-lg-6" style="margin:0 auto;">
                    <div class="card mt-2">
                        <img class="card-img-top " width="400" height="600" src="https://www.muebleselparaiso.es/102171-large_default/sofa-cama-de-3-plazas-tessa.jpg" alt="..." />
                        <div class="card-body">
                            <h3 id="producto_name"  class="card-title">Product Name</h3>
                            <h4 ID="producto_precio">$24.99</h4>
                            <p  ID="producto_descripcion" class="descripcion">Esta es la descripción</p>
                            <span class="text-warning">★ ★ ★ ★ ☆</span>
                            4.0 stars
                            <br />
                            <asp:Button ID="anadir_lista_deseos" runat="server" Text="Añadir a lista de deseos" style="border-style: groove; border-width: 1px" />
                            <asp:Button ID="comprar_articulo" runat="server" Text="Comprar" style="border-style: groove; border-width: 1px" />
                        </div>
                    </div>
                    <div class="card card-outline-secondary my-4">
                        <div class="card-header">Reseñas</div>
                        <div class="card-body">
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.</p>
                            <small class="text-muted">Posted by Anonymous on 3/1/21</small>
                            <hr />
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.</p>
                            <small class="text-muted">Posted by Anonymous on 3/1/21</small>
                            <hr />
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Omnis et enim aperiam inventore, similique necessitatibus neque non! Doloribus, modi sapiente laboriosam aperiam fugiat laborum. Sequi mollitia, necessitatibus quae sint natus.</p>
                            <small class="text-muted">Posted by Anonymous on 3/1/21</small>
                            <hr />
                            <a class="btn btn-success" href="#!">Dejar una reseña</a>
                        </div>
                    </div>
                </div>
            

</asp:Content>