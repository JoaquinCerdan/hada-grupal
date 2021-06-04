public class ENLista_deseos
{
    private int id;
    private int id_articulo;
    private string id_user;

    public int intId
    {
        get { return id; }
        set { id = value; }
    }
    public int intId_articulo
    {
        get { return id_articulo; }
        set { id_articulo = value; }
    }
    public string intId_user
    {
        get { return id_user; }
        set { id_user = value; }
    }

    public ENLista_deseos()
    {
        CADLista_deseos aux = new CADLista_deseos();

        intId = aux.obtenerId();
        intId_articulo = 0;
        intId_user = "";
    }

    public ENLista_deseos(int id, int id_articulos)
    {


        intId = id;
        intId_articulo = id_articulos;
        intId_user = id_user;
    }

    public bool createLista_deseos()
    {
        CADLista_deseos lista = new CADLista_deseos();
        bool created = false;
        //if (!lista.readLista_deseos(this))
            created = lista.createLista_deseos(this);
        return created;
    }
    public bool readLista_deseos()
    {
        CADLista_deseos lista = new CADLista_deseos();
        bool read = lista.readLista_deseos(this);
        return read;
    }
    public bool updateLista_deseos()
    {
        ENLista_deseos aux = new ENLista_deseos();
        CADLista_deseos lista = new CADLista_deseos();

        bool updated = false;
        aux.id = this.id;
        aux.id_articulo = this.id_articulo;
        aux.id_user = this.id_user;


        if (lista.readLista_deseos(this))
        {
            this.id = aux.id;
            this.id_articulo = aux.id_articulo;
            this.id_user = aux.id_user;

            updated = lista.updateLista_deseos(this);
        }

        return updated;
    }
    public bool deleteLista_deseos()
    {
        CADLista_deseos lista = new CADLista_deseos();
        bool read = false;
        if (lista.readLista_deseos(this))
            read = lista.deleteLista_deseos(this);
        return read;
    }
}
