using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryClase2Form
{
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;

        public Persona(string Nombre, string Apellido) 
        {
            _nombre = Nombre;
            _apellido = Apellido;
        }

        public abstract string GetCredencial();
    }
}
