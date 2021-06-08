using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Banca.Entidades.Dominio
{
    [DataContract]
    public class TipoPrestamo
    {
        [DataMember]
        public string Linea { get; set; }

        [DataMember]
        public double TNA { get; set; }

        [DataMember]
        public int id { get; set; }

        public override string ToString()
        {
            return $"{id}) {Linea} - TNA: {TNA}%";
        }

    }
}
