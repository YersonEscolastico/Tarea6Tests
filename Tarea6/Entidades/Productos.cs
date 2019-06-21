using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    public class Productos
    {

        [Key]
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaFabricacion { get; set; }
        public double CostoCompra { get; set; }
        public double Stock { get; set; }
        public int IdUnidadMedida { get; set; }
        public int IdImagen { get; set; }
        public int IdCategoria { get; set; }
        public int IdMarca { get; set; }
        public int IdModelo { get; set; }

        public Productos()
        {
            this.IdProducto = 0;
            this.Nombre = string.Empty;
            this.Descripcion = string.Empty;
            this.FechaFabricacion = DateTime.Now;
            this.CostoCompra = 0;
            this.Stock = 0;
            this.IdUnidadMedida = 0;
            this.IdImagen = 0;
            this.IdCategoria = 0;
            this.IdMarca = 0;
            this.IdModelo = 0;
        }
    }
}
