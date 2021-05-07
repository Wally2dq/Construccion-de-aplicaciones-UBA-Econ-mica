using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryClase2Form
{
    public class ListaTipoAlumno
    {
        public static List<TipoAlumno> MostrarLista()
        {
            List<TipoAlumno> _lista = new List<TipoAlumno>();

            TipoAlumno seleccione = new TipoAlumno(0, "Seleccionar");
            TipoAlumno soltero = new TipoAlumno(1, "Regular");
            TipoAlumno casado = new TipoAlumno(2, "Oyente");

            _lista.Add(seleccione);
            _lista.Add(casado);
            _lista.Add(soltero);

            return _lista;
        }
    }
}
