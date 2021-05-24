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


public class CADAnuncio
{
    public String constring;
    public CADAnuncio()
    {
        constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
    }


    public bool createAnuncio(ENAnuncio anun)
    {
        bool create = false;
        SqlConnection c = new SqlConnection(constring);
        try
        {
            c.Open();
            SqlCommand com = new SqlCommand("Insert INTO [dbo].[Usuarios] (nombre,nif,edad) VALUES('" + en.stringNombre + "', '" + en.stringNIF + "','" + en.intEdad + "')", c);

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
    public bool readAnuncio(ENAnuncio anun)
    {
        return false;
    }
    public bool updateAnuncio(ENAnuncio anun)
    {
        return false;
    }

    public bool deleteAnuncio(ENAnuncio anun)
    {
        return false;
    }


}
