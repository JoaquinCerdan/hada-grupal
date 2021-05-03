using System;

public class ENcomentario
{
    private string comentario;
    private int valoracion;

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

    public ENcomentario()
    {

    }

    public ENcomentario(string comentario,int valoracion)
    {

    }

    public bool createComentario()
    {
        return false;
    }

    public bool readComentario()
    {
        return false;
    }

    public bool deleteComentario()
    {
        return false;
    }

    public bool updateComentario()
    {
        return false;
    }

}

