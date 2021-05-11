using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

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
		return false;
	}

	public bool updateArticulo(ENArticulo art)
	{
		return false;
	}

	public bool readArticulo(ENArticulo art)
	{
		return false;
	}

	public bool deleteArticulo(ENArticulo art)
	{
		return false;
	}

}
