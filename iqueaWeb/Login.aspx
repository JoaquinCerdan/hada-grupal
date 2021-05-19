<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="iqueaWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--
     <p style="text-align: center">
        Nombre de Usuario:
        <input id="Text1" type="text" /></p>
    <p style="text-align: center">
        Contraseña:
        <input id="Text2" type="text" /></p>
    <p style="text-align: center">
        <asp:Button ID="Button1" runat="server" Text="Iniciar como Administrador" PostBackUrl="~/Administrador.aspx" />
        &nbsp; <asp:Button ID="Button2" runat="server" Text="Iniciar Sesion" PostBackUrl="~/Usuario.aspx" />
        &nbsp; <input id="Button3" type="button" value="Registrarse" /></p>
    -->

    <body>
  <div class="container">
    <div class="row">
      <div class="col-sm-9 col-md-7 col-lg-5 mx-auto">
        <div class="card card-signin my-5">
          <div class="card-body">
            <h5 class="card-title text-center">Inicio de sesión</h5>
            <form class="form-signin">
              <div class="form-label-group">
                <input type="email" id="inputEmail" class="form-control" placeholder="Correo electrónico" >
                <label for="inputEmail">Correo electrónico</label>
              </div>

              <div class="form-label-group">
                <input type="password" id="inputPassword" class="form-control" placeholder="Contraseña" >
                <label for="inputPassword">Contraseña</label>
              </div>

              
              <button class="btn btn-lg btn-primary btn-block text-uppercase" type="submit">Sign in</button>
              <hr class="my-4">
              
            </form>
          </div>
        </div>
      </div>
    </div>
  </div>
</body>

</asp:Content>

