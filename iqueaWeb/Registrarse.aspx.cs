using System;

namespace iqueaWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
                etiqueta.Text= "error1";
                throw new Exception("El correo dado ya esta identificado dentro de la web");
            }
            if (Correo.Text == null || Nombre.Text == null || Contraseña1.Text == null || Contraseña2.Text==null || Direccion.Text==null || Telefono.Text==null || Banco.Text==null)
            {
                etiqueta.Text = "error2";
                throw new Exception("Los datos dados son insuficientes.");
            }
            else if (Contraseña1.Text != Contraseña2.Text)
            {
                etiqueta.Text = "error3";
                throw new Exception("Las contraseñas no son iguales");
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
                    usuario.stringDatosBancarios = "ES"+Banco.Text;
                    usuario.intNumTelefono = Convert.ToInt32(Telefono.Text);


                    caso = usuario.createUsuario();

                    if (caso == true)
                    {
                        etiqueta.Text = "Creado correctamente ";
                        throw new Exception("los datos han sido guardados con exito.");
                    }
                    else
                    {
                        etiqueta.Text = "error5";
                        throw new Exception("no se han podido almacenar los datos.");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                }
            }
        }
    }
}