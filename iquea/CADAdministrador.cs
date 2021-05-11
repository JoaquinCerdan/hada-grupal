using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iquea
{
    class CADAdministrador
    {
        private string constring;

        public CADAdministrador()
        {
            constring = "";
        }

        public bool createAdministrador(ENAdministrador administrador)
        {
            SqlConnection conexion = null;
            bool creado = false;
            try
            {
                conexion = new SqlConnection(constring);
                conexion.Open();
                String comando = "Insert INTO iquea.Administrador (id) VALUES (" + administrador.intId + ")";
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

        public bool readAdministrador(ENAdministrador administrador)
        {
            SqlConnection conexion = null;
            bool creado = false;
            try
            {
                conexion = new SqlConnection(constring);
                conexion.Open();
                String comando = "Select * FROM iquea.Administrador WHERE id = '" + administrador.intId + "'";
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

        public bool deleteAdministrador(ENAdministrador administrador)
        {
            SqlConnection conexion = null;
            bool creado = false;
            try
            {
                conexion = new SqlConnection(constring);
                conexion.Open();
                String comando = "DELETE FROM iquea.Administrador WHERE id = '" + administrador.getId() + "'";
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

        public bool updateAdministrador(ENAdministrador administrador)
        {
            SqlConnection conexion = null;
            bool creado = false;
            try
            {
                conexion = new SqlConnection(constring);
                conexion.Open();
                SqlCommand comando = new SqlCommand("UPDATE iquea.Usuario SET id = '" + administrador.intID + "' WHERE id = '" + administrador.intID + "'", conexion);
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
}
