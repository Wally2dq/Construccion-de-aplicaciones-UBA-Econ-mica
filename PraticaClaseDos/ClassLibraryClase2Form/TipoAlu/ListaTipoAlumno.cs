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
            TipoAlumno regular = new TipoAlumno(1, "Regular");
            TipoAlumno oyente = new TipoAlumno(2, "Oyente");

            _lista.Add(seleccione);
            _lista.Add(regular);
            _lista.Add(oyente);

            return _lista;
        }
    }
}
