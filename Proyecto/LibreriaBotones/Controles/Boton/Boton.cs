using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibreriaBotones.Controles.Boton
{
    public class Botones
    {
        int _codigo;
        string _description;

        public int Codigo {
            get 
            {
                return this._codigo;
            }
            set 
            {
                this._codigo = value;
            }
        }

        public string Descripcion 
        {
            get => this._description;
            set => this._description = value;
        }

        public Botones(int cod, string desc) //Contructor con parametros
        {
            Codigo = cod;
            Descripcion = desc;
        }
        public Botones() //Contructor sin nada
        {
            //Nada
        }
        public string MostrarBoton() //Formato para Mostrar los Botones
        {
            return "Codigo: " + Codigo.ToString()+
                "\nDescripcion: "+ Descripcion;
        }

        
    }
}
