﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="iqueaWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .form-label-group {
            width: 1970px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <div class="container">
    <div class="row">
      <div class="col-sm-9 col-md-7 col-lg-5 mx-auto">
        <div class="card card-signin my-5">
          <div class="card-body">
            <h5 class="card-title text-center">Inicio de sesión</h5>
              <p class="card-title text-center">&nbsp;</p>
            <form class="form-signin">
              <div class="form-label-group">
                <!--<input type="email" id="inputEmail" class="form-control" placeholder="Correo electrónico" > -->
                  Correo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:TextBox ID="inputEmail" runat="server" Width="189px" Height="26px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ErrorMessage="*Campo<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp; Obligatorio" forecolor="red" ControlToValidate="inputEmail">                 
                  </asp:RequiredFieldValidator>
                <!--<label for="inputEmail">Correo electrónico</label>-->
                  <br />
              </div>

              <div class="form-label-group">
                <!--<input type="password" id="inputPassword" class="form-control" placeholder="Contraseña" >-->
                  Contraseña:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="inputPassword" runat="server" Width="189px" Height="26px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ErrorMessage="*Campo<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp&nbsp;&nbsp; Obligatorio" forecolor="red" ControlToValidate="inputPassword"></asp:RequiredFieldValidator>
                <!--<label for="inputPassword">Contraseña</label>-->
                  <br />
                  <br />
              </div>

              
              <button class="btn btn-lg btn-primary btn-block text-uppercase" type="submit">Sign in</button>
              <hr class="my-4">
              
            </form>
          </div>
        </div>
      </div>
    </div>
  </div>

</asp:Content>
