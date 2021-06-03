using System;

/// <summary>
/// Summary description for ENCategoria
/// </summary>
public class ENCategoria
{
	private int id;

	public int intId
	{
		get { return id; }
		set { id = value; }
	}

	private string nombre;

	public string stringNombre
	{
		get { return nombre; }
		set { nombre = value; }
	}

	private string descripcion;

	public string stringDescripcion
	{
		get { return descripcion; }
		set { descripcion = value; }
	}

	public ENCategoria()
	{
		//intId = 0;
		stringNombre = "";
		stringDescripcion = "";
	}

	public ENCategoria(int id, string nombre, string descripcion)
	{
		intId = id;
		stringNombre = nombre;
		stringDescripcion = descripcion;
	}

	public bool createCategoria()
	{
		CADCategoria categoria = new CADCategoria();
		bool created = false;
		//if (!categoria.readCategoria(this))
			created = categoria.createCategoria(this);
		return created;
	}

	public bool updateCategoria()
	{
		ENCategoria aux = new ENCategoria();
		CADCategoria categoria = new CADCategoria();

		bool updated = false;
		aux.id = this.id;
		aux.nombre = this.nombre;
		aux.descripcion = this.descripcion;

		if (categoria.readCategoria(this))
		{
			this.id = aux.id;
			this.nombre = aux.nombre;
			this.descripcion = aux.descripcion;
			updated = categoria.updateCategoria(this);
		}

		return updated;
	}

	public bool readCategoria()
	{
		CADCategoria categoria = new CADCategoria();
		bool read = categoria.readCategoria(this);
		return read;
	}

	public bool deleteCategoria()
	{
		CADCategoria categoria = new CADCategoria();
		bool read = false;
		if (categoria.readCategoria(this))
			read = categoria.deleteCategoria(this);
		return read;
	}

}
