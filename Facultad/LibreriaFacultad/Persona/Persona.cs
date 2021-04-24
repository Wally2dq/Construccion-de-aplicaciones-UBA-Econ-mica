using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFacultad
{
    public abstract class Persona
    {
        protected string _apellido;
        protected DateTime _fechaNac;
        protected string _nombre;

        public string Apellido { get => this._apellido;}
        public string Nombre { get => this._nombre;}
        public int Edad() 
        {
            return (_fechaNac.Year - DateTime.Now.Year);
        }

        public abstract string GetCredencial(); 
        
        public virtual string GetNombreCompleto()
        {
            return $"{this._nombre} {this._apellido}";
        }
    }
}
