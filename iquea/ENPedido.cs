using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iquea
{
    public class ENPedido
    {
        private int id;
        private double importe;
        private string recibo;
        public int getID(){
            return id;
        }
        public double getImporte(){
            return importe;
        }
        public string getRecibo(){
            return recibo;
        }
        public ENPedido(){

        }
        public ENPedido(int id, double importe, string recibo){

        }
        public bool leerPedido()
        {

        }
        public bool crearPedido()
        {

        }
        public bool actualizarPedido()
        {

        }
        public bool borrarPedido()
        {

        }
    }
}
