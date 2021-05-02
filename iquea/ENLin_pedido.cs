using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iquea
{
    public class ENLin_pedido
    {
        private int id;
        private int numArticulos;
        
        public int getId(){
            return id;
        }
        public int getNumArticulos(){
            return numArticulos;
        }
        public void setNumArticulos(int numArticulos)
        {
            this.numArticulos = numArticulos;
        }
        public ENLin_pedido(){
            this.numArticulos = 0;
        }
        public ENLin_pedido(int numArticulos){
            this.numArticulos = numArticulos;
        }
        public bool leerLineaPedido()
        {
            bool creado = false;
            CADLin_pedido pedido = new CADLin_pedido();
            creado = pedido.crearLineaPedido(this);
            return creado;
        }
        public bool crearLineaPedido()
        {
            bool creado = false;
            CADLin_pedido pedido = new CADLin_pedido();
            creado = pedido.leerLineaPedido(this);
            return creado;
        }
        public bool actualizarLineaPedido()
        {
            bool creado = false;
            CADLin_pedido pedido = new CADLin_pedido();
            creado = pedido.actualizarLineaPedido(this);
            return creado;
        }
        public bool borrarLineaPedido()
        {
            bool creado = false;
            CADLin_pedido pedido = new CADLin_pedido();
            creado = pedido.borrarLineaPedido(this);
            return creado;
        }
    }
}
