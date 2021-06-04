using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace iqueaWeb
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void Menu1_MenuItemClick1(object sender, MenuEventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            string s = ConfigurationManager.ConnectionStrings["Database"].ToString();
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand comando = new SqlCommand("Select * from dbo.Anuncio where Id = 1", con);
            SqlDataReader dr = comando.ExecuteReader();
            dr.Read();
            ImageButton1.PostBackUrl = dr["Enlace"].ToString();
            con.Close();
        }
    }
}