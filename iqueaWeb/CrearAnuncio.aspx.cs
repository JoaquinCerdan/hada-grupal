using System;

namespace iqueaWeb
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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