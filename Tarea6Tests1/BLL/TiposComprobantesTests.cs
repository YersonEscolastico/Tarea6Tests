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
    public class TiposComprobantesTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            TiposComprobantes tipos = new TiposComprobantes()
            {
                IdTipoComprobante = 1,
                NombreComprobante = "123"
            };

            RepositorioBase<TiposComprobantes> repositorio = new RepositorioBase<TiposComprobantes>();
            bool paso = false;
            paso = repositorio.Guardar(tipos);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<TiposComprobantes> repositorio = new RepositorioBase<TiposComprobantes>();
            bool paso = false;
            TiposComprobantes tipos = repositorio.Buscar(1);
            tipos.NombreComprobante = "33";
            paso = repositorio.Modificar(tipos);
            Assert.AreEqual(true, paso);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<TiposComprobantes> repositorio = new RepositorioBase<TiposComprobantes>();
            TiposComprobantes tipos = repositorio.Buscar(1);
            Assert.IsNotNull(tipos);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<TiposComprobantes> repositorio = new RepositorioBase<TiposComprobantes>();
            List<TiposComprobantes> lista = new List<TiposComprobantes>();
            lista = repositorio.GetList(t => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<TiposComprobantes> repositorio = new RepositorioBase<TiposComprobantes>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
