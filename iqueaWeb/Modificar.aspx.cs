using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iqueaWeb
{
    public partial class Modificar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                //si no hay alguien logeado se le envia directamente a la pagina de login
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            ENUsuario usuario = new ENUsuario();
            usuario.stringEmail = Session["email"].ToString();
            usuario.stringContra = Contraseña1.Text;
            usuario.stringDireccion = Direccion.Text;
            usuario.stringDatosBancarios = Banco.Text;
            usuario.stringNombre = Nombre.Text;
            usuario.intNumTelefono =Convert.ToInt32(Telefono.Text);

            bool caso=usuario.updateUsuario();

            if (caso == true)
            {
                Response.Redirect("Usuario.aspx");
            }
            else
            {
            }
        }
    }
}