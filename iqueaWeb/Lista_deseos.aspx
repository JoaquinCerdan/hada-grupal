<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Lista_deseos.aspx.cs" Inherits="iqueaWeb.Lista_deseos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="centrar">Listas de deseos</h1>
    <!--
    <div>
        <u><strong>Nombre de la lista 1</strong></u> <br />
        Número artículos
    </div>
    <div>
        <u><strong>Nombre de la lista 2</strong></u> <br />
        Número artículos
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Crear nueva lista" OnClick="Button1_Click" />
    </div>
    -->
<div class="card-body">
                    <!-- PRODUCT -->
                    <div class="row">
                        <div class="col-12 col-sm-12 col-md-2 text-center">
                                <img class="img-responsive" src="http://placehold.it/120x80" alt="prewiew" width="120" height="80">
                        </div>
                        <div class="col-12 text-sm-center col-sm-12 text-md-left col-md-6">
                            <h4 class="product-name"><strong>Product Name</strong></h4>
                            <h4>
                                <small>Product description</small>
                            </h4>
                        </div>
                        <div class="col-12 col-sm-12 text-sm-center col-md-4 text-md-right row">
                            <div class="col-3 col-sm-3 col-md-6 text-md-right" style="padding-top: 5px">
                                <h6><strong>25.00 <span class="text-muted">x</span></strong></h6>
                            </div>
                            <div class="col-4 col-sm-4 col-md-4">
                                <div class="quantity">
                                    <input type="button" value="+" class="plus">
                                    <input type="number" step="1" max="99" min="1" value="1" title="Qty" class="qty"
                                           size="4">
                                    <input type="button" value="-" class="minus">
                                </div>
                            </div>
                            <div class="col-2 col-sm-2 col-md-2 text-right">
                                <button type="button" class="btn btn-outline-danger "   >
                                    Eliminar
                                </button>
                                <button type="button" class="btn btn-outline-danger "   >
                                    Añadir al carrito
                                </button>
                            </div>
                        </div>
                    </div>
                    <hr>
                    <!-- END PRODUCT -->
                    <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" ShowHeader="False" Width="256px" HorizontalAlign="Center"  >
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
                            <asp:BoundField DataField="Precio" HeaderText="Precio" />
                        </Columns>
                    </asp:GridView>
                
            </div>

</asp:Content>
