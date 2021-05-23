using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    public class CADUsuario
    {
        private string constring;

        /*
         * Inicialización de la cadena de conexión
         */
        public CADUsuario()
        {
            constring = "";
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
                String comando = "Insert INTO iquea.Usuario (email, contra, datosBancarios, nombre, direccion, numTelefono) VALUES (" + usuario.stringEmail + " , " + usuario.stringContra + " , " + usuario.stringDatosBancarios + " , " + usuario.stringNombre + " , " + usuario.stringDireccion + " , " + usuario.intNumTelefono + ")";
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
            SqlConnection conexion = null;
            bool creado = false;
            try
            {
                conexion = new SqlConnection(constring);
                conexion.Open();
                String comando = "Select * FROM iquea.Usuario WHERE email = '" + usuario.stringEmail + "'";
                SqlCommand ejecucion = new SqlCommand(comando, conexion);
                SqlDataReader leer = ejecucion.ExecuteReader();
                leer.Read();
                // Completar con ENUsuario usuario.setUsuario();
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
                String comando = "DELETE FROM iquea.Usuario WHERE email = '" + usuario.stringEmail + "'";
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
                SqlCommand comando = new SqlCommand("UPDATE iquea.Usuario SET email = '" + usuario.stringEmail + "' , contra = '" + usuario.stringContra + "' , datosBancarios = '" + usuario.stringDatosBancarios + "' , nombre = '" + usuario.stringNombre + "' , direccion = '" + usuario.stringDireccion + "' , numTelefono = '" + usuario.intNumTelefono + "' WHERE id = '" + usuario.stringEmail + "'", conexion);
                //SqlCommand ejecucion = new SqlCommand(comando, conexion);
                comando.ExecuteNonQuery();
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
