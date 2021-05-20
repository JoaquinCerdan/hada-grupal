using System;

public class ENCarrito
{
    private int id;
    private double importe;

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

    public double importeP
    {
        get
        {
            double copy = importe;
            return copy;
        }
        set
        {
            if (value >= 0) importe = value;
            else importe = -1;//crear error
        }
    }

    public ENCarrito()
    {
        importeP = 0;
    }

    public ENCarrito(double importe)
    {
        importeP = importe;
    }

    public bool createCarrito()
    {
        bool realizado;

        CADCarrito importe = new CADCarrito();
        realizado = importe.createCarrito(this);

        return realizado;
    }

    public bool readCarrito()
    {
        bool realizado;

        CADCarrito importe = new CADCarrito();
        realizado = importe.readCarrito(this);

        return realizado;
    }

    public bool updateCarrito()
    {
        bool realizado;

        CADCarrito importe = new CADCarrito();
        realizado = importe.updateCarrito(this);

        return realizado;
    }

    public bool deleteCarrito()
    {
        bool realizado;

        CADCarrito importe = new CADCarrito();
        realizado = importe.deleteCarrito(this);

        return realizado;
    }

}