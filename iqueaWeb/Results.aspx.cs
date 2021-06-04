using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace iqueaWeb
{
    public partial class Results : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            //string absolutepath = HttpContext.Current.Request.Url.AbsoluteUri;
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ToString();
            string searchString = Request.QueryString["srch"];
            string searchPrice = Request.QueryString["price"];
            //etiqueta.Text = category;

            if(searchString != null)
                Load_GridData_nombre(searchString);
            if(searchPrice != null)
                Load_GridData_precio(searchPrice);
        }

        void Load_GridData_nombre(string searchString)
        {
            try
            {
                conn.Open();
                SqlDataAdapter sqa = new SqlDataAdapter("select * from [dbo].[Articulo] where Nombre like '" + searchString + "%' ", conn);
                DataSet ds = new DataSet();
                sqa.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    GridView.DataSource = ds;
                    GridView.DataBind();
                }
                else
                {
                    etiqueta.Text = "Error: No se han encontrado productos con ese nombre";
                }
                
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

        void Load_GridData_precio(string searchString)
        {
            try
            {
                conn.Open();
                SqlDataAdapter sqa = new SqlDataAdapter("select * from [dbo].[Articulo] where Precio like '" + searchString + "%'", conn);
                DataSet ds = new DataSet();
                sqa.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    GridView.DataSource = ds;
                    GridView.DataBind();
                }
                else
                {
                    etiqueta.Text = "Error: No se han encontrado productos con ese precio";
                }

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