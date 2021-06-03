using System;
using System.Configuration;
using System.Data.SqlClient;

public class CADLin_carrito
{
    private string constring;

    public CADLin_carrito()
    {
        constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
    }

    public bool createLin_carrito(ENLin_carrito lin_carrito)
    {
        SqlConnection conn = null;
        bool creating = false;
        try
        {
            conn = new SqlConnection(constring);
            conn.Open();
            String comand = "Insert INTO [dbo].[Lin_carrito] (id, numArticulos) VALUES (" + lin_carrito.idP + " , " + lin_carrito.numArticulosP + ")";
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

    public bool deleteLin_carrito(ENLin_carrito lin_carrito)
    {
        bool creating = false;
        SqlConnection conn = null;

        try
        {
            conn = new SqlConnection(constring);
            conn.Open();
            string comand = "DELETE FROM [dbo].[Lin_carrito] WHERE id = " + lin_carrito.idP;
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

    public bool readLin_carrito(ENLin_carrito lin_carrito)
    {
        bool creating = false;
        SqlConnection conn = null;
        SqlDataReader searching = null;

        try
        {
            conn = new SqlConnection(constring);
            conn.Open();
            string comand = "Select * From [dbo].[Lin_carrito]";
            SqlCommand execution = new SqlCommand(comand, conn);
            searching = execution.ExecuteReader();
            searching.Read();
            do
            {
                if (String.Equals(searching["id"].ToString(), lin_carrito.idP))
                {
                    lin_carrito.idP = int.Parse(searching["id"].ToString());
                    lin_carrito.numArticulosP = int.Parse(searching["numArticulos"].ToString());
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

    public bool updateLin_carrito(ENLin_carrito lin_carrito)
    {
        bool creating = false;
        SqlConnection conn = null;

        try
        {
            conn = new SqlConnection(constring);
            conn.Open();
            string comand = "UPDATE [dbo].[Lin_carrito] SET numArticulos=" + lin_carrito.numArticulosP + "WHERE id = " + lin_carrito.idP;
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
