
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

public class ENoferta
{
	private double descuento;
	private DateTime fechaValidez;
    private string cod;

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

    public string codP
    {
        get { return this.cod; }
        set { this.cod = value; }
    }

    public ENoferta()
    {
        this.descuento = 0;
        this.fechaValidez = new DateTime();
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
        respuesta = oferta.createOferta(this);

        return respuesta;
    }

    public bool readOferta()
    {
        bool respuesta;

        CADoferta oferta = new CADoferta();
        respuesta = oferta.readOferta(this);

        return respuesta;
    }

    public bool deleteOferta()
    {
        bool respuesta;

        CADoferta oferta = new CADoferta();
        respuesta = oferta.deleteOferta(this);

        return respuesta;
    }

    public bool updateOferta()
    {
        bool respuesta;

        CADoferta oferta = new CADoferta();
        respuesta = oferta.updateOferta(this);

        return respuesta;
    }
}