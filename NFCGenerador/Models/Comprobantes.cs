using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFCGenerador.Models
{
    internal class Comprobantes
    {
        public int id;
        public int? tipoid;
        public int? numeracionactual;
        public int? numeracionfinal;

        public Comprobantes(int id, int? tipoid, int? numeracionactual, int? numeracionfinal)
        {
            this.id = id;
            this.tipoid = tipoid;
            this.numeracionactual = numeracionactual;
            this.numeracionfinal = numeracionfinal;
        }
    }
}
