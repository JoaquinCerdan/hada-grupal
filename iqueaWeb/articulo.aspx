<%@ Page Language="C#" MasterPageFile="~/Site1.Master" %>


<asp:Content ID="contenido" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    &nbsp;&nbsp;<img src="../logo_iquea.jpg" style="border-style: solid; border-width: 2px; padding: 1px 4px; height: 200px; width: 400px" >
    <p>
        &nbsp;&nbsp;<strong>Descripción del articulo:</strong>
        <input type="text" size="150" maxlength="400" name="descripcion" readonly="readonly" />
    </p>
    <p>
        &nbsp;&nbsp;<strong>Precio del articulo:</strong>
        <input type="text" size="10" maxlength="10" name="descripcion" readonly="readonly" />
    </p>
    <p>
        &nbsp;&nbsp;<strong>Categoria del articulo:</strong>
        <input type="text" size="20" maxlength="50" name="descripcion" readonly="readonly"/>
    </p>
    <p>
        &nbsp;&nbsp;<strong>Stock:</strong>
        <input type="checkbox"  name="descripcion" disabled />
    </p>
    <p>
        &nbsp;&nbsp;
        <asp:Button ID="comprar" runat="server" Text="comprar" style="border-style: groove; border-width: 1px" OnClick="ButtonLeer_Click" /> &nbsp;&nbsp;
        <asp:Button ID="lista_deseos" runat="server" Text="añadir a lista de deseos" style="border-style: groove; border-width: 1px" OnClick="ButtonLeer_Click" />&nbsp;&nbsp;
        <asp:Button ID="carrito" runat="server" Text="añadir a carrito" style="border-style: groove; border-width: 1px" OnClick="ButtonLeer_Click" />&nbsp;&nbsp;
    </p>

    <br />
    <p>
        &nbsp;&nbsp;<strong><u>COMENTARIOS</u>:</strong>
    </p>
    <p>
        &nbsp;&nbsp;<strong>Usuario:</strong>
        <input type="text" size="40" maxlength="100" name="nombre_usuario" readonly="readonly" />
    </p>
    <p>
        &nbsp;&nbsp;<strong>Comentario:</strong>
        <input type="text" size="150" maxlength="400" name="comentario"readonly="readonly" />
    </p>
    <p>
        &nbsp;&nbsp;<strong>Valoración:</strong>
        <input type="text" size="10" maxlength="10" name="valoracion" readonly="readonly"/>
    </p>
    <p>
        &nbsp;&nbsp;<asp:Button ID="anterior_com" runat="server" Text="anterior comentario" style="border-style: groove; border-width: 1px" OnClick="ButtonLeer_Click" /> &nbsp;&nbsp;
        <asp:Button ID="siguiente_com" runat="server" Text="siguiente comentario" style="border-style: groove; border-width: 1px" OnClick="ButtonLeer_Click" />&nbsp;&nbsp;
    </p>



</asp:Content>


