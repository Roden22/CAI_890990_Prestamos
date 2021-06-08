using Banca.Datos;
using Banca.Entidades.Dominio;
using Banca.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca.Negocio
{
    public class Operador
    {
        private List<TipoPrestamo> _tiposPrestamo;
        private List<Prestamo> _prestamos;
        private MapperPrestamo _mapperPrestamo;
        private double _comision;
        private double _porcentajeComision;

        public double Comision => _comision;
        public double PorcentajeComision => _porcentajeComision;


        public Operador()
        {
            _mapperPrestamo = new MapperPrestamo();
            _porcentajeComision = double.Parse(ConfigurationManager.AppSettings["COMISION"]);
        }

        private double CalcularComision()
        {
            _comision = 0;
            if(_prestamos != null)
            {
                foreach (Prestamo p in _prestamos)
                {
                    _comision += p.Monto * (p.TNA / 12 / 100) * _porcentajeComision;
                }
            }
            
            return _comision;
        }

        public List<TipoPrestamo> TraerTiposPrestamos()
        {
            List<TipoPrestamo> tipos = _mapperPrestamo.TraerTipoPrestamos();
            return tipos;
        }

        public List<Prestamo> TraerPrestamos()
        {
            _prestamos = _mapperPrestamo.TraerPrestamos();
            CalcularComision();
            return _prestamos;
        }

        public void AltaPrestamo(Prestamo prestamo, TipoPrestamo tipo)
        {
            TxResult res = _mapperPrestamo.GuardarPrestamo(prestamo, tipo);
            if (!res.isOk)
            {
                throw new Exception(res.error);
            }
        }

        public Cuota CalcularCuotas(double monto, int plazo, double tna)
        {
            return new Cuota(monto, plazo, tna);
        }
    }
}
