using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iquea
{
    public class CADPedido
    {
        public string constring;
        public CADPedido()
        {
            constring = "";
        }
        public bool leerPedido(ENPedido pedido)
        {
            SqlConnection conexion = null;
            bool creado = false;
            try
            {
                conexion = new SqlConnection(constring);
                conexion.Open();
                String comando = "Select * FROM iquea.Pedido WHERE id = '" + pedido.getID() + "'";
                SqlCommand ejecucion = new SqlCommand(comando, conexion);
                SqlDataReader leer = ejecucion.ExecuteReader();
                leer.Read();
                pedido.setImporte(Convert.ToInt32(leer["importe"]));
                pedido.setRecibo(leer["importe"].ToString());
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
        public bool crearPedido(ENPedido pedido)
        {
            SqlConnection conexion = null;
            bool creado = false;
            try
            {
                conexion = new SqlConnection(constring);
                conexion.Open();
                String comando = "Insert INTO iquea.Pedido (id, importe, recibo) VALUES (" + pedido.getID() + " , " + pedido.getImporte() + " , " + pedido.getRecibo() + ")";
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
        public bool actualizarPedido(ENPedido pedido)
        {
            SqlConnection conexion = null;
            bool creado = false;
            try
            {
                conexion = new SqlConnection(constring);
                conexion.Open();
                String comando = "UPDATE iquea.Pedido SET importe = '" + pedido.getImporte() + "' , recibo = '" + pedido.getRecibo() + "' WHERE id = '" + pedido.getID() + "'";
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
        public bool borrarPedido(ENPedido pedido)
        {
            SqlConnection conexion = null;
            bool creado = false;
            try
            {
                conexion = new SqlConnection(constring);
                conexion.Open();
                String comando = "DELETE FROM iquea.Pedido WHERE id = '" + pedido.getID() + "'";
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
