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
    public class VentasTests
    {
        [TestMethod()]

        public void GuardarTest()
        {
            Ventas ventas = new Ventas()
            {

                IdVenta = 1,
                IdUsuario = 1,
                IdCliente = 1,
                IdTipoComprobante = 1,
                FechaVenta = DateTime.Now,
                Igv = 1,
                SubTotal = 1,
                CostoVenta = 1
            };
            RepositorioBase<Ventas> repositorio = new RepositorioBase<Ventas>();
            bool paso = false;
            paso = repositorio.Guardar(ventas);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Ventas> repositorio = new RepositorioBase<Ventas>();
            bool paso = false;
            Ventas ventas = repositorio.Buscar(1);
            ventas.IdUsuario = 2;
            paso = repositorio.Modificar(ventas);
            Assert.AreEqual(true, paso);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Ventas> repositorio = new RepositorioBase<Ventas>();
            Ventas ventas = repositorio.Buscar(1);
            Assert.IsNotNull(ventas);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Ventas> repositorio = new RepositorioBase<Ventas>();
            List<Ventas> lista = new List<Ventas>();
            lista = repositorio.GetList(v => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Ventas> repositorio = new RepositorioBase<Ventas>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
