
    public class ENPedido
    {
        private int id;
        private double importe;
        private string recibo;
        private static int nextIdP = 1;
        public int getID()
        {
            return id;
        }
        public double getImporte()
        {
            return importe;
        }
        public string getRecibo()
        {
            return recibo;
        }
        public void setImporte(int importe)
        {
            this.importe = importe;
            this.id = nextIdP;
            nextIdP++;
        }
        public void setRecibo(string recibo)
        {
            this.recibo = recibo;
        }
        public ENPedido()
        {
            this.importe = 0;
            this.recibo = "";
        }
        public ENPedido(double importe, string recibo)
        {
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
