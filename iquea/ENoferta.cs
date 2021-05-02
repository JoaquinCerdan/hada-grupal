using System;

public class ENoferta
{
	private double descuento;
	private DateTime fechaValidez;

    public double descuentoP
    {
        get { return this.descuento; }
        set { this.descuento = value; }
    }

    public DateTime fechaValidezP
    {
        get { return this.fechaValidez; }
        set { this.fechaValidez = value; }
    }

    public ENoferta()
    {

    }

    public ENoferta(double descuento, DateTime fechaValidez)
    {

    }

    public bool createOferta()
    {
        return false;
    }

    public bool readOferta()
    {
        return false;
    }

    public bool deleteOferta()
    {
        return false;
    }

    public bool updateOferta()
    {
        return false;
    }
}
