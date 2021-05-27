﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace iqueaWeb
{
    public partial class OrdenarC : System.Web.UI.Page
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
                SqlDataAdapter sqa = new SqlDataAdapter("Select * From [dbo].[Articulo]", conn);
                DataSet ds = new DataSet();
                sqa.Fill(ds);
                GridView.DataSource = ds;
                GridView.DataBind();
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }


        protected void GridView_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            int indexrow = int.Parse(e.CommandArgument.ToString());
            int id = int.Parse(e.CommandArgument.ToString())+1;
            Response.Redirect("articulo.aspx?id=" + id.ToString());
        }
    }
}