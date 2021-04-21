using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFacultad
{
    public class Alumno : Persona
    {
        private int _codigo;

        public int Codigo { get => this._codigo; set => this._codigo = value; }
        public override string GetCredencial()
        {
            return $"Código {Codigo}) {Apellido}, {Nombre}";
        }

        public override string ToString() 
        {
            return GetCredencial();
        }
    }
}
