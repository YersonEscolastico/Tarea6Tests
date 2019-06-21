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
    public class MarcasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Marcas marcas = new Marcas()
            {
                IdMarca = 1,
                NombreMarca = "yesi"
            }; 
            RepositorioBase<Marcas> repositorio = new RepositorioBase<Marcas>();
            bool paso = false;
            paso = repositorio.Guardar(marcas);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Marcas> repositorio = new RepositorioBase<Marcas>();
            bool paso = false;
            Marcas marcas = repositorio.Buscar(1);
            marcas.NombreMarca = "Apple";
            paso = repositorio.Modificar(marcas);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Marcas> repositorio = new RepositorioBase<Marcas>();
            Marcas marcas = repositorio.Buscar(1);
            Assert.IsNotNull(marcas);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Marcas> repositorio = new RepositorioBase<Marcas>();
            List<Marcas> lista = new List<Marcas>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Marcas> repositorio = new RepositorioBase<Marcas>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
