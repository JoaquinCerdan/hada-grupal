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
            String orden = "Insert Into iquea.oferta (cod, descuento, fechaValidez) VALUES ('"+en.codP+"' , '" + en.descuentoP + "' , '" + en.fechaValidezP + ")";
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
            SqlCommand comando = new SqlCommand("Select * from iquea.oferta where cod = '" + en.codP + "'" , a);
            SqlDataReader dr = comando.ExecuteReader();

            dr.Read();
            en.descuentoP = dr["descuento"].ToString();
            en.fechaValidezP = Convert.ToDateTime(dr["fechaValidez"]);

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
            SqlCommand comando = new SqlCommand("DELETE FROM iquea.oferta WHERE cod = '" + en.codP + "'", a);
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
            SqlCommand comando = new SqlCommand("UPDATE iquea.oferta SET descuento = '" + en.descuentoP + "' , fechaValidez = '" + en.fechaValidezP + "' WHERE cod = '" + en.codP + "'", a);
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
