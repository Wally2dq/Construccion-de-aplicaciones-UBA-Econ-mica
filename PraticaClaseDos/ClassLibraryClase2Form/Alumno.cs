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

        public int NroRegistro { get => _nroRegistro; }
        public string Nombre { get => _nombre; }
        public string Apellido { get => _apellido; }
        public bool Recursante { get => _recursante; }
        private string TipoAlumno { get => _tipoAlumno; }

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

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Alumno))
                return false;

            Alumno alu = (Alumno)obj;

            if (alu.NroRegistro != this.NroRegistro)
                return false;

            return true;
        }

        public override string ToString()
        {
            return GetCredencial();
        }
    }
}
