using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea6.BLL;
using Tarea6.Entidades;

namespace Tarea6Tests1.BLL
{
    [TestClass()]
    public class DetalleVentasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            DetalleVentas tipos = new DetalleVentas()
            {
            IdDetalleVenta = 0,
            IdVenta = 0,
            IdProducto = 0,
            Unidades = 0,
            CostoUnidad = 0,
            DescuentoUnidad = 0,
            Total = 10
        };

            RepositorioBase<DetalleVentas> repositorio = new RepositorioBase<DetalleVentas>();
            bool paso = false;
            paso = repositorio.Guardar(tipos);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<DetalleVentas> repositorio = new RepositorioBase<DetalleVentas>();
            bool paso = false;
            DetalleVentas  detalle = repositorio.Buscar(2);
            detalle.IdVenta= 8;
            paso = repositorio.Modificar(detalle);
            Assert.AreEqual(true, paso);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<DetalleVentas> repositorio = new RepositorioBase<DetalleVentas>();
            DetalleVentas detalle = repositorio.Buscar(2);
            Assert.IsNotNull(detalle);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<DetalleVentas> repositorio = new RepositorioBase<DetalleVentas>();
            List<DetalleVentas> lista = new List<DetalleVentas>();
            lista = repositorio.GetList(t => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<DetalleVentas> repositorio = new RepositorioBase<DetalleVentas>();
            bool paso = false;
            paso = repositorio.Eliminar(2);
            Assert.AreEqual(true, paso);
        }
    }
}
