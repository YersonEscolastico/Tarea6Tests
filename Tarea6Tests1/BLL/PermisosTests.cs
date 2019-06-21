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
    public class PermisosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Permisos permisos = new Permisos()
            {
                IdPermiso = 2,
                Descripcion = "juan",
                Funcionalidad = "hsi"
            };

            RepositorioBase<Permisos> repositorio = new RepositorioBase<Permisos>();
            bool paso = false;
            paso = repositorio.Guardar(permisos);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Permisos> repositorio = new RepositorioBase<Permisos>();
            bool paso = false;
            Permisos permisos = repositorio.Buscar(2);
            permisos.Descripcion = " no";
            paso = repositorio.Modificar(permisos);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Permisos> repositorio = new RepositorioBase<Permisos>();
            Permisos permisos = repositorio.Buscar(2);
            Assert.IsNotNull(permisos);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Permisos> repositorio = new RepositorioBase<Permisos>();
            List<Permisos> lista = new List<Permisos>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }


        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Permisos> repositorio = new RepositorioBase<Permisos>();
            bool paso = false;
            paso = repositorio.Eliminar(2);
            Assert.AreEqual(true, paso);
        }

    }
}
