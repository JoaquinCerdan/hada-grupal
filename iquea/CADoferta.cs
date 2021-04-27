using System;

public class CADoferta
{
	private string constring;

	public CADoferta()
	{
        constring = "";
    }

    public bool createOferta(ENoferta oferta)
    {
        bool respuesta = false;
        SqlConnection a = new SqlConnection(constring);
        try
        {
            a.Open();
            String orden = "Insert Into iquea.oferta (id, descuento, fechaValidez) VALUES ('"+en.idP+"' , '" + en.descuentoP + "' , '" + en.fechaValidezP + ")";
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

    public bool readOferta(ENoferta oferta)
    {
        bool respuesta = false;
        SqlConnection a = new SqlConnection(constring);

        try
        {
            a.Open();
            SqlCommand comando = new SqlCommand("Select * from iquea.oferta where id = '" + en.idP + "'" , a);
            SqlDataReader dr = comando.ExecuteReader();

            dr.Read();
            en.descuento = dr["descuento"].ToString();
            en.fechaValidez = Convert.ToDateTime(dr["fechaValidez"]);

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

    public bool deleteOferta(ENoferta oferta)
    {
        bool respuesta = false; 
        SqlConnection a = new SqlConnection(constring);
        try
        {
            a.Open();
            SqlCommand comando = new SqlCommand("DELETE FROM iquea.oferta WHERE id = '" + en.idP + "'", a);
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

    public bool updateOferta(ENoferta oferta)
    {
        bool respuesta = false;
        SqlConnection a = new SqlConnection(constring);
        try
        {
            a.Open();
            SqlCommand comando = new SqlCommand("UPDATE iquea.oferta SET descuento = '" + en.descuentoP + "' , fechaValidez = '" + en.fechaValidezP + "' WHERE id = '" + en.idP + "'", a);
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
