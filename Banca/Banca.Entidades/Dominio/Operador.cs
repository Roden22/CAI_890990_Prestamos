using Banca.Entidades.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca.Entidades
{
    public class Operador
    {
        public List<Prestamo> Prestamos { get; set; }
        public double Comision { get; set; }
        public double PorcentajeComision { get; set; }
    }
}
