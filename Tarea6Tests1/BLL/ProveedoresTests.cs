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
    public class ProveedoresTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Proveedores proveedores = new Proveedores();
            proveedores.IdProveerdor = 1;
            proveedores.IdPersona = 1;

            RepositorioBase<Proveedores> repositorio = new RepositorioBase<Proveedores>();
            bool paso = false;
            paso = repositorio.Guardar(proveedores);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Proveedores> repositorio = new RepositorioBase<Proveedores>();
            bool paso = false;
            Proveedores proveedores = repositorio.Buscar(1);
            proveedores.IdPersona = 2;
            paso = repositorio.Modificar(proveedores);
            Assert.AreEqual(true, paso);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Proveedores> repositorio = new RepositorioBase<Proveedores>();
            Proveedores proveedores = repositorio.Buscar(1);
            Assert.IsNotNull(proveedores);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Proveedores> repositorio = new RepositorioBase<Proveedores>();
            List<Proveedores> lista = new List<Proveedores>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
           RepositorioBase<Proveedores> repositorio = new RepositorioBase<Proveedores>();
           bool paso = false;
           paso = repositorio.Eliminar(1);
           Assert.AreEqual(true, paso);
        }

    }
}
