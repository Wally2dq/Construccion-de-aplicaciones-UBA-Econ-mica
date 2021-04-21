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

        public string Apellido { get => this._apellido; set => this._apellido = value; }
        public string Nombre { get => this._nombre; set => this._nombre = value; }
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
