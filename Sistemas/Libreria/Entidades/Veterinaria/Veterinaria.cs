using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Entidades.Veterinaria.Animales;
using Libreria.Entidades.Deportista;

namespace Libreria.Entidades.Veterinaria
{
    public class Veterinaria
    {
        private DateTime Turnos;
        private string NombreVeterinario;
        private bool CuidadoEspecial;

        private Animal Ani = new Animal();

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
        public string MostrarAnimales
        {
            get
            {
                return Ani.TipoDeAnimal +
                    "\n" + Ani.RazaAnimal +
                    "\n" + Ani.EdadAnimal +
                    "\n" + Ani.SexoAnimal;
            }
        }

        public void SetAnimales( string TipoAni, string RazaAni, string EdadAni , string SexoAni)
        {
            Ani.TipoDeAnimal = TipoAni;
            Ani.RazaAnimal = RazaAni;
            Ani.EdadAnimal = EdadAni;
            Ani.SexoAnimal = SexoAni;
        }
    }
}
