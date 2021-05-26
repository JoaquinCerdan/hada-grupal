using System;

namespace iqueaWeb
{
    public partial class Articulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["id"] != null)
                {
                    Boolean caso;
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    ENArticulo articulo = new ENArticulo();
                    articulo.intId = id;

                    caso = articulo.readArticulo();

                    if (caso == true)
                    {
                        Image1.ImageUrl = articulo.stringImagen;
                        nombre.Text = articulo.stringNombre;
                        descripcion.Text = articulo.stringDescripcion;
                        precio.Text = Convert.ToString(articulo.doublePrecio);

                    }
                    else
                    {
                        throw new Exception("Error con el articulo");
                    }
                }
                else
                {
                    throw new Exception("No se ha podido cargar la página");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected void comprar_Click(object sender, EventArgs e)
        {

        }

        protected void lista_deseos_Click(object sender, EventArgs e)
        {

        }

        protected void anterior_com_Click(object sender, EventArgs e)
        {

        }

        protected void siguiente_com_Click(object sender, EventArgs e)
        {

        }
    }
}