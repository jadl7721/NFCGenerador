using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFCGenerador.Models
{
    internal class TipoComprobante
    {
        public int id;
        public string? tipo;
        public string? descripcion;
        public string? estado;

        public TipoComprobante(int id, string? tipo, string? descripcion, string? estado)
        {
            this.id = id;
            this.tipo = tipo;
            this.descripcion = descripcion;
            this.estado = estado;
        }
    }
}
