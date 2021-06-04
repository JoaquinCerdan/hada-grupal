using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

/// <summary>
/// Summary description for CADArticulo
/// </summary>
public class CADArticulo
{

	public string constring;

	public CADArticulo()
	{
		constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
	}

	public bool createArticulo(ENArticulo art)
	{
		bool create = false;
		SqlConnection c = new SqlConnection(constring);
		try
		{
			c.Open();
			
			SqlCommand com = new SqlCommand("Insert INTO [dbo].[Articulo] (Id,Nombre,Descripcion,Precio,Imagen,Stock,temporada,Categoria_id) VALUES("
				+ ENArticulo.NextID
				+ ", '"
				+ art.stringNombre
				+ "','"
				+ art.stringDescripcion
				+ "',"
				+ Convert.ToDecimal(art.doublePrecio)
				+ ",'"
				+ art.stringImagen
				+ "',"
				+ art.intStock
				+ ",'"
				+ art.stringTemporada
				+ "',"
				+ art.intCategoria
				+ ")", c);

			com.ExecuteNonQuery();
			create = true;


		}
		catch (SqlException e)
		{
			create = false;
			Console.WriteLine("User operation has failed.Error: {0}", e.Message);

		}

		finally
		{
			c.Close();
		}
		ENArticulo.NextID++;
		return create;
	}

	public bool updateArticulo(ENArticulo art)
	{
		bool update = false;


		SqlConnection c = new SqlConnection(constring);
		try
		{
			c.Open();
			SqlCommand com = new SqlCommand("UPDATE [dbo].[Articulo] "
				+ "SET Nombre= '" + art.stringNombre
				+ "' ,Descripcion=" + art.stringDescripcion
				+ "' ,Precio=" + art.doublePrecio
				+ "' ,Imagen=" + art.stringImagen
				+ "' ,Stock=" + art.intStock
				+ "' ,IdCategoria=" + art.intCategoria
				+ "' ,Temporada=" + art.stringTemporada
				+ "WHERE Id = '" + art.intId + "'", c);
			com.ExecuteNonQuery();

			update = true;

			c.Close();


		}
		catch (SqlException e)
		{
			update = false;
			Console.WriteLine("User operation has failed.Error: {0}", e.Message);

		}
		return update;
	}

	public bool readArticulo(ENArticulo art)
	{
		bool read = false;
		SqlConnection c = new SqlConnection(constring);
		try
		{
			c.Open();
			SqlCommand com = new SqlCommand("Select * From [dbo].[Articulo] Where Id = " + art.intId , c);
			SqlDataReader dr = com.ExecuteReader();
			dr.Read();

			art.stringNombre = dr["Nombre"].ToString();
			art.stringDescripcion = dr["Descripcion"].ToString();
			art.doublePrecio = Convert.ToDouble(dr["Precio"]);
			art.stringImagen = dr["Imagen"].ToString();
			art.intStock = Convert.ToInt32(dr["Stock"]);
			art.intCategoria = Convert.ToInt32(dr["Categoria_id"]);
			art.stringTemporada = dr["temporada"].ToString();
			read = true;

			dr.Close();

		}
		catch (SqlException e)
		{
			read = false;
			Console.WriteLine("User operation has failed.Error: {0}", e.Message);

		}
		catch (Exception e)
		{
			read = false;
			Console.WriteLine("User operation has failed.Error: {0}", e.Message);
		}

		finally
		{
			c.Close();
		}


		return read;
	}

	public bool deleteArticulo(ENArticulo art)
	{
		bool delete = false;

		SqlConnection c = new SqlConnection(constring);
		try
		{

			c.Open();
			SqlCommand com = new SqlCommand("DELETE FROM [dbo].[Articulo] WHERE Id = '" + art.intId + "'", c);
			com.ExecuteNonQuery();
			delete = true;
			c.Close();
		}
		catch (SqlException e)
		{
			delete = false;
			Console.WriteLine("User operation has failed.Error: {0}", e.Message);
		}
		catch (Exception e)
		{
			delete = false;
			Console.WriteLine("User operation has failed.Error: {0}", e.Message);
		}
		return delete;
	}


	public int obtenerId()
	{
<<<<<<< HEAD
		return ENArticulo.NextID;
=======
		int idNuevo = 0;
		SqlConnection conec = new SqlConnection(constring);
		try
		{
			conec.Open();
			SqlCommand consulta = new SqlCommand("Select max(Id) maxId,Count(Id) numRows from [dbo].[Articulo]", conec);

			SqlDataReader dr = consulta.ExecuteReader();
			dr.Read();

			if (int.Parse(dr["numRows"].ToString()) != 0)
            {
				idNuevo = Convert.ToInt32(dr["maxId"]) + 1;
			}
			dr.Close();
			

		}
		catch (SqlException ex)
		{
			Console.WriteLine("The operation has failed.Error: {0}", ex.Message);
		}
		finally
		{
			conec.Close();
		}

		return idNuevo;
>>>>>>> f456ca0874be5f4138165dceffe1363da04fa35a
	}

	public bool getArticulos(ENArticulo art, string searchString)
	{
		bool read = false;
		SqlConnection c = new SqlConnection(constring);
		try
		{
			c.Open();
			SqlCommand com = new SqlCommand("select * from [dbo].[Articulo] where Nombre like '" + searchString + "%'", c);
			SqlDataReader dr = com.ExecuteReader();
			dr.Read();

			if (dr["Id"].ToString() == art.intId.ToString())
			{

				art.intId = int.Parse(dr["Id"].ToString());
				art.stringNombre = dr["Nombre"].ToString();
				art.stringDescripcion = dr["Descripcion"].ToString();
				art.doublePrecio = double.Parse(dr["Precio"].ToString());
				art.stringImagen = dr["Imagen"].ToString();
				art.intStock = int.Parse(dr["Stock"].ToString());
				art.intCategoria = int.Parse(dr["IdCategoria"].ToString());
				art.stringTemporada = dr["Temporada"].ToString();
				read = true;
			}
			else read = false;
			dr.Close();

		}
		catch (SqlException e)
		{
			read = false;
			Console.WriteLine("User operation has failed.Error: {0}", e.Message);

		}
		catch (Exception e)
		{
			read = false;
			Console.WriteLine("User operation has failed.Error: {0}", e.Message);
		}

		finally
		{
			c.Close();
		}


		return read;

	}
}

