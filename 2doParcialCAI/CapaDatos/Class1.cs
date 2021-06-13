using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using Newtonsoft.Json;

namespace CapaDatos
{
    public class Mapper
    {
        public List<PlazoFijo> TraerPorId(int id) 
        {
            string json = WebHelper.Get("PlazoFijo/"+id.ToString());
            List<PlazoFijo> lst = Mapeo(json);
            return lst;
        }

        private List<PlazoFijo> Mapeo(string json)
        {
            List<PlazoFijo> lst = JsonConvert.DeserializeObject<List<PlazoFijo>>(json);
            return lst;
        }

        public ResultadoTransaccion Alta(PlazoFijo plazo) 
        {
            NameValueCollection obj = ReverseMaper(plazo);

            string json = WebHelper.Post("PlazoFijo/",obj);

            ResultadoTransaccion lst = JsonConvert.DeserializeObject<ResultadoTransaccion>(json);

            return lst;
        }

        private NameValueCollection ReverseMaper(PlazoFijo plazo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Tipo",plazo.Tipo.ToString());
            n.Add("CapitalInicial", plazo.CapitalInicial.ToString("0.00"));
            n.Add("Dias",plazo.Dias.ToString());
            n.Add("Interes", plazo.Interes.ToString("0.00"));
            n.Add("Usuario", "889040");
            n.Add("id",plazo.id.ToString());
            n.Add("idCliente", plazo.idCliente.ToString());

            return n;
        }
    }
}
