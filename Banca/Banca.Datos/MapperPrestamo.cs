using Banca.Entidades.Dominio;
using Banca.Entidades.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca.Datos
{
    public class MapperPrestamo
    {
        string _registro;
        
        public MapperPrestamo()
        {
            _registro = ConfigurationManager.AppSettings["REGISTRO"];
        }

        public List<TipoPrestamo> TraerTipoPrestamos()
        {
            string jsonRes = WebHelper.Get("prestamotipo");
            List<TipoPrestamo> response = JsonConvert.DeserializeObject<List<TipoPrestamo>>(jsonRes);
            return response;
        }

        public List<Prestamo> TraerPrestamos()
        {
            string jsonRes = WebHelper.Get("prestamo" + "/" + _registro);
            List<Prestamo> response = JsonConvert.DeserializeObject<List<Prestamo>>(jsonRes);
            return response;
        }

        public TxResult GuardarPrestamo(Prestamo prestamo, TipoPrestamo tipoPrestamo)
        {
            NameValueCollection nv = ReverseMap(prestamo, tipoPrestamo);
            string jsonRes = WebHelper.Post("prestamo", nv);
            TxResult response = JsonConvert.DeserializeObject<TxResult>(jsonRes);
            return response;
        }

        private NameValueCollection ReverseMap(Prestamo prestamo, TipoPrestamo tipoPrestamo)
        {
            NameValueCollection nv = new NameValueCollection()
            {
                {"id", prestamo.id.ToString()},
                {"TNA", prestamo.TNA.ToString("0.00") },
                {"Linea", prestamo.Linea },
                {"Plazo", prestamo.Plazo.ToString() },
                {"idCliente", "0" },
                {"idTipo", tipoPrestamo.id.ToString() },
                {"Monto", prestamo.Monto.ToString("0.00") },
                {"Cuota", prestamo.CalcularCuota().CuotaTotal.ToString("0.00") }, 
                {"Usuario", prestamo.Usuario },
                {"TipoPrest.TNA", tipoPrestamo.TNA.ToString("0.00") },
                {"TipoPrest.Linea", tipoPrestamo.Linea },
                {"TipoPrest.id", tipoPrestamo.id.ToString() }
            };

            return nv;
        }

    }
}
