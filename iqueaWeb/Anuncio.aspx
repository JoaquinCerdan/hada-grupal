<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.master" AutoEventWireup="true" CodeBehind="Anuncio.aspx.cs" Inherits="iqueaWeb.Anuncio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      



     <div class="col-lg-6" style="margin:0 auto;">
                    <div class="card mt-2">
                        <img class="card-img-top " width="400" height="600" src="https://www.muebleselparaiso.es/102171-large_default/sofa-cama-de-3-plazas-tessa.jpg" alt="..." />
                        <div class="card-body">
                            <h3 id="producto_name"  class="card-title">Product Name</h3>
                            <h4 ID="producto_precio">$24.99</h4>
                            <p  ID="producto_descripcion" class="descripcion">Esta es la descripción</p>
                            
                            <br />
                            <asp:Button ID="anadir_lista_deseos" runat="server" Text="Añadir a lista de deseos" style="border-style: groove; border-width: 1px" />
                            <asp:Button ID="comprar_articulo" runat="server" Text="Comprar" style="border-style: groove; border-width: 1px" />
                        </div>
                    </div>
                   
                </div>
            

</asp:Content>
