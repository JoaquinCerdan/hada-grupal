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
                        stock.Checked = Convert.ToBoolean(articulo.intStock);
                        casob=comentario.readFirstComentario(id);

                        if (casob == true)
                        {
                            //si se encuentra un comentario sobre el objeto se ponen sus datos en las etiquetas
                            TextBox2.Text = comentario.comentarioP;
                            TextBox3.Text = comentario.valoracionP.ToString();
                            TextBox1.Text = comentario.Usuario_correoP;
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

                //Llamar al CAD de lista de deseos y le metemos la id del articulo , y el email del usuario logueado

                ENLista_deseos lista = new ENLista_deseos();

                lista.intId_articulo = id;
                lista.intId_user = (string)Session["email"];

                bool creado;
                creado= lista.createLista_deseos();
                if (creado)
                {
                    Response.Redirect("Lista_deseos.aspx?id=" + id.ToString());
                }
                

                
            }
        }

        protected void anterior_com_Click(object sender, EventArgs e)
        {
            //el comentario que se muestra actualmente
            ENcomentario antiguo = new ENcomentario();
            //el comentario nuevo
            ENcomentario nuevo = new ENcomentario();

            //se guardan los datos actuales en el antiguo y se consigue su id
            antiguo.valoracionP = Convert.ToInt32(TextBox3.Text);
            antiguo.comentarioP = TextBox2.Text;
            antiguo.Usuario_correoP = TextBox1.Text;
            antiguo.readComentario_datos();

            bool funciona=nuevo.readPrevComentario(antiguo.idP);

            if (funciona == true)
            {
                //se llama a buscar el siguiente comentario y se sacan los datos en sus enunciados
                nuevo.idP = antiguo.idP;
                nuevo.readPrevComentario(Convert.ToInt32(Request.QueryString["id"]));

                TextBox2.Text = nuevo.comentarioP;
                TextBox3.Text = nuevo.valoracionP.ToString();
                TextBox1.Text = nuevo.Usuario_correoP;
            }

        }

        protected void siguiente_com_Click(object sender, EventArgs e)
        {
            //el comentario que se muestra actualmente
            ENcomentario antiguo = new ENcomentario();
            //el comentario nuevo
            ENcomentario nuevo = new ENcomentario();

            //se guardan los datos actuales en el antiguo y se consigue su id
            antiguo.valoracionP = Convert.ToInt32(TextBox3.Text);
            antiguo.comentarioP = TextBox2.Text;
            antiguo.Usuario_correoP = TextBox1.Text;
            bool funciona=antiguo.readComentario_datos();

            if (funciona == true)
            {
                //se llama a buscar el siguiente comentario y se sacan los datos en sus enunciados
                nuevo.idP = antiguo.idP;
                nuevo.readNextComentario(Convert.ToInt32(Request.QueryString["id"]));

                TextBox2.Text = nuevo.comentarioP;
                TextBox3.Text = nuevo.valoracionP.ToString();
                TextBox1.Text = nuevo.Usuario_correoP;
            }
        }

        protected void Comentar_Click(object sender, EventArgs e)
        {
            int id= Convert.ToInt32(Request.QueryString["id"]);
            Response.Redirect("Comentar.aspx?id=" + id.ToString());
        }
    }
}