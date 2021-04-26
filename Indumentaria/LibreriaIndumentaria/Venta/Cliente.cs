using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaIndumentaria
{
    public class Cliente
    {
        private int _codigo;
        private string _apellido;
        private string _nombre;

        public int Codigo { get => _codigo; }
        public string Apellido { get => _apellido; }
        public string Nombre { get => _nombre; }

        public Cliente(int Codigo, string Nombre, string Apellido) 
        {
            _codigo = Codigo;
            _apellido = Apellido;
            _nombre = Nombre;
        }
    }
}
