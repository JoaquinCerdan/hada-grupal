using System;

/// <summary>
/// Summary description for ENArticulo
/// </summary>
public class ENArticulo
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

	private double precio;

	public double doublePrecio
	{
		get { return precio; }
		set { precio = value; }
	}

	private string imagen;

	public string stringImagen
	{
		get { return imagen; }
		set { imagen = value; }
	}

	private bool stock;

	public bool boolStock
	{
		get { return stock; }
		set { stock = value; }
	}

	public ENArticulo()
	{
		intId = 0;
		stringNombre = "";
		stringDescripcion = "";
		doublePrecio = 0.0;
		stringImagen = "";
		boolStock = false;
	}

	public ENArticulo(int id, string nombre, string descripcion, double precio, string imagen, bool stock)
	{
		intId = id;
		stringNombre = nombre;
		stringDescripcion = descripcion;
		doublePrecio = precio;
		stringImagen = imagen;
		boolStock = stock;
	}

	public bool createArticulo()
	{
		CADArticulo articulo = new CADArticulo();
		bool created = false;
		if (!articulo.readArticulo(this))
			created = articulo.createArticulo(this);
		return created;
	}

	public bool updateArticulo()
	{
		ENArticulo aux = new ENArticulo();
		CADArticulo articulo = new CADArticulo();

		bool updated = false;
		aux.id = this.id;
		aux.nombre = this.nombre;
		aux.descripcion = this.descripcion;
		aux.precio = this.precio;
		aux.imagen = this.imagen;
		aux.stock = this.stock;

		if (articulo.readArticulo(this))
		{
			this.id = aux.id;
			this.nombre = aux.nombre;
			this.descripcion = aux.descripcion;
			this.precio = aux.precio;
			this.imagen = aux.imagen;
			this.stock = aux.stock;
			updated = articulo.updateArticulo(this);
		}

		return updated;
	}

	public bool readArticulo()
	{
		CADArticulo articulo = new CADArticulo();
		bool read = articulo.readArticulo(this);
		return read;
	}

	public bool deleteArticulo()
	{
		CADArticulo articulo = new CADArticulo();
		bool read = false;
		if (articulo.readArticulo(this))
			read = articulo.deleteArticulo(this);
		return read;
	}

}
