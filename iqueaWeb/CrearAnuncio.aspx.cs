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


        protected void Button1_Click(object sender, EventArgs e)
        {
            ENAnuncio en = new ENAnuncio();
            en.stringDescripcion = TextBox2.Text;
            en.stringEnlace = TextBox3.Text;
            en.createAnuncio();
        }

    }
}