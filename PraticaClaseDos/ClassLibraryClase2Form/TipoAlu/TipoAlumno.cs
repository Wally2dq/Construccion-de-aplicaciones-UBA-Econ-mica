using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryClase2Form
{
    public class TipoAlumno
    {
        private string _descripcion;
        private int _codigo;

        public TipoAlumno(int cod, string desc)
        {
            _descripcion = desc;
            _codigo = cod;
        }

        public string Descripcion { get => _descripcion; }
        public int Codigo { get => _codigo; }
    }
}
