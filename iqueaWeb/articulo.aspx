<%@ Page Language="C#" MasterPageFile="~/Site1.Master" %>

<asp:Content ID="contenido" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    &nbsp;&nbsp;<asp:Image ID="Image1" runat="server" src="../logo_iquea.jpg" />
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
        <strong>nbsp;&nbsp;<asp:Label ID="enunciado_stock" runat="server" Text="Stock del artículo:"></asp:Label></strong>
        <asp:CheckBox ID="stock" runat="server" />
    </p>

    <p>
        &nbsp;&nbsp;
        <asp:Button ID="comprar" runat="server" Text="comprar" style="border-style: groove; border-width: 1px" OnClick="ButtonLeer_Click" /> &nbsp;&nbsp;
        <asp:Button ID="lista_deseos" runat="server" Text="añadir a lista de deseos" style="border-style: groove; border-width: 1px" OnClick="ButtonLeer_Click" />&nbsp;&nbsp;
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
        <strong>nbsp;&nbsp;<asp:Label ID="enunciado_comentario" runat="server" Text="Comentario:"></asp:Label></strong>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        <strong>&nbsp;&nbsp;<asp:Label ID="enunciado_valoracion" runat="server" Text="Valoración:"></asp:Label></strong>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;<asp:Button ID="anterior_com" runat="server" Text="anterior comentario" style="border-style: groove; border-width: 1px" OnClick="ButtonLeer_Click" /> &nbsp;&nbsp;
        <asp:Button ID="siguiente_com" runat="server" Text="siguiente comentario" style="border-style: groove; border-width: 1px" OnClick="ButtonLeer_Click" />&nbsp;&nbsp;
    </p>



</asp:Content>


