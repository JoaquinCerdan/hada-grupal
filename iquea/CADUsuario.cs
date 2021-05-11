using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iquea
{
    class CADUsuario
    {
        private string constring;

        public CADUsuario()
        {
            constring = "";
        }

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

        public bool updateUsuario(ENUsuario usuario)
        {
            SqlConnection conexion = null;
            bool creado = false;

            try
            {
                conexion = new SqlConnection(constring);
                conexion.Open();
                SqlCommand comando = new SqlCommand("UPDATE iquea.Usuario SET email = '" + usuario.stringEmail + "' , contra = '" + usuario.stringContra + "' , datosBancarios = '" + usuario.stringDatosBancarios + "' , nombre = '" + usuario.stringNombre + "' , direccion = '" + usuario.stringDireccion + "' , numTelefono = '" + usuario.intNumTelefono + "' WHERE id = '" + usuario.stringEmail + "'", conexion);
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
