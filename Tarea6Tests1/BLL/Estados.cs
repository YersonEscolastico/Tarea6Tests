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
    public class EstadosTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Estados> repositorio = new RepositorioBase<Estados>();
            bool paso = false;
            Estados estados = new Estados()
            {
                IdEstado = 2,
                FechaInicio = DateTime.Now,
                FechaFin = DateTime.Now,
                Estado = "bueno"
            };

            paso = repositorio.Guardar(estados);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Estados> repositorio = new RepositorioBase<Estados>();
            bool paso = false;
            Estados estados = repositorio.Buscar(2);
            estados.FechaFin = DateTime.Now;
            estados.Estado = "dje";

            paso = repositorio.Modificar(estados);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Estados> repositorio = new RepositorioBase<Estados>();
            Estados estados = repositorio.Buscar(2);
            Assert.IsNotNull(estados);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Estados> repositorio = new RepositorioBase<Estados>();
            List<Estados> lista = new List<Estados>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Estados> repositorio = new RepositorioBase<Estados>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
