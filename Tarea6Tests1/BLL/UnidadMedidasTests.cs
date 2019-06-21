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
    public class UnidadMedidasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            UnidadMedidas unidad = new UnidadMedidas()
            {
                IdUnidadMedida = 2,
                NombreUnidad = "Libra"
            };

            RepositorioBase<UnidadMedidas> repositorio = new RepositorioBase<UnidadMedidas>();
            bool paso = false;
            paso = repositorio.Guardar(unidad);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<UnidadMedidas> repositorio = new RepositorioBase<UnidadMedidas>();
            bool paso = false;
            UnidadMedidas unidad = repositorio.Buscar(3);
            unidad.NombreUnidad = "Onza";
            paso = repositorio.Modificar(unidad);
            Assert.AreEqual(true, paso);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<UnidadMedidas> repositorio = new RepositorioBase<UnidadMedidas>();
            UnidadMedidas unidad = repositorio.Buscar(3);
            Assert.IsNotNull(unidad);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<UnidadMedidas> repositorio = new RepositorioBase<UnidadMedidas>();
            List<UnidadMedidas> lista = new List<UnidadMedidas>();
            lista = repositorio.GetList(u => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<UnidadMedidas> repositorio = new RepositorioBase<UnidadMedidas>();
            bool paso = false;
            paso = repositorio.Eliminar(3);
            Assert.AreEqual(true, paso);
        }
    }
}
