using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFCGenerador.Models
{
    internal class DetalleComprobante
    {
        public int id;
        public string? comprobante;
        public string? estado;

        public DetalleComprobante(int id, string? comprobante, string? estado)
        {
            this.id = id;
            this.comprobante = comprobante;
            this.estado = estado;
        }
    }
}
