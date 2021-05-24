public class ENAnuncio

{
    private int id;
    private string enlace;
    private string descripcion;

    public int intId
    {
        get { return id; }
        set { id = value; }
    }
    public string stringEnlace
    {
        get { return enlace; }
        set { enlace = value; }
    }
    public string stringDescripcion
    {
        get { return descripcion; }
        set { descripcion = value; }
    }

    public ENAnuncio()
    {
        intId = 0;
        stringEnlace = "";
        stringDescripcion = "";
    }

    public ENAnuncio(int id, string enlace, string descripcion)
    {
        intId = id;
        stringEnlace = enlace;
        stringDescripcion = descripcion;
    }

    public bool createAnuncio()
    {
        CADAnuncio anuncio = new CADAnuncio();
        bool created = false;
        if (!anuncio.readAnuncio(this))
            created = anuncio.createAnuncio(this);
        return created;
    }

    public bool readAnuncio()
    {
        CADAnuncio anuncio = new CADAnuncio();
        bool read = anuncio.readAnuncio(this);
        return read;
    }

    public bool updateAnuncio()
    {
        ENAnuncio aux = new ENAnuncio();
        CADAnuncio anuncio = new CADAnuncio();

        bool updated = false;
        aux.id = this.id;
        aux.enlace = this.enlace;
        aux.descripcion = this.descripcion;

        if (anuncio.readAnuncio(this))
        {
            this.id = aux.id;
            this.enlace = aux.enlace;
            this.descripcion = aux.descripcion;
            updated = anuncio.updateAnuncio(this);
        }

        return updated;
    }
    public bool deleteAnuncio()
    {
        CADAnuncio anuncio = new CADAnuncio();
        bool read = false;
        if (anuncio.readAnuncio(this))
            read = anuncio.deleteAnuncio(this);
        return read;
    }




}
