using System;

namespace iqueaWeb
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["codigo"] == null)
            {
                //si no hay alguien logeado se le envia directamente a la pagina de login
                Response.Redirect("Login.aspx");
            }
        }

        //Cuando se pulsa el boton se crea el anuncio
        protected void Button1_Click(object sender, EventArgs e)
        {
            ENAnuncio en = new ENAnuncio();
            en.stringDescripcion = TextBox2.Text;
            en.stringEnlace = TextBox3.Text;
            en.createAnuncio();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            ENAnuncio en = new ENAnuncio();
            en.stringDescripcion = TextBox2.Text;
            en.stringEnlace = TextBox3.Text;
            bool result = en.createAnuncio();
            if(result == true)
            {
                Label1.Text = "Anuncio creado";
            }
            else
            {
                Label1.Text = "No se ha podido crear el Anuncio.";
            }
        }
    }
}