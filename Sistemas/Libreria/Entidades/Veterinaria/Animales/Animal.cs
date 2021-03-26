using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Entidades.Veterinaria.Animales
{
    public class Animal
    {
        private string TipoAnimal;
        private string Raza;
        private int Edad;
        private string Sexo;

        public string TipoDeAnimal 
        {
            get 
            {
                return "Tipo de animal : " + this.TipoAnimal;
            }
            set
            {
                this.TipoAnimal = value;
            }
        }

        public string RazaAnimal 
        {
            get 
            {
                return "Raza del Animal : " + this.Raza;
            }
            set 
            {
                this.Raza = value;
            }
        }

        public string EdadAnimal 
        {
            get 
            {
                return "Edad del Animal : "+ this.Edad.ToString();
            }
            set 
            {
                this.Edad =Convert.ToInt32(value);
            }
        }

        public string SexoAnimal
        {
            get
            {
                return "Sexo del animal : " + this.TipoAnimal;
            }
            set
            {
                this.Sexo = value;
            }
        }
    }
}
