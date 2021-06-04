using System;

namespace iqueaWeb
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["codigo"] == null)
            {
                //si no hay alguien logeado se le envia directamente a la pagina de login
                Response.Redirect("Login.aspx");
            }
        }
        //se modifican los datos del anuncio 
        protected void Button1_Click(object sender, EventArgs e)
        {
            ENAnuncio en = new ENAnuncio();
            en.intId = int.Parse(TextBox2.Text);
            en.stringDescripcion = TextBox3.Text;
            en.stringEnlace = TextBox4.Text;
            bool result = en.updateAnuncio();
            if (result)
            {
                Label1.Text = "Anuncio Modificado.";
            }
            else
            {
                Label1.Text = "Anuncio no Modificado.";
            }
        }
    }
}