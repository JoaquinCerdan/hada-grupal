using System;

namespace iqueaWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] != null)
            {
                //si no hay alguien logeado se le envia directamente a la pagina de login
                Response.Redirect("Login.aspx");
            }
        }

        protected void CrearUsuario_Click(object sender, EventArgs e)
        {
            bool caso;

            try
            {
                ENUsuario usuario = new ENUsuario();
                usuario.stringEmail = Correo.Text;
                usuario.stringContra = Contraseña1.Text;
                usuario.stringNombre = Nombre.Text;
                usuario.stringDireccion = Direccion.Text;
                usuario.stringDatosBancarios = "ES" + Banco.Text;
                usuario.intNumTelefono = Convert.ToInt32(Telefono.Text);


                caso = usuario.createUsuario();

                if (caso == true)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    Response.Redirect("Index.aspx");
                    throw new Exception("no se han podido almacenar los datos.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
            }
        }
    }
}