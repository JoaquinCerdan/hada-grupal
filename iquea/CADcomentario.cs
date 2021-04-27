using System;

public class CADcomentario
{
	private string constring;

	public CADcomentario()
	{
        constring = "";
	}

    public bool createComentario(ENcomentario oferta)
    {
        bool respuesta = false;
        SqlConnection a = new SqlConnection(constring);
        try
        {
            a.Open();
            String orden = "Insert Into iquea.comentario (id, comentario, valoracion) VALUES ('" + en.idP + "' , '" + en.comentarioP + "' , '" + en.valoracionP + ")";
            SqlCommand comando = new SqlCommand(orden, a);
            comando.ExecuteNonQuery();

            respuesta = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            return false;
        }

        finally
        {
            a.Close();
        }

        return respuesta;
    }

    public bool readComentario(ENcomentario oferta)
    {
        bool respuesta = false;
        SqlConnection a = new SqlConnection(constring);

        try
        {
            a.Open();
            SqlCommand comando = new SqlCommand("Select * from iquea.comentario where id = '" + en.idP + "'", a);
            SqlDataReader dr = comando.ExecuteReader();

            dr.Read();
            en.comentarioP = dr["comentario"].ToString();
            en.valoracionP = Convert.ToInt32(dr["valoracion"]);

            dr.Close();
            a.Close();
            respuesta = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            return false;
        }

        finally
        {
            a.Close();
        }

        return respuesta;
    }

    public bool deleteComentario(ENcomentario oferta)
    {
        bool respuesta = false;
        SqlConnection a = new SqlConnection(constring);
        try
        {
            a.Open();
            SqlCommand comando = new SqlCommand("DELETE FROM iquea.comentario WHERE id = '" + en.idP + "'", a);
            comando.ExecuteNonQuery();

            respuesta = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            return false;
        }

        finally
        {
            a.Close();
        }

        return respuesta;
    }

    public bool updateComentario(ENcomentario oferta)
    {
        bool respuesta = false;
        SqlConnection a = new SqlConnection(constring);
        try
        {
            a.Open();
            SqlCommand comando = new SqlCommand("UPDATE iquea.comentario SET comentario = '" + en.comentarioP + "' , valoracion = '" + en.valoracionP + "' WHERE id = '" + en.idP + "'", a);
            comando.ExecuteNonQuery();

            respuesta = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("User operation has failed. Error: {0}", e.Message);
            return false;
        }

        finally
        {
            a.Close();
        }

        return respuesta;
    }
}
