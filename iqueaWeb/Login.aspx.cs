using System;
using System.Configuration;
using System.Data.SqlClient;

namespace iqueaWeb
{
    public partial class Login : System.Web.UI.Page
    {
        //cadena de connecion
        public static string constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        public SqlConnection cn = new SqlConnection(constring);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            cn.Open();
            string query = "select count(*) from iquea.Usuario where email= @usuario and contra = @password";
            SqlCommand cm = new SqlCommand(query, cn);
            cm.Parameters.AddWithValue("@usuario", inputEmail.Text);
            cm.Parameters.AddWithValue("@password", inputPassword.Text);

            //Si existe un usuario con los datos retorna true, caso contrario false
            bool correcto = Convert.ToInt32(cm.ExecuteScalar()) > 0;

            if (correcto)
            {
                //Si existe, Bienvenido...
                Response.Redirect("home.aspx");

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
    }
}