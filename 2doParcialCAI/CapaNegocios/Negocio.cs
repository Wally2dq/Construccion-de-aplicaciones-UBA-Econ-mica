using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocios
{
    public class Negocio
    {
        List<TipoPlazoFijo> _listaTipos;
        Mapper _mapper;

        public Negocio() 
        {
            _listaTipos = new List<TipoPlazoFijo>();
            _mapper = new Mapper();
        }

        public List<TipoPlazoFijo> CargarCmb() 
        {
            TipoPlazoFijo a = new TipoPlazoFijo();
            a.id = 0;
            a.Descripcion = "Selecionar";

            TipoPlazoFijo b = new TipoPlazoFijo();
            b.id = 1;
            b.Descripcion = "Plazo Fijo Web";
            b.Tasa = 41;

            TipoPlazoFijo c = new TipoPlazoFijo();
            c.id = 2;
            c.Descripcion = "Plazo Fijo UVA";
            c.Tasa = 3;

            _listaTipos.Add(a);
            _listaTipos.Add(b);
            _listaTipos.Add(c);

            return _listaTipos;

        }

        public ResultadoTransaccion Alta(PlazoFijo plazo) 
        {
            ResultadoTransaccion lst = _mapper.Alta(plazo);

            return lst; 
        }

        public List<PlazoFijo> CargarLista() 
        {
            int id = 889040; //Pongo este numero asi traigo las lista de este proyecto Unicamente

            List<PlazoFijo> _lista = _mapper.TraerPorId(id);

            return _lista;
        }
    }
}
