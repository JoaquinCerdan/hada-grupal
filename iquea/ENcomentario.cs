public class ENcomentario
{
    private string comentario;
    private int valoracion;
    private int id;

    public string comentarioP
    {
        get { return this.comentario; }
        set { this.comentario = value; }
    }

    public int valoracionP
    {
        get { return this.valoracion; }
        set { this.valoracion = value; }
    }

    public int idP
    {
        get { return this.id; }
        set { this.id = value; }
    }

    public ENcomentario()
    {
        this.comentario = "";
        this.valoracion = 0;
    }

    public ENcomentario(string comentario, int valoracion)
    {
        this.comentario = comentario;
        //la valoración va desde 0 a 100.Si el valor dado no esta entre esos parametros no se aceptará
        if (valoracion >= 0 && valoracion <= 100)
        {
            this.valoracion = valoracion;
        }
        else
        {
            //crear error
        }
    }

    public bool createComentario()
    {
        bool respuesta;

        CADcomentario comentario = new CADcomentario();
        respuesta = comentario.createComentario(this);

        return respuesta;
    }

    public bool readComentario()
    {
        bool respuesta;

        CADcomentario comentario = new CADcomentario();
        respuesta = comentario.readComentario(this);

        return respuesta;
    }

    public bool deleteComentario()
    {
        bool respuesta;

        CADcomentario comentario = new CADcomentario();
        respuesta = comentario.deleteComentario(this);

        return respuesta;
    }

    public bool updateComentario()
    {
        bool respuesta;

        CADcomentario comentario = new CADcomentario();
        respuesta = comentario.updateComentario(this);

        return respuesta;
    }

}