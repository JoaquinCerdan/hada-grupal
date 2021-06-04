using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace iqueaWeb
{
    public partial class Interior : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ToString(); ;
            Load_GridData();

        }
        //Se rellena el gridview con los datos de la secuencia establecida en este método
        void Load_GridData()
        {
            try
            {
                conn.Open();
                SqlDataAdapter sqa = new SqlDataAdapter("Select * From [dbo].[Articulo]  where Categoria_id=0", conn);
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
        //Cuando se selecciona un articulo del gridview , te lleva a su página artículo donde se muestran todos los datos de este articulo 
        protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ENArticulo articulo = new ENArticulo();
            articulo.stringNombre = GridView.SelectedRow.Cells[1].Text.ToString();

            bool caso = articulo.obtenerId();

            if (caso == true)
            {
                int id = articulo.intId;
                Response.Redirect("articulo.aspx?id=" + id.ToString());
            }
            else
            {
                Response.Redirect("index.aspx?id=" + articulo.stringNombre);
            }

        }

        /*protected void GridView_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            ENArticulo articulo = new ENArticulo();
            articulo.stringNombre = GridView.SelectedRow.Cells[0].Text;

            bool caso = articulo.obtenerId();

            if (caso == true)
            {
                int id = articulo.intId;
                Response.Redirect("articulo.aspx?id=" + id.ToString());
            }
            else
            {
                Response.Redirect("index.aspx?id="+ articulo.stringNombre);
            }


            //int indexrow = int.Parse(e.CommandArgument.ToString());
            //int id = int.Parse(e.CommandArgument.ToString()) ;
        }*/
    }
}