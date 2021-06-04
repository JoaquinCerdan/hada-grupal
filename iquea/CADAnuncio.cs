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
            SqlCommand com = new SqlCommand("Insert INTO Anuncio(Id,Enlace,Descripcion) VALUES('" + anun.intId + "', '" + anun.stringEnlace + "','" + anun.stringDescripcion + "')", c);

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
        bool read = false;
        SqlConnection c = new SqlConnection(constring);
        try
        {
            c.Open();
            SqlCommand com = new SqlCommand("Select * From [dbo].[Anuncio] Where Id = '" + anun.intId + "' ", c);
            SqlDataReader dr = com.ExecuteReader();
            dr.Read();

            if (dr["Id"].ToString() == anun.intId.ToString())
            {
                anun.intId = int.Parse(dr["Id"].ToString());
                anun.stringEnlace = dr["Enlace"].ToString();
                anun.stringDescripcion = dr["Descripcion"].ToString();
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
    public bool updateAnuncio(ENAnuncio anun)
    {
        bool update = false;


        SqlConnection c = new SqlConnection(constring);
        try
        {
            c.Open();
            SqlCommand com = new SqlCommand("UPDATE [dbo].[Anuncio] SET Enlace= '" + anun.stringEnlace + "' ,Descripcion='" + anun.stringDescripcion + "'WHERE Id = " + anun.intId, c);
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

    public bool deleteAnuncio(ENAnuncio anun)
    {
        bool delete = false;

        SqlConnection c = new SqlConnection(constring);
        try
        {

            c.Open();
            SqlCommand com = new SqlCommand("DELETE FROM [dbo].[Anuncio] WHERE Id = '" + anun.intId + "'", c);
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
        int idNuevo = 0;
        SqlConnection conec = new SqlConnection(constring);
        try
        {
            conec.Open();
            SqlCommand consulta = new SqlCommand("Select max(Id) maxId,Count(Id) numRows from dbo.Anuncio", conec);

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
    }


}
