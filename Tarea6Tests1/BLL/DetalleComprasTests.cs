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
    public class DetalleComprasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            DetalleCompras tipos = new DetalleCompras()
            {
            IdDetalleCompra = 0,
            IdCompra = 0,
            IdProducto = 0,
            Unidades = 0,
            CostoUnidad = 0,
            Total = 10
        };

            RepositorioBase<DetalleCompras> repositorio = new RepositorioBase<DetalleCompras>();
            bool paso = false;
            paso = repositorio.Guardar(tipos);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<DetalleCompras> repositorio = new RepositorioBase<DetalleCompras>();
            bool paso = false;
            DetalleCompras detalle = repositorio.Buscar(4);
            detalle.IdCompra = 8;
            paso = repositorio.Modificar(detalle);
            Assert.AreEqual(true, paso);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<DetalleCompras> repositorio = new RepositorioBase<DetalleCompras>();
            DetalleCompras detalle = repositorio.Buscar(5);
            Assert.IsNotNull(detalle);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<DetalleCompras> repositorio = new RepositorioBase<DetalleCompras>();
            List<DetalleCompras> lista = new List<DetalleCompras>();
            lista = repositorio.GetList(t => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<DetalleCompras> repositorio = new RepositorioBase<DetalleCompras>();
            bool paso = false;
            paso = repositorio.Eliminar(4);
            Assert.AreEqual(true, paso);
        }
    }
}
