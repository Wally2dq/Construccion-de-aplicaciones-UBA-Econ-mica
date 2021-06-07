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
    public class PrestamoMappers
    {
        public List<PrestamoTipo> TraerTodosPT() 
        {
            string json = WebHelper.Get("prestamotipo");
            List<PrestamoTipo> lst = MapperListaTipo(json);
            return lst;
        }

        private List<PrestamoTipo> MapperListaTipo(string json)
        {
            List<PrestamoTipo> lst = JsonConvert.DeserializeObject<List<PrestamoTipo>>(json);
            return lst;
        }

        public List<Prestamo> TraerTodosPrestamo(int id) 
        {
            string json = WebHelper.Get("prestamo/"+id);
            List < Prestamo > lst= MapperPrestamo(json);
            return lst;
        }

        private List<Prestamo> MapperPrestamo(string json)
        {
            List<Prestamo> lst = JsonConvert.DeserializeObject<List<Prestamo>>(json);
            return lst;
        }

        public ResultadoTransaccion InsertarPrestamo(Prestamo prestamo) 
        {
            NameValueCollection obj = ReverserMappers(prestamo);

            string json = WebHelper.Post("prestamo", obj);

            ResultadoTransaccion lst = JsonConvert.DeserializeObject<ResultadoTransaccion>(json);

            return lst;
        }


        private NameValueCollection ReverserMappers(Prestamo prestamo) 
        {
            
            NameValueCollection n = new NameValueCollection();
            n.Add("Plazo", prestamo.Plazo.ToString());
            n.Add("Monto", prestamo.Monto.ToString("0.00"));
            n.Add("Linea", prestamo.Linea);
            n.Add("TNA", prestamo.TNA.ToString());
            n.Add("Cuota", prestamo.Cuota.ToString("0.00"));
            n.Add("idTipo", prestamo.Tipo.ToString());
            n.Add("Usuario", "889040");
            n.Add("idCliente", "437");


        //INPUT: Linea, Plazo, Monto, CuotaTotal

            return n;
        }

    }
}
