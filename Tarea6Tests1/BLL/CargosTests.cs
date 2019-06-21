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
    public class CargosTests
    {

        [TestMethod()]
        public void GuardarTest()
        {
            Cargos cargos = new Cargos()
            {
                IdCargo = 0,
                Nombre = "Secretaria",
                IdEstado =2
            };

            RepositorioBase<Cargos> repositorio = new RepositorioBase<Cargos>();
            bool paso = false;
            paso = repositorio.Guardar(cargos);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Cargos> repositorio = new RepositorioBase<Cargos>();
            bool paso = false;
            Cargos cargos = repositorio.Buscar(6);
            cargos.IdEstado = 7;
            paso = repositorio.Modificar(cargos);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Cargos> repositorio = new RepositorioBase<Cargos>();
            Cargos cargos = repositorio.Buscar(7);
            Assert.IsNotNull(cargos);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Cargos> repositorio = new RepositorioBase<Cargos>();
            List<Cargos> lista = new List<Cargos>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Cargos> repositorio = new RepositorioBase<Cargos>();
            bool paso = false;
            paso = repositorio.Eliminar(6);
            Assert.AreEqual(true, paso);
        }

    }

}
