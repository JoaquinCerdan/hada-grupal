using System;

namespace iqueaWeb
{
    public partial class Formulario_web31 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["codigo"] == null)
            {
                //si no hay alguien logeado se le envia directamente a la pagina de login
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ENCategoria en = new ENCategoria();
            en.stringNombre = TextBox2.Text;
            en.stringDescripcion = TextBox3.Text;
            



            bool creado = en.createCategoria();
            if (creado)
            {
                etiqueta.Text = "Creado correctamente ";
            }
            else
            {
                etiqueta.Text = "error " + en.intId + en.stringNombre + en.stringDescripcion ;
            }
        }
    }
}