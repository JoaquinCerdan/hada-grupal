﻿using System;
using System.Configuration;
using System.Data.SqlClient;
public class CADLin_pedido
{
    public string constring;
    public CADLin_pedido()
    {
        constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
    }
    public bool leerLineaPedido(ENLin_pedido linped)
    {
        SqlConnection conexion = null;
        bool creado = false;
        try
        {
            conexion = new SqlConnection(constring);
            conexion.Open();
            String comando = "Select * FROM dbo.Lin_pedido WHERE id = '" + linped.getId() + "'";
            SqlCommand ejecucion = new SqlCommand(comando, conexion);
            SqlDataReader leer = ejecucion.ExecuteReader();
            leer.Read();
            linped.setNumArticulos(Convert.ToInt32(leer["numArticulos"]));
            leer.Close();
            conexion.Close();
            creado = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            creado = false;
        }
        finally
        {
            conexion.Close();
        }
        return creado;
    }
    public bool crearLineaPedido(ENLin_pedido linped)
    {
        SqlConnection conexion = null;
        bool creado = false;
        try
        {
            conexion = new SqlConnection(constring);
            conexion.Open();
            String comando = "Insert INTO dbo.Lin_pedido (id, numArticulos) VALUES (" + linped.getId() + " , " + linped.getNumArticulos() + ")";
            SqlCommand ejecucion = new SqlCommand(comando, conexion);
            ejecucion.ExecuteNonQuery();
            creado = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            creado = false;
        }
        finally
        {
            conexion.Close();
        }
        return creado;
    }
    public bool actualizarLineaPedido(ENLin_pedido linped)
    {
        SqlConnection conexion = null;
        bool creado = false;
        try
        {
            conexion = new SqlConnection(constring);
            conexion.Open();
            String comando = "UPDATE dbo.Lin_pedido SET numArticulos = '" + linped.getNumArticulos() + "' WHERE id = '" + linped.getId() + "'";
            SqlCommand ejecucion = new SqlCommand(comando, conexion);
            ejecucion.ExecuteNonQuery();
            creado = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            creado = false;
        }
        finally
        {
            conexion.Close();
        }
        return creado;
    }
    public bool borrarLineaPedido(ENLin_pedido linped)
    {
        SqlConnection conexion = null;
        bool creado = false;
        try
        {
            conexion = new SqlConnection(constring);
            conexion.Open();
            String comando = "DELETE FROM dbo.Lin_pedido WHERE id = '" + linped.getId() + "'";
            SqlCommand ejecucion = new SqlCommand(comando, conexion);
            ejecucion.ExecuteNonQuery();
            creado = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            creado = false;
        }
        finally
        {
            conexion.Close();
        }
        return creado;
    }
}
