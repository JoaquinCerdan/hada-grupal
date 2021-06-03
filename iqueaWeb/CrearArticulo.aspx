<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="CrearArticulo.aspx.cs" Inherits="iqueaWeb.Formulario_web18" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
    
    
        <p>
&nbsp; Nombre:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" 
            runat="server" ErrorMessage=" *Campo Obligatorio" 
            forecolor="red" ControlToValidate="TextBox1">
        </asp:RequiredFieldValidator>
    </p>
    <p>
&nbsp; Descripción:
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
            runat="server" ErrorMessage=" *Campo Obligatorio" 
            forecolor="red" ControlToValidate="TextBox5">
        </asp:RequiredFieldValidator>
    </p>
    <p>
&nbsp; Precio:
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
            runat="server" ErrorMessage=" *Campo Obligatorio" 
            forecolor="red" ControlToValidate="TextBox6">
        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
        ControlToValidate="TextBox6" runat="server"
        ErrorMessage=" *Solo números"
        ForeColor="Red"
        ValidationExpression="((\d+)((\,\d{1,2})?))$">
        </asp:RegularExpressionValidator>
    </p>
    <p>
&nbsp; Url Imagen:
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
            runat="server" ErrorMessage=" *Campo Obligatorio" 
            forecolor="red" ControlToValidate="TextBox7">
        </asp:RequiredFieldValidator>
    </p>
    <p>
&nbsp; Stock:
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
            runat="server" ErrorMessage=" *Campo Obligatorio" 
            forecolor="red" ControlToValidate="TextBox8">
        </asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
        ControlToValidate="TextBox8" runat="server"
        ErrorMessage=" *Solo números"
        ForeColor="Red"
        ValidationExpression="\d+">
        </asp:RegularExpressionValidator>
    </p>
    <p>
    Categoria: 
     <asp:DropDownList ID="Categoria"  style="margin-bottom:10px; width:10%; height:40px;"  AutoPostBack="true" runat="server">
                        
                        <asp:ListItem Value="0"> Interior </asp:ListItem>
                        <asp:ListItem Value="1"> Exterior </asp:ListItem>
                </asp:DropDownList>
   </p>
    <p>
    Temporada: 
     <asp:DropDownList ID="Temporada"  style="margin-bottom:10px; width:10%; height:40px;"  AutoPostBack="true" runat="server">
                        
                        <asp:ListItem Value="0"> Sencillo </asp:ListItem>
                        <asp:ListItem Value="1"> Clásico </asp:ListItem>
                         <asp:ListItem Value="2"> Moderno </asp:ListItem>
                </asp:DropDownList>
    </p>
    <p>
&nbsp;
        <asp:Button ID="Button2" Class="btn btn-primary" runat="server" Text="Crear" OnClick="Button2_Click" />
        <asp:Label ID="etiqueta" runat="server" Text="Aviso"></asp:Label>
    </p>
</asp:Content>
