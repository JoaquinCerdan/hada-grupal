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
        <body>
  <div class="row px-5 pt-5">
    <div class="col-md-4 mt-4 mt-sm-0 card-container">
      <div class="card text-center product p-4 pt-5 border-0 h-100 rounded-0">
        <img class="img-fluid d-block mx-auto" src="https://casaydiseno.com/wp-content/uploads/2016/05/biblioteca-peque%C3%B1a-salon-monimalista.jpg" alt="muebles-sencillos">
        <div class="card-body p-4 py-0 h-xs-440p">
          <h4 class="card-title font-weight-semi-bold mb-3 w-xl-280p mx-auto">Muebles sencillos</h4>
          
        </div>
        <p class="btn w-100 px-4 mx-auto">
          
          
             <asp:button Text="Comprar" class="btn btn-dark btn-lg w-100" type="submit"  ID="ButtonComprar1" runat="server" Height="40px" PostBackUrl="~/Sencillo.aspx" Width="150px"  />
        </p>
      </div>
    </div>

    <div class="col-md-4 mt-4 mt-sm-0 card-container">
      <div class="card text-center product p-4 pt-5 border-0 h-100 rounded-0">
        <img class="img-fluid d-block mx-auto" src="https://casaydiseno.com/wp-content/uploads/2016/05/bibliotecas-modernas-compartimentos-salon.jpg" alt="muebles-modernos">
        <div class="card-body p-4 py-0 h-xs-440p">
          <h4 class="card-title font-weight-semi-bold mb-3 w-xl-280p mx-auto">Muebles modernos</h4>
          
        </div>
        <p class="btn w-100 px-4 text-center mx-auto">
         <asp:button Text="Comprar" class="btn btn-dark btn-lg w-100" type="submit"  ID="ButtonComprar2" runat="server" Height="40px" PostBackUrl="~/Moderno.aspx" Width="150px"  />
      </div>
    </div>

    <div class="col-md-4 mt-4 mt-sm-0 card-container">
      <div class="card text-center product p-4 pt-5 border-0 h-100 rounded-0">
        <img class="img-fluid d-block mx-auto" src="https://casaydiseno.com/wp-content/uploads/2016/05/bonita.deco_.estilo.retro_.jpg" alt="Muebles clásicos">
        <div class="card-body p-4 py-0 h-xs-440p">
          <h4 class="card-title font-weight-semi-bold mb-3 w-xl-280p mx-auto">Muebles clásicos</h4>
          
        </div>
        <p class="btn w-100 px-4 mx-auto">
          <asp:button Text="Comprar" class="btn btn-dark btn-lg w-100" type="submit"  ID="ButtonComprar3" runat="server" Height="40px" PostBackUrl="~/Clasico.aspx" Width="150px"  />
      </div>
    </div>
  </div>
</body>
    <br />
    
    
    

</asp:Content>
