using System;
using System.Configuration;
using System.Data.SqlClient;
public class CADUsuario
{
    private string constring;

    /*
     * Inicialización de la cadena de conexión
     */
    public CADUsuario()
    {
        constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
    }

    /*
     * Método que inserta en la base de datos un nuevo usuario, en caso de 
     * no conseguirlo se lanza una excepción
     */
    public bool createUsuario(ENUsuario usuario)
    {
        SqlConnection conexion = null;
        bool creado = false;
        try
        {
            conexion = new SqlConnection(constring);
            conexion.Open();
            String comando = "Insert INTO [dbo].[Usuarios] (email, contra, datosBancarios, nombre, direccion, numTelefono) VALUES ('" + usuario.stringEmail + "' , '" + usuario.stringContra + "' , '" + usuario.stringDatosBancarios + "' , '" + usuario.stringNombre + "' , '" + usuario.stringDireccion + "' , " + usuario.intNumTelefono + ")";
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

    /*
     * Método que lee de la base de datos un usuario en concreto, en caso de 
     * no conseguirlo se lanza una excepción
     */
    public bool readUsuario(ENUsuario usuario)
    {
        SqlConnection conexion = new SqlConnection(constring);
        bool creado = false;
        try
        {
            conexion.Open();
            SqlCommand ejecucion = new SqlCommand("Select * FROM [dbo].[Usuarios] where email = '" + usuario.stringEmail + "'", conexion);
            SqlDataReader leer = ejecucion.ExecuteReader();

            leer.Read();
            usuario.stringNombre = leer["nombre"].ToString();
            usuario.stringContra = leer["contra"].ToString();
            usuario.stringDireccion = leer["direccion"].ToString();
            usuario.stringDatosBancarios = leer["datosBancarios"].ToString();
            usuario.intNumTelefono = Convert.ToInt32(leer["numTelefono"]);
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

    /*
     * Método que borra de la base de datos un usuario en concreto, en caso de 
     * no conseguirlo se lanza una excepción
     */
    public bool deleteUsuario(ENUsuario usuario)
    {
        SqlConnection conexion = null;
        bool creado = false;
        try
        {
            conexion = new SqlConnection(constring);
            conexion.Open();
            String comando = "DELETE FROM [dbo].[Usuarios] WHERE email = '" + usuario.stringEmail + "'";
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

    /*
     * Método que actualiza la información de la base de datos sobre un usuario en concreto, en caso de 
     * no conseguirlo se lanza una excepción
     */
    public bool updateUsuario(ENUsuario usuario)
    {
        SqlConnection conexion = null;
        bool creado = false;

        try
        {
            conexion = new SqlConnection(constring);
            conexion.Open();
            SqlCommand comando = new SqlCommand("UPDATE [dbo].[Usuarios] SET contra = '" + usuario.stringContra + "' , datosBancarios = '" + usuario.stringDatosBancarios + "' , nombre = '" + usuario.stringNombre + "' , direccion = '" + usuario.stringDireccion + "' , numTelefono = " + usuario.intNumTelefono + " WHERE email = '" + usuario.stringEmail + "'", conexion);
            //SqlCommand ejecucion = new SqlCommand(comando, conexion);
            comando.ExecuteNonQuery();
            creado = true;
            conexion.Close();
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

    public bool readUsuarioWithEmail(String email)
    {

        bool leido = false;
        SqlConnection conec = new SqlConnection(constring);
        try
        {
            conec.Open();
            SqlCommand consulta = new SqlCommand("SELECT * FROM [dbo].[Usuarios] WHERE email = '" + email + "' ", conec);
            SqlDataReader dr = consulta.ExecuteReader();


            if (dr.HasRows)
                leido = true;
        }
        catch (SqlException ex)
        {
            Console.WriteLine("The operation has failed.Error: {0}", ex.Message);
        }
        catch (Exception exe)
        {
            Console.WriteLine("The operation has failed.Error: {0}", exe.Message);
        }
        finally
        {
            conec.Close();
        }
        return leido;
    }
}
