using System;

namespace iqueaWeb
{
    public partial class Lista_deseos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                //si no hay alguien logeado se le envia directamente a la pagina de login
                Response.Redirect("Login.aspx");
            }
            else
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}