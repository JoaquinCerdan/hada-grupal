<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="iqueaWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<<<<<<< HEAD

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>Bienvenido. Inicie sesión o registrese. </h4>
                    <hr />
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Usuario</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="user" CssClass="form-control" TextMode="Email" />
                            
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="pass" CssClass="col-md-2 control-label">Contraseña</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                            
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" OnClick="Login" Text="Inicie sesión" CssClass="btn btn-default" />
                            &nbsp;
                            <asp:Button runat="server" OnClick="Register" Text="Registrarse" CssClass="btn btn-default" />
                        </div>
                    </div>
                </div>
                
                
            </section>
        </div>
     </div>
</asp:Content>

=======
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
                <input type="email" id="inputEmail" class="form-control" placeholder="Correo electrónico" required autofocus>
                <label for="inputEmail">Correo electrónico</label>
              </div>

              <div class="form-label-group">
                <input type="password" id="inputPassword" class="form-control" placeholder="Contraseña" required>
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
>>>>>>> develop
