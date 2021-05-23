using System;

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

    }

	public bool createAnuncio()
    {
		return true;
	}

	public bool readAnuncio()
    {
		return false;
	}

	public bool updateAnuncio()
    {
		return false;
	}
	public bool deleteAnuncio()
    {
		return false;
	}




}
