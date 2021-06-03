using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace iqueaWeb
{
    public partial class Exterior : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ToString(); ;
            Load_GridData();

        }

        void Load_GridData()
        {
            try
            {
                conn.Open();
                SqlDataAdapter sqa = new SqlDataAdapter("Select * From [dbo].[Articulo] inner join [dbo].[Categoria] where Articulo.id=Categoria.articulo_id and Categoria.Nombre='exterior'", conn);
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
                conn.Close();
            }
        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            int indexrow = int.Parse(e.CommandArgument.ToString());
            int id = int.Parse(e.CommandArgument.ToString()) + 1;
            Response.Redirect("articulo.aspx?id=" + id.ToString());
        }
    }
}