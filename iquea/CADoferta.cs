
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

public class CADoferta
{
	private string constring;

	public CADoferta()
	{
        constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
    }

    public bool createOferta(ENoferta oferta)
    {
        bool respuesta = false;
        SqlConnection a = new SqlConnection(constring);
        try
        {
            a.Open();
            String orden = "Insert Into dbo.oferta (cod, descuento, fechaValidez) VALUES ('"+oferta.codP+"' , '" + oferta.descuentoP + "' , '" + oferta.fechaValidezP + ")";
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
            SqlCommand comando = new SqlCommand("Select * from dbo.oferta where cod = '" + oferta.codP + "'" , a);
            SqlDataReader dr = comando.ExecuteReader();

            dr.Read();
            oferta.descuentoP = dr["descuento"].ToString();
            oferta.descuentoP = Convert.ToDouble(dr["descuento"]);
            oferta.fechaValidezP = Convert.ToDateTime(dr["fechaValidez"]);

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
            SqlCommand comando = new SqlCommand("DELETE FROM dbo.oferta WHERE cod = '" + oferta.codP + "'", a);
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
            SqlCommand comando = new SqlCommand("UPDATE dbo.oferta SET descuento = '" + oferta.descuentoP + "' , fechaValidez = '" + oferta.fechaValidezP + "' WHERE cod = '" + oferta.codP + "'", a);
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