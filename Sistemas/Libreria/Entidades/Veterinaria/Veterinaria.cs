using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Entidades.Veterinaria.Animales;

namespace Libreria.Entidades.Veterinaria
{
    public class Veterinaria
    {
        private DateTime Turnos;
        private string NombreVeterinario;
        private Animal[] Animales;
        private bool CuidadoEspecial;

        public string FechaTurno
        {
            get
            {
                return this.Turnos.ToString();
            }

            set
            {
                this.Turnos = Convert.ToDateTime(value);
            }
        }

        public string Veterinario 
        {
            get 
            {
                return this.NombreVeterinario;
            }
            set 
            {
                this.NombreVeterinario = value;
            }
        }

        public bool Cuidados 
        {
            get 
            {
                return this.CuidadoEspecial;
            }
            set 
            {
                this.CuidadoEspecial = value;
            }
        }

        //Nose como crear un Public para utilizar la clase "Animal"


    }
}
