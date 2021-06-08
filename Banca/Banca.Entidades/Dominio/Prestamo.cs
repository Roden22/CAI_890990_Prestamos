using Banca.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Banca.Entidades.Dominio
{
    [DataContract]
    public class Prestamo
    {
     
        [DataMember]
        public string Linea { get; set; }

        [DataMember]
        public double TNA { get; set; }

        [DataMember]
        public int Plazo { get; set; }

        [DataMember]
        public double Monto { get; set; }

        [DataMember]
        public string Usuario { get; set; }

        [DataMember]
        public int id { get; set; }

        public Prestamo() { }

        public Prestamo(string linea, double tna, int plazo, double monto)
        {
            Linea = linea;
            TNA = tna;
            Plazo = plazo;
            Monto = monto;
            Usuario = ConfigurationManager.AppSettings["REGISTRO"];
            id = 0;
        }

        public override string ToString()
        {
            return $"{id}) {Plazo} días - ARS {Monto} (interés {TNA}%) - {Linea}";
        }

        public Cuota CalcularCuota()
        {
            return new Cuota(Monto, Plazo, TNA);
        }
    }
}
