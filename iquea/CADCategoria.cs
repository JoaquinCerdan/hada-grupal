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
/// Summary description for CADCategoria
/// </summary>
/// 
public class CADCategoria
{
	public string constring;

	public CADCategoria()
	{
		constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
	}

	public bool createCategoria(ENCategoria cat)
	{
		bool create = false;
		SqlConnection c = new SqlConnection(constring);
		try
		{
			c.Open();
			SqlCommand com = new SqlCommand("Insert INTO [dbo].[Categoria] (Id,Nombre,Descripcion) VALUES('"
				+ cat.intId
				+ "','"
				+ cat.stringNombre
				+ "','"
				+ cat.stringDescripcion
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

	public bool updateCategoria(ENCategoria cat)
	{
		bool update = false;

		SqlConnection c = new SqlConnection(constring);
		try
		{
			c.Open();
			SqlCommand com = new SqlCommand("UPDATE [dbo].[Categoria] SET Nombre= '" + cat.stringNombre + "' ,Descripcion=" + cat.stringDescripcion + "WHERE Id = '" + cat.intId + "'", c);
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

	public bool readCategoria(ENCategoria cat)
	{
		bool read = false;
		SqlConnection c = new SqlConnection(constring);
		try
		{
			c.Open();
			SqlCommand com = new SqlCommand("Select * From [dbo].[Categoria] Where Id = '" + cat.intId + "' ", c);
			SqlDataReader dr = com.ExecuteReader();
			dr.Read();

			if (dr["Id"].ToString() == cat.intId.ToString())
			{
				cat.intId = int.Parse(dr["Id"].ToString());
				cat.stringNombre = dr["Nombre"].ToString();
				cat.stringDescripcion = dr["Descripcion"].ToString();
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

	public bool deleteCategoria(ENCategoria cat)
	{
		bool delete = false;

		SqlConnection c = new SqlConnection(constring);
		try
		{

			c.Open();
			SqlCommand com = new SqlCommand("DELETE FROM [dbo].[Categoria] WHERE Id = '" + cat.intId + "'", c);
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
