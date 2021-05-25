public class ENLin_pedido
{
    private int numArticulos;
    private int id;
    private static int nextIdLP = 1;

    public int getId()
    {
        return id;
    }
    public int getNumArticulos()
    {
        return numArticulos;
    }
    public void setNumArticulos(int numArticulos)
    {
        this.numArticulos = numArticulos;
    }
    public ENLin_pedido()
    {
        this.id = nextIdLP;
        nextIdLP++;
        this.numArticulos = 0;
    }
    public ENLin_pedido(int numArticulos)
    {
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
