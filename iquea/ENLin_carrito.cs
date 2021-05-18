using System;

public class ENLin_carrito
{
    private int id;
    private int numArticulos;

    public int idP
    {
        get
        {
            int copy = id;
            return copy;
        }
        set
        {
            id = value;
        }
    }

    public int numArticulosP
    {
        get
        {
            int copy = numArticulos;
            return copy;
        }
        set
        {
            if (value >= 0) numArticulos = value;
            else numArticulos = -1;//crear error
        }
    }

    public ENLin_carrito()
    {
        numArticulosP = 0;
    }

    public ENLin_carrito(int numArticulos)
    {
        numArticulosP = numArticulos;
    }

    public bool createLin_carrito()
    {
        bool realizado;

        CADLin_carrito numArticulos = new CADLin_carrito();
        realizado = numArticulos.createLin_carrito(this);

        return realizado;
    }
    public bool readLin_carrito()
    {
        bool realizado;

        CADLin_carrito numArticulos = new CADLin_carrito();
        realizado = numArticulos.readLin_carrito(this);

        return realizado;
    }
    public bool updateLin_carrito()
    {
        bool realizado;

        CADLin_carrito numArticulos = new CADLin_carrito();
        realizado = numArticulos.updateLin_carrito(this);

        return realizado;
    }

    public bool deleteLin_carrito()
    {
        bool realizado;

        CADLin_carrito numArticulos = new CADLin_carrito();
        realizado = numArticulos.deleteLin_carrito(this);

        return realizado;
    }
}
