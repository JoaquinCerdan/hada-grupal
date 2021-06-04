using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace iqueaWeb
{
    public partial class Lista_deseos : System.Web.UI.Page
    {
        SqlConnection c = new SqlConnection();
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

        void Load_GridData()
        {
            try
            {
                c.Open();
                SqlDataAdapter sqa = new SqlDataAdapter("Select * From [dbo].[Articulo] where Articulo.Temporada='Moderno'", c);
                DataSet ds = new DataSet();
                sqa.Fill(ds);
                GridView.DataSource = ds;
                GridView.DataBind();
            }
            catch (Exception e)
            {
                Console.WriteLine("The operation has failed.Error: {0}", e.Message);
            }
            finally
            {
                c.Close();
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void GridView_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            
            
        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("Carrito.aspx" + GridView.SelectedRow.Cells[4].Text);
        }
    }
}