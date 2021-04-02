using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBotones.Boton
{
    class Boton
    {
        int _codigo;
        string _description;

        public int Codigo { get => _codigo; }
        public string Description { get => _description; }

        public Boton(int cod, string desc)
        {
            _codigo = cod;
            _description = desc;
        }
    }
}
