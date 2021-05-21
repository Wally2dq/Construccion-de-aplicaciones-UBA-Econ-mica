using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryClase2Form
{
    public class Profesor
    {
        List<Alumno> _alumno;

        public Profesor() 
        {
            _alumno = new List<Alumno>();

            Alumno alu1 = new Alumno(1, "Walter", "Quintana", true, "Oyente");
            Alumno alu2 = new Alumno(2, "Nicolas", "Quintana", false, "Regular");
            Alumno alu3 = new Alumno(3, "Jose", "Perz", true, "Oyente");

            _alumno.Add(alu1);
            _alumno.Add(alu2);
            _alumno.Add(alu3);
        }

        public List<Alumno> MostrarLista() 
        {
            return _alumno;
        }

        public void EliminarAlumno(Alumno alu) 
        {
            foreach (Alumno i in _alumno) 
            {
                if (i.Equals(alu) == true)
                {
                    Alumno borrar = (Alumno)i;
                    _alumno.Remove(borrar);
                    break;
                }
            }
        }

        public void CargarAlumno(Alumno alu) 
        {
            _alumno.Add(alu);
        }

        public void BuscarAlumnoRepetido(Alumno alu) 
        {
            foreach (Alumno i in _alumno) 
            {
                if (i.Equals(alu))
                    throw new CodigoDeAlumnoYaRegistradoException("Codigo de alumno ya registrado");
            }
        }


        public void BuscarGetAlumno(int NumeroRegistro, ref Alumno alumno)
        {
            foreach (Alumno i in _alumno)
            {
                if (i.NroRegistro == NumeroRegistro) 
                {
                    alumno = (Alumno)i;
                }
                   
            }

           
        }
    }
}
