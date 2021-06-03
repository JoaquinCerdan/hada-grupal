
    public class ENAdministrador
    {
        private string codigo;
        private string correo;

        public string stringcodigo
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
            codigo = "";
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