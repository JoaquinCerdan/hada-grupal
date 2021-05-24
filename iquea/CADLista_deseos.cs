
using System;
using System.Configuration;
using System.Data.SqlClient;


public class CADLista_deseos
{
    private String constring;
    public CADLista_deseos()
    {
        constring = ConfigurationManager.ConnectionStrings["Database"].ToString(); ;
    }


    public bool createLista_deseos(ENLista_deseos list)
    {
        bool create = false;
        SqlConnection c = new SqlConnection(constring);
        try
        {
            c.Open();
            SqlCommand com = new SqlCommand("Insert INTO [dbo].[Lista_deseos] (Id,Id_art,Id_user) VALUES('" + list.intId + "', '" + list.intId_articulo + "','" + list.intId_user + "')", c);

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
    public bool readLista_deseos(ENLista_deseos list)
    {
        bool read = false;
        SqlConnection c = new SqlConnection(constring);
        try
        {
            c.Open();
            SqlCommand com = new SqlCommand("Select * From [dbo].[Lista_deseos] Where Id = '" + list.intId + "' ", c);
            SqlDataReader dr = com.ExecuteReader();
            dr.Read();

            if (dr["Id"].ToString() == list.intId.ToString())
            {
                list.intId = int.Parse(dr["Id"].ToString());
                list.intId_articulo = int.Parse(dr["Id_art"].ToString());
                list.intId_user = int.Parse(dr["Id_user"].ToString());
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
    public bool updateLista_deseos(ENLista_deseos list)
    {
        bool update = false;


        SqlConnection c = new SqlConnection(constring);
        try
        {
            c.Open();
            SqlCommand com = new SqlCommand("UPDATE [dbo].[Lista_usuarios] SET Id_art= '" + list.intId_articulo + "' ,Id_user=" + list.intId_user + "WHERE Id = '" + list.intId + "'", c);
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
    public bool deleteLista_deseos(ENLista_deseos list)
    {
        bool delete = false;

        SqlConnection c = new SqlConnection(constring);
        try
        {

            c.Open();
            SqlCommand com = new SqlCommand("DELETE FROM [dbo].[Lista_deseos] WHERE Id = '" + list.intId + "'", c);
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
