
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iquea
{
    public class Class1
    {
<<<<<<< HEAD:iquea/Class1.cs
=======
        private int id;

        public int intId
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public ENAdministrador()
        {

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

>>>>>>> develop:iquea/ENAdministrador.cs
    }
}

