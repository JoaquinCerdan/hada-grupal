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
        public void setImporte(int importe)
        {
            this.importe = importe;
        }
        public void setRecibo(string recibo)
        {
            this.recibo = recibo;
        }
        public ENPedido(){
            this.importe = 0;
            this.recibo = "";
        }
        public ENPedido(double importe, string recibo){
            this.importe = importe;
            this.recibo = recibo;
        }
        public bool leerPedido()
        {
            bool creado = false;
            CADPedido pedido = new CADPedido();
            creado = pedido.leerPedido(this);
            return creado;
        }
        public bool crearPedido()
        {
            
            bool creado = false;
            CADPedido pedido = new CADPedido();
            creado = pedido.crearPedido(this);
            return creado;
        }
        public bool actualizarPedido()
        {
            bool creado = false;
            CADPedido pedido = new CADPedido();
            creado = pedido.actualizarPedido(this);
            return creado;
        }
        public bool borrarPedido()
        {
            bool creado = false;
            CADPedido pedido = new CADPedido();
            creado = pedido.borrarPedido(this);
            return creado;
        }
    }
}
