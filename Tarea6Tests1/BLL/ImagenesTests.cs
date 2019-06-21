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
    public class ImagenesTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Imagenes imagenes = new Imagenes()
            {
                IdImagen = 1,
                RutaImagen = "12"
            };

            RepositorioBase<Imagenes> repositorio = new RepositorioBase<Imagenes>();
            bool paso = false;
            paso = repositorio.Guardar(imagenes);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Imagenes> repositorio = new RepositorioBase<Imagenes>();
            bool paso = false;
            Imagenes imagenes = repositorio.Buscar(1);
            imagenes.RutaImagen = "723";
            paso = repositorio.Modificar(imagenes);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Imagenes> repositorio = new RepositorioBase<Imagenes>();
            Imagenes imagenes = repositorio.Buscar(1);
            Assert.IsNotNull(imagenes);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Imagenes> repositorio = new RepositorioBase<Imagenes>();
            List<Imagenes> lista = new List<Imagenes>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Imagenes> repositorio = new RepositorioBase<Imagenes>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }

    }
}
