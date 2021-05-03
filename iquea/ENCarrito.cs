using System;

public class ENCarrito
{
	private int id;
	private double importe;

	public int idP { get { return this.id; } set { this.id = value; } }
	public double importeP { get { return this.importe; } set { this.importe = value; } }

    public bool createCarrito()
    {
        return false;
    }
    public bool readCarrito()
    {
        return false;
    }
    public bool updateCarrito()
    {
        return false;
    }

    public bool deleteCarrito()
    {
        return false;
    }
    public ENCarrito()
	{
	}
    public ENCarrito(double importe)
    {
    }
}
