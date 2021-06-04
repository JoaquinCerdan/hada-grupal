using System;
using System.Configuration;
using System.Data.SqlClient;

namespace iqueaWeb
{
    public partial class Login : System.Web.UI.Page
    {
        //cadena de conexion
        public static string constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        public SqlConnection cn = new SqlConnection(constring);
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["email"] != null)
            {
                //si ya hay alguien logeado se le envia directamente a la pagina de usuario
                Response.Redirect("Usuario.aspx");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            cn.Open();
            string query = "select count(*) from Usuarios where email= @usuario and contra = @password";
            SqlCommand cm = new SqlCommand(query, cn);
            cm.Parameters.AddWithValue("@usuario", inputEmail.Text);
            cm.Parameters.AddWithValue("@password", inputPassword.Text);
            //Si existe un usuario con los datos retorna true, caso contrario false
            bool correcto = Convert.ToInt32(cm.ExecuteScalar()) > 0;

            if (correcto)
            {
                //Si existe, Bienvenido...
                Session.Add("email", inputEmail.Text);
                Response.Redirect("Usuario.aspx");

            }
            else
            {
                Label1.Text = "Su usuario o contraseña incorrecta ";
                inputEmail.Text = "";
                inputPassword.Text = "";
                inputEmail.Focus();

            }
            cn.Close();
        }
        //Te intenta logear para entrar como administrador 
        protected void admin_Click(object sender, EventArgs e)
        {
            ENAdministrador admin = new ENAdministrador();
            admin.stringcodigo = Administrador.Text;

            bool caso = admin.readAdministrador();

            if (caso == true)
            {
                Session.Add("codigo", admin.stringcodigo);
                Response.Redirect("Administrador.aspx");
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }

        protected void Admin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}