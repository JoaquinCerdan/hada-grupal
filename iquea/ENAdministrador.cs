
    public class ENAdministrador
    {
        private int codigo;
        private string correo;

        public int intcodigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        public string StringCorreo
        {
            get { return this.correo; }
            set { this.correo = value; }
        }

        public ENAdministrador()
        {
            codigo = 0;
            correo = "";
        }

        public bool createAdministrador()
        {
            bool isTrue;
            CADAdministrador administrador = new CADAdministrador();
            isTrue = administrador.createAdministrador(this);
            return isTrue;
        }

        public bool readAdministrador()
        {
            bool isTrue;
            CADAdministrador administrador = new CADAdministrador();
            isTrue = administrador.readAdministrador(this);
            return isTrue;
        }

        public bool updateAdministrador()
        {
            bool isTrue;
            CADAdministrador administrador = new CADAdministrador();
            isTrue = administrador.updateAdministrador(this);
            return isTrue;
        }

        public bool deleteAdministrador()
        {
            bool isTrue;
            CADAdministrador administrador = new CADAdministrador();
            isTrue = administrador.deleteAdministrador(this);
            return isTrue;
        }

    }