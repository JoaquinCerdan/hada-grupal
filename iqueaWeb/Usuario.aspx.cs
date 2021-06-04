using System;

namespace iqueaWeb
{
    public partial class Formulario_web14 : System.Web.UI.Page
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
                ENUsuario usuario = new ENUsuario();
                usuario.stringEmail = Session["email"].ToString();

                //se intenta leer los datos del usuario
                bool caso = usuario.readUsuario();

                if (caso == true)
                {
                    //si se ha podido leer los datos del usuario se sacan por las etiquetas correspondientes
                    TextBox1.Text = usuario.stringNombre;
                    TextBox2.Text = usuario.stringEmail;
                    TextBox3.Text = usuario.stringContra;
                    TextBox4.Text = usuario.stringDatosBancarios;
                    TextBox5.Text = usuario.stringDireccion;
                    TextBox6.Text = usuario.intNumTelefono.ToString();
                }
                else
                {
                }
            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Modificar.aspx");
        }

        protected void Button_Click1(object sender, EventArgs e)
        {
            ENUsuario usuario = new ENUsuario();
            usuario.stringEmail = Session["email"].ToString();

            bool caso = usuario.deleteUsuario();

            if (caso == true)
            {
                Session.Abandon();
                Response.Redirect("Index.aspx");
            }
            else
            {
                throw new Exception("no se ha podido borrar el usuario");
            }

        }
    }
}