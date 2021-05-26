public class ENUsuario
{
    private string email;
    private string contra;
    private string datosBancarios;
    private string nombre;
    private string direccion;
    private int numTelefono;

    public string stringEmail
    {
        get { return email; }
        set { email = value; }
    }

    public string stringContra
    {
        get { return contra; }
        set { contra = value; }
    }

    public string stringDatosBancarios
    {
        get { return datosBancarios; }
        set { datosBancarios = value; }
    }

    public string stringDireccion
    {
        get { return direccion; }
        set { direccion = value; }
    }

    public string stringNombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int intNumTelefono
    {
        get { return numTelefono; }
        set { numTelefono = value; }
    }

    public ENUsuario()
    {
        stringEmail = "";
        stringContra = "";
        stringDatosBancarios = "";
        stringDireccion = "";
        stringNombre = "";
        intNumTelefono = 0;
    }

    public ENUsuario(string email, string contra, string datosBancarios, string nombre, string direccion, int numTelefono)
    {
        this.email = email;
        this.contra = contra;
        this.datosBancarios = datosBancarios;
        this.nombre = nombre;
        this.direccion = direccion;
        this.numTelefono = numTelefono;
    }

    public bool createUsuario()
    {
        bool isTrue;
        CADUsuario usuario = new CADUsuario();
        isTrue = usuario.createUsuario(this);
        return isTrue;
    }

    public bool readUsuario()
    {
        bool isTrue;
        CADUsuario usuario = new CADUsuario();
        isTrue = usuario.readUsuario(this);
        return isTrue;
    }

    public bool updateUsuario()
    {
        bool isTrue;
        CADUsuario usuario = new CADUsuario();
        isTrue = usuario.createUsuario(this);
        return isTrue;
    }

    public bool deleteUsuario()
    {
        bool isTrue;
        CADUsuario usuario = new CADUsuario();
        isTrue = usuario.deleteUsuario(this);
        return isTrue;
    }
    public bool readUsuarioWithEmail(string email)
    {
        CADUsuario user = new CADUsuario();
        return user.readUsuarioWithEmail(email);
    }
}
