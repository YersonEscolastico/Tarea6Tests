using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
    public class Personas
    {
        [Key]
        public int IdPersona { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Materno { get; set; }
        public string Paterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Sexo { get; set; }
        public int IdImagen { get; set; }
        public string Direccion { get; set; }
        public int IdTipoPersona { get; set; }


        public Personas()
        {
            IdPersona = 0;
            Dni = 0;
            Nombre = string.Empty;
            Materno = string.Empty;
            Paterno = string.Empty;
            FechaNacimiento = DateTime.Now;
            Telefono = string.Empty;
            Correo = string.Empty;
            Sexo = string.Empty;
            IdImagen = 0;
            Direccion = string.Empty; ;
            IdTipoPersona = 0;

        }

    }
}
