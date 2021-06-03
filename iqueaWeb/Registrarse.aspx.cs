using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
=======
>>>>>>> develop

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
<<<<<<< HEAD
=======

        protected void CrearUsuario_Click(object sender, EventArgs e)
        {
            bool caso;
            bool prueba;
            ENUsuario todosUsuarios = new ENUsuario();
            string emailAux = Correo.Text;
            

            prueba = todosUsuarios.readUsuarioWithEmail(emailAux);
            
            if (prueba == true)
            {
                throw new Exception("El correo dado ya esta identificado dentro de la web");
            }
            if (Correo.Text == null || Nombre.Text == null || Contraseña1.Text == null || Contraseña2.Text==null || Direccion.Text==null || Telefono.Text==null || Banco.Text==null)
            {
                throw new Exception("Los datos dados son insuficientes.");
            }
            else if (Contraseña1.Text != Contraseña2.Text)
            {
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
                    Response.Redirect("Login.aspx");

                    if (caso == true)
                    {
                        etiqueta.Text = "Creado correctamente ";
                        throw new Exception("los datos han sido guardados con exito.");

                        
                    }
                    else
                    {
                        throw new Exception("no se han podido almacenar los datos.");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("User operation has failed. Error: {0}", ex.Message);
                }
            }
        }
>>>>>>> develop
    }
}