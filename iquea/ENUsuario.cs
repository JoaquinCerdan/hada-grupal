using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iquea
{
    class ENUsuario
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

        }

        public bool createUsuario()
        {

        }

        public bool readUsuario()
        {

        }

        public bool updateUsuario()
        {

        }
        public bool deleteUsuario()
        {

        }
    }
}
