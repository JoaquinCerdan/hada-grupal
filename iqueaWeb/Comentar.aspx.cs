using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iqueaWeb
{
    public partial class Comentar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                //si no hay alguien logeado se le envia directamente a la pagina de login
                Response.Redirect("Login.aspx");
            }
        }

        protected void Comentar_Click(object sender, EventArgs e)
        {
            ENcomentario comentario = new ENcomentario();
            comentario.Usuario_correoP = Session["email"].ToString();
            comentario.valoracionP = Valoracion.SelectedIndex;
            comentario.Articulo_idP= Convert.ToInt32(Request.QueryString["id"]);
            comentario.comentarioP = TextBox2.Text;

            bool caso = comentario.createComentario();

            if (caso == true)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Response.Redirect("articulo.aspx?id=" + id.ToString());
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }
    }
}