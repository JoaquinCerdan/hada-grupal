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
			SqlCommand com = new SqlCommand("Insert INTO [dbo].[Articulo] (Id,Nombre,Descripcion,Precio,Imagen,Stock,IdCategoria,Temporada) VALUES('"
				+ art.intId
				+ "', '"
				+ art.stringNombre
				+ "','"
				+ art.stringDescripcion
				+ "','"
				+ art.doublePrecio
				+ "','"
				+ art.stringImagen
				+ "','"
				+ art.intStock
				+ "','"
				+ art.stringCategoria
				+ "','"
				+ art.stringTemporada
				+ "')", c);

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
				+ "' ,IdCategoria=" + art.stringCategoria
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
			SqlCommand com = new SqlCommand("Select * From [dbo].[Articulo] Where Id = '" + art.intId + "' ", c);
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
				art.stringCategoria = dr["IdCategoria"].ToString();
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
}

