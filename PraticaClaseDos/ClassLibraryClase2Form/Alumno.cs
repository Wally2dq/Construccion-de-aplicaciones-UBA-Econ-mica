using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryClase2Form
{
    public sealed class Alumno : Persona
    {
        private int _nroRegistro;
        private bool _recursante;
        private string _tipoAlumno;

        public Alumno(int NroRegistro, string Nombre, string Apellido, bool Recursante, string TipoAlu) : base(Nombre, Apellido) 
        {
            _nroRegistro = NroRegistro;
            _recursante = Recursante;
            _tipoAlumno = TipoAlu;
        }


        public override string GetCredencial()
        {
            string Muestra = "No";

            if (_recursante == true)
                Muestra = "Si";

            return $"Nro Registro: {_nroRegistro}, Nombre: {_nombre}, Apellido: {_apellido}, Recursante: {Muestra}, Tipo Alumno: {_tipoAlumno}";
        }

        public override string ToString()
        {
            return GetCredencial();
        }
    }
}
