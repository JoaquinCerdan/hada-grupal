using System;

namespace iqueaWeb
{
    public partial class Articulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //al cargar la pagina debe cargar los datos del usuario y su primer comentario
            try
            {
                if (Request.QueryString["id"] != null)
                {
                    //si la cadena de busqueda tiene una id se consiguen los datos de ese objeto
                    Boolean caso,casob;
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    ENArticulo articulo = new ENArticulo();
                    ENcomentario comentario = new ENcomentario();
                    articulo.intId = id;

                    caso = articulo.readArticulo();

                    if (caso == true)
                    {
                        //si existe ese objeto en la base de datos se dan sus datos a cada etiqueta
                        Image1.ImageUrl = articulo.stringImagen;
                        nombre.Text = articulo.stringNombre;
                        descripcion.Text = articulo.stringDescripcion;
                        precio.Text = Convert.ToString(articulo.doublePrecio);
                        stock.Checked = Convert.ToBoolean(articulo.boolStock);
                        casob=comentario.readFirstComentario(id);

                        if (casob == true)
                        {
                            //si se encuentra un comentario sobre el objeto se ponen sus datos en las etiquetas
                            enunciado_comentario.Text = comentario.comentarioP;
                            enunciado_valoracion.Text = comentario.valoracionP.ToString();
                        }

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
            if (Session["email"] == null)
            {
                //en caso de que no sea un usuario, se le manda a login y no se le permite controlar
                Response.Redirect("Login.aspx");
            }
            else
            {
                //en el caso de que si haya un usuario logeado se envia la id del articulo y se redirige a Carrito
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Response.Redirect("Carrito.aspx?id=" + id.ToString());
            }
        }

        protected void lista_deseos_Click(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                //en caso de que no sea un usuario, se le manda a login y no se le permite controlar
                Response.Redirect("Login.aspx");
            }
            else
            {
                //en el caso de que si haya un usuario logeado se envia la id del articulo y se redirige a Carrito
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Response.Redirect("Lista_deseos.aspx?id=" + id.ToString());
            }
        }

        protected void anterior_com_Click(object sender, EventArgs e)
        {
            //el comentario que se muestra actualmente
            ENcomentario antiguo = new ENcomentario();
            //el comentario nuevo
            ENcomentario nuevo = new ENcomentario();

            //se guardan los datos actuales en el antiguo y se consigue su id
            antiguo.valoracionP = Convert.ToInt32(enunciado_valoracion.Text);
            antiguo.comentarioP = enunciado_comentario.Text;
            antiguo.readComentario_datos();

            bool funciona=nuevo.readPrevComentario(antiguo.idP);

            if (funciona == true)
            {
                //se llama a buscar el siguiente comentario y se sacan los datos en sus enunciados
                nuevo.idP = antiguo.idP;
                nuevo.readPrevComentario(Convert.ToInt32(Request.QueryString["id"]));

                enunciado_valoracion.Text = nuevo.valoracionP.ToString();
                enunciado_comentario.Text = nuevo.comentarioP;
            }

        }

        protected void siguiente_com_Click(object sender, EventArgs e)
        {
            //el comentario que se muestra actualmente
            ENcomentario antiguo = new ENcomentario();
            //el comentario nuevo
            ENcomentario nuevo = new ENcomentario();

            //se guardan los datos actuales en el antiguo y se consigue su id
            antiguo.valoracionP = Convert.ToInt32(enunciado_valoracion.Text);
            antiguo.comentarioP = enunciado_comentario.Text;
            bool funciona=antiguo.readComentario_datos();

            if (funciona == true)
            {
                //se llama a buscar el siguiente comentario y se sacan los datos en sus enunciados
                nuevo.idP = antiguo.idP;
                nuevo.readNextComentario(Convert.ToInt32(Request.QueryString["id"]));

                enunciado_valoracion.Text = nuevo.valoracionP.ToString();
                enunciado_comentario.Text = nuevo.comentarioP;
            }
        }

    }
}