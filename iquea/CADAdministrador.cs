using System;
using System.Configuration;
using System.Data.SqlClient;


    class CADAdministrador
    {
        private string constring;

        /*
         * Inicialización de la cadena de conexión
         */
        public CADAdministrador()
        {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }

        /*
         * Método que inserta en la base de datos un nuevo administrador, en caso de 
         * no conseguirlo se lanza una excepción
         */
        public bool createAdministrador(ENAdministrador administrador)
        {
            SqlConnection conexion = null;
            bool creado = false;
            try
            {
                conexion = new SqlConnection(constring);
                conexion.Open();
                String comando = "Insert INTO iquea.Administrador (codigo,correo) VALUES (" + administrador.intcodigo + ",'"+administrador.StringCorreo+"')";
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
         * Método que lee de la base de datos un administrador en concreto, en caso de 
         * no conseguirlo se lanza una excepción
         */
        public bool readAdministrador(ENAdministrador administrador)
        {
            SqlConnection conexion = null;
            bool creado = false;
            try
            {
                conexion = new SqlConnection(constring);
                conexion.Open();
                String comando = "Select * FROM iquea.Administrador WHERE codigo = " + administrador.intcodigo ;
                SqlCommand ejecucion = new SqlCommand(comando, conexion);
                SqlDataReader leer = ejecucion.ExecuteReader();
                leer.Read();
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
         * Método que borra de la base de datos un administrador en concreto, en caso de 
         * no conseguirlo se lanza una excepción
         */
        public bool deleteAdministrador(ENAdministrador administrador)
        {
            SqlConnection conexion = null;
            bool creado = false;
            try
            {
                conexion = new SqlConnection(constring);
                conexion.Open();
                String comando = "DELETE FROM iquea.Administrador WHERE codigo = " + administrador.intcodigo ;
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
         * Método que actualiza la información de la base de datos sobre un administrador en concreto, en caso de 
         * no conseguirlo se lanza una excepción
         */
        public bool updateAdministrador(ENAdministrador administrador)
        {
            SqlConnection conexion = null;
            bool creado = false;
            try
            {
                conexion = new SqlConnection(constring);
                conexion.Open();
                SqlCommand comando = new SqlCommand("UPDATE iquea.Usuario SET correo = '" + administrador.StringCorreo + "' WHERE codigo = " + administrador.intcodigo , conexion);
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