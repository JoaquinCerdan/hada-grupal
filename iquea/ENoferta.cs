using System;

public class ENoferta
{
	private double descuento;
	private DateTime fechaValidez;

    public string descuentoP
    {
        get { return this.descuento; }
        set { this.descuento = value; }
    }

    public string fechaValidezP
    {
        get { return this.fechaValidez; }
        set { this.fechaValidez = value; }
    }

    public ENoferta()
    {
        this.descuento = null;
        this.fechaValidez = null;
    }

    public ENoferta(double descuento, DateTime fechaValidez)
    {
        //solo se aceptará el descuento si es mayor que 0 y menor que 100(el descuento funciona en forma de proporcion sobre el precio)
        if(descuento>0 && descuento < 100)
        {
            this.descuento = descuento;
        }
        //la fecha de validez tiene que ser mayor que la actual
        this.fechaValidez = fechaValidez;
        
    }

    public bool createOferta()
    {
        bool respuesta;

        CADoferta oferta = new CADoferta();
        respuesta = oferta.createOferta();

        return respuesta;
    }

    public bool readOferta()
    {
        bool respuesta;

        CADoferta oferta = new CADoferta();
        respuesta = oferta.readOferta();

        return respuesta;
    }

    public bool deleteOferta()
    {
        bool respuesta;

        CADoferta oferta = new CADoferta();
        respuesta = oferta.deleteOferta();

        return respuesta;
    }

    public bool updateOferta()
    {
        bool respuesta;

        CADoferta oferta = new CADoferta();
        respuesta = oferta.updateOferta();

        return respuesta;
    }
}
