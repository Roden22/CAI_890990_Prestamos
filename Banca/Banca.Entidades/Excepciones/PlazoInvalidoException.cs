using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca.Entidades.Excepciones
{
    public class PlazoInvalidoException : Exception
    {
        public PlazoInvalidoException() : base()
        {

        }

        public PlazoInvalidoException(string m) : base(m) { }
    }
}
