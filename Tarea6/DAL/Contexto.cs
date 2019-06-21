using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea6.Entidades;

namespace Tarea6.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Empleados> empleados { get; set; }
        public DbSet<TipoPersonas> tipoPersonas { get; set; }
        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Cargos> cargos { get; set; }
        public DbSet<Estados> estados { get; set; }
        public DbSet<Proveedores> proveedores { get; set; }
        public DbSet<Ventas> ventas { get; set; }
        public DbSet<Usuarios> usuarios { get; set; }
        public DbSet<Usuarios_Has_Permisos> usuarios_has_permisos { get; set; }
        public DbSet<Imagenes> imagenes { get; set; }
        public DbSet<TiposComprobantes> tiposComprobantes { get; set; 

        public Contexto() : base("Constr")
        {

        }
    }
}
