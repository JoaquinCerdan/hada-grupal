using System;
using System.Configuration;
using System.Data.SqlClient;

public class CADCarrito
{
    private string constring;

    public CADCarrito()
    {
        constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
    }

    public bool createCarrito(ENCarrito carrito)
    {
        SqlConnection conn = null;
        bool creating = false;
        try
        {
            conn = new SqlConnection(constring);
            conn.Open();
            String comand = "Insert INTO [dbo].[Carrito] (id, importe) VALUES (" + carrito.idP + " , " + carrito.importeP + ")";
            SqlCommand execution = new SqlCommand(comand, conn);
            execution.ExecuteNonQuery();
            creating = true;
        }
        catch (SqlException e)
        {
            Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            creating = false;
        }
        catch (Exception e)
        {
            Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            creating = false;
        }
        finally
        {
            if (conn != null)
                conn.Close();
        }
        return creating;
    }

    public bool deleteCarrito(ENCarrito carrito)
    {
        bool creating = false;
        SqlConnection conn = null;

        try
        {
            conn = new SqlConnection(constring);
            conn.Open();
            string comand = "DELETE FROM [dbo].[Carrito] WHERE id = " + carrito.idP;
            SqlCommand execution = new SqlCommand(comand, conn);
            execution.ExecuteNonQuery();
            creating = true;
        }
        catch (SqlException e)
        {
            Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            creating = false;
        }
        catch (Exception e)
        {
            Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            creating = false;
        }
        finally
        {
            if (conn != null)
                conn.Close();
        }
        return creating;
    }

    public bool readCarrito(ENCarrito carrito)
    {
        bool creating = false;
        SqlConnection conn = null;
        SqlDataReader searching = null;

        try
        {
            conn = new SqlConnection(constring);
            conn.Open();
            string comand = "Select * From [dbo].[Carrito]";
            SqlCommand execution = new SqlCommand(comand, conn);
            searching = execution.ExecuteReader();
            searching.Read();
            do
            {
                if (String.Equals(searching["id"].ToString(), carrito.idP))
                {
                    carrito.idP = int.Parse(searching["id"].ToString());
                    carrito.importeP = int.Parse(searching["importe"].ToString());
                    creating = true;
                }
            } while (searching.Read());
        }
        catch (SqlException e)
        {
            Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            creating = false;
        }
        catch (Exception e)
        {
            Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            creating = false;
        }
        finally
        {
            if (searching != null)
                searching.Close();
            if (conn != null)
                conn.Close();
        }
        return creating;
    }

    public bool updateCarrito(ENCarrito carrito)
    {
        bool creating = false;
        SqlConnection conn = null;

        try
        {
            conn = new SqlConnection(constring);
            conn.Open();
            string comand = "UPDATE [dbo].[Carrito] SET importe=" + carrito.importeP + "WHERE id = " + carrito.idP;
            SqlCommand execution = new SqlCommand(comand, conn);
            execution.ExecuteNonQuery();
            creating = true;
        }
        catch (SqlException e)
        {
            Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            creating = false;
        }
        catch (Exception e)
        {
            Console.WriteLine("User operation has failed.Error: {0}", e.Message);
            creating = false;
        }
        finally
        {
            if (conn != null)
                conn.Close();
        }
        return creating;
    }
}

