using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    public class TiposComprobantes
    {
        [Key]
        public int IdTipoComprobante { get; set; }
        public string NombreComprobante { get; set; }

        public TiposComprobantes()
        {
            IdTipoComprobante = 0;
            NombreComprobante = string.Empty;
        }
    }
}
