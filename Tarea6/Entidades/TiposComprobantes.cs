using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    public class TiposComprobantes
    {
        public int IdTipoComprobante { get; set; }
        public string NombreComprobante { get; set; }

        public TiposComprobantes()
        {
            IdTipoComprobante = 0;
            NombreComprobante = string.Empty;
        }
    }
}
