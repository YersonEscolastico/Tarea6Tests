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
    public class CategoriasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Categorias categorias = new Categorias()
            {
                IdCategoria = 0,
                NombreCategoria = "dhwi",
                Descripcion = "yehs",
            };

            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            bool paso = false;
            paso = repositorio.Guardar(categorias);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            bool paso = false;
            Categorias categorias = repositorio.Buscar(1);
            categorias.Descripcion = "huw";
            paso = repositorio.Modificar(categorias);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            Categorias categorias = repositorio.Buscar(1);
            Assert.IsNotNull(categorias);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            List<Categorias> lista = new List<Categorias>();
            lista = repositorio.GetList(c => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
