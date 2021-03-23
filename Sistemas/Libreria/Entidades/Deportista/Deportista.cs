using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Entidades.Deportista
{
    public class Deportista
    {
        private string TipoDeporte;
        private int Edad;
        private double Altura;
        private double Peso;
        private string Categoria;
        private string Federacion;
        private bool Actividad; //Si esta en actividad o inactivo

        public string TipoDeporteDeportista
        {
            get
            {
                return "Tipo de Deporte : " + this.TipoDeporte;
            }
            set
            {
                this.TipoDeporte = value;
            }
        }

        public string EdadDeportista
        {
            get
            {
                return "Edad " + this.Edad.ToString();
            }
            set
            {
                if (Convert.ToInt32(EdadDeportista) > 0)
                {
                    this.Edad = Convert.ToInt32(value);
                }
                else
                {
                    Console.WriteLine("La edad debe ser mayor a 0");
                }
            }
        }

        public double AlturaDeportista
        {
            get
            {
                return this.Altura;
            }
            set
            {
                this.Altura = value;
            }
        }

        public double PesoDeportista
        {
            get
            {
                return this.Peso;
            }
            set
            {
                this.Peso = value;
            }
        }

        public string CategoriaDeportista
        {
            get
            {
                return "Categoria : " + this.Categoria;
            }
            set
            {
                this.Categoria = value;
            }
        }

        public string FederacionDeportista
        {
            get
            {
                return "Federacion : " + this.Federacion;
            }
            set
            {
                this.Federacion = value;
            }
        }

        public string ActividadDeportista
        {
            get
            {
                if (this.Actividad == false)
                {
                   return "El deportista Esta Inactivo";
                }
                else 
                {
                   return "El deportista Esta Activo";
                }
                ;
            }
            set
            {
                this.Actividad = Convert.ToBoolean(value);
            }
        }
    }
}
