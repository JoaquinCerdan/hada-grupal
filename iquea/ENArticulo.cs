using System;

/// <summary>
/// Summary description for ENArticulo
/// </summary>
public class ENArticulo
{

	private int id;
	public static int NextID = 0;
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

	private int stock;

	public int intStock
	{
		get { return stock; }
		set { stock = value; }
	}

	private int categoria;
	public int intCategoria

    {
		get { return categoria; }
		set { categoria = value; }
	}
	private string temporada;
	public string stringTemporada
    {
		get { return temporada; }
		set { temporada = value; }
	}

	public ENArticulo()
	{
		CADArticulo aux = new CADArticulo();
		intId = aux.obtenerId();
		stringNombre = "";
		stringDescripcion = "";
		doublePrecio = 0.0;
		stringImagen = "";
		intStock = 0;
		intCategoria = 0;
		stringTemporada = "";
	}

	public ENArticulo(int id, string nombre, string descripcion, double precio, string imagen, int stock, int categoria, string temporada)
	{
		intId = id;
		stringNombre = nombre;
		stringDescripcion = descripcion;
		doublePrecio = precio;
		stringImagen = imagen;
		intStock = stock;
		intCategoria = categoria;
		stringTemporada = temporada;
	}

	public bool createArticulo()
	{
		CADArticulo articulo = new CADArticulo();
		bool created = false;
		//if (!articulo.readArticulo(this))
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
		aux.temporada = this.temporada;
		aux.categoria = this.categoria;

		if (articulo.readArticulo(this))
		{
			this.id = aux.id;
			this.nombre = aux.nombre;
			this.descripcion = aux.descripcion;
			this.precio = aux.precio;
			this.imagen = aux.imagen;
			this.stock = aux.stock;
			this.categoria = aux.categoria;
			this.temporada = aux.temporada;
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

	public bool getArticulos(string searchString)
    {
		CADArticulo articulo = new CADArticulo();
		bool read = false;
		if (articulo.getArticulos(this, searchString))
			read = articulo.deleteArticulo(this);
		return read;
	}

	//string query = "select * from [dbo].[Articulo] where Nombre like '" + searchString + "%'";

}
