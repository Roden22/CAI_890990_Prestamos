using Banca.Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca.Entidades.Modelos
{
    public class Cuota
    {
        private double _capital;
        private double _interes;
        private double _total;

        public double CuotaCapital { get => _capital;  }
        public double CuotaInteres { get => _interes; }
        public double CuotaTotal { get => _total;  }

        public Cuota(double monto, int plazo, double tna)
        {
            if (plazo <= 0) throw new PlazoInvalidoException("El plazo debe ser mayor o igual a 1 día.");
           
            _capital = monto / plazo;
            _interes = _capital * (tna / 12 / 100);
            _total = _capital + _interes;
        }
    }
}
