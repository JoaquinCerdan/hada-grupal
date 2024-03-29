﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace iqueaWeb
{
    public partial class Moderno : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ToString(); ;
            Load_GridData();

        }
        //Se cargan los datos en el gridview
        void Load_GridData()
        {
            try
            {
                conn.Open();
                SqlDataAdapter sqa = new SqlDataAdapter("Select * From [dbo].[Articulo] where temporada= 'Moderno' ", conn);
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
        //cuando se selecciona el artículo en el gridview se muestra la página del articulo con sus datos 
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
            int indexrow = int.Parse(e.CommandArgument.ToString());
            int id = int.Parse(e.CommandArgument.ToString()) ;
            Response.Redirect("articulo.aspx?id=" + id.ToString());
        }*/
    }
}