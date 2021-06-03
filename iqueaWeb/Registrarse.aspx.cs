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
            bool prueba;
            ENUsuario todosUsuarios = new ENUsuario();
            string emailAux = Correo.Text;


            prueba = todosUsuarios.readUsuarioWithEmail(emailAux);

            if (prueba == true)
            {
                etiqueta.Text = "El correo dado ya esta identificado dentro de la web.";
            }
            if (Correo.Text == null || Nombre.Text == null || Contraseña1.Text == null || Contraseña2.Text == null || Direccion.Text == null || Telefono.Text == null || Banco.Text == null)
            {
                etiqueta.Text = "Los datos dados son insuficientes.";
            }
            else if (Contraseña1.Text != Contraseña2.Text)
            {
                etiqueta.Text = "Las contraseñas no son iguales";
            }
            else
            {
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


                    if (etiqueta.Text != "El correo dado ya esta identificado dentro de la web." &&
                       etiqueta.Text != "Los datos dados son insuficientes." &&
                       etiqueta.Text != "Las contraseñas no son iguales.")
                    {
                        Response.Redirect("Login.aspx");
                    }

                    if (caso == true)
                    {
                        Response.Redirect("Login.aspx");
                    }
                    else
                    {
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
}