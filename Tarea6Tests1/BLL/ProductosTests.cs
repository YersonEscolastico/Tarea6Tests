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
    public class ProductosTests
    {

        [TestMethod()]
        public void GuardarTest()
        {
            Productos productos = new Productos()
            {

                IdProducto = 1,
                Nombre = "arroz",
                Descripcion = "gram",
                FechaFabricacion = DateTime.Now,
                CostoCompra = 1,
                Stock = 1,
                IdUnidadMedida = 1,
                IdImagen = 1,
                IdCategoria = 1,
                IdMarca = 1,
                IdModelo = 1
            };

            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            bool paso = false;
            paso = repositorio.Guardar(productos);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            bool paso = false;
            Productos productos = repositorio.Buscar(1);
            productos.Descripcion = "cacao";
            paso = repositorio.Modificar(productos);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos productos = repositorio.Buscar(1);
            Assert.IsNotNull(productos);
        }


        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            List<Productos> lista = new List<Productos>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
