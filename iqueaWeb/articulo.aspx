<%@ Page Language="C#" MasterPageFile="~/Site1.Master" %>


<asp:Content ID="contenido" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <img src="https://1000marcas.net/wp-content/uploads/2019/12/IKEA-Logo-600x338.png" style="height: 200px; width: 400px" >
    <p>
        &nbsp;&nbsp;Descripción del articulo:
        <input type="text" size="150" maxlength="400" name="descripcion" />
    </p>
    <p>
        &nbsp;&nbsp;Precio del articulo:    
        <input type="text" size="10" maxlength="10" name="descripcion" />
    </p>
    <p>
        &nbsp;&nbsp;Categoria del articulo:
        <input type="text" size="20" maxlength="50" name="descripcion" />
    </p>
    <p>
        &nbsp;&nbsp;Stock:
        <input type="checkbox"  name="descripcion" />
    </p>
    <p>
        &nbsp;&nbsp;
        <asp:Button ID="comprar" runat="server" Text="comprar" style="border-style: groove; border-width: 1px" OnClick="ButtonLeer_Click" /> &nbsp;&nbsp;
        <asp:Button ID="lista_deseos" runat="server" Text="añadir a lista de deseos" style="border-style: groove; border-width: 1px" OnClick="ButtonLeer_Click" />&nbsp;&nbsp;
        <asp:Button ID="carrito" runat="server" Text="añadir a carrito" style="border-style: groove; border-width: 1px" OnClick="ButtonLeer_Click" />&nbsp;&nbsp;
    </p>

    <p>    </p>
    <p>
        &nbsp;&nbsp;comentarios:
    </p>
    <p>
        &nbsp;&nbsp;Usuario:
        <input type="text" size="40" maxlength="100" name="nombre_usuario" />
    </p>
    <p>
        &nbsp;&nbsp;Comentario:
        <input type="text" size="150" maxlength="400" name="comentario" />
    </p>
    <p>
        &nbsp;&nbsp;Valoración:
        <input type="text" size="10" maxlength="10" name="valoracion" />
    </p>
    <p>
        &nbsp;&nbsp;<asp:Button ID="anterior_com" runat="server" Text="anterior comentario" style="border-style: groove; border-width: 1px" OnClick="ButtonLeer_Click" /> &nbsp;&nbsp;
        <asp:Button ID="siguiente_com" runat="server" Text="siguiente comentario" style="border-style: groove; border-width: 1px" OnClick="ButtonLeer_Click" />&nbsp;&nbsp;
    </p>



</asp:Content>


