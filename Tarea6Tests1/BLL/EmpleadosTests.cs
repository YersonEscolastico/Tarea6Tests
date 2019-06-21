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
    public class EmpleadosTests
    {

        [TestMethod()]
        public void GuardarTest()
        {
            Empleados empleados = new Empleados()
            {

                IdEmpleado = 1,
                IdEstado = 1,
                IdCargo = 1,
                IdPersona = 1
            };

            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();
            bool paso = false;
            paso = repositorio.Guardar(empleados);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();
            bool paso = false;
            Empleados empleados = repositorio.Buscar(1);
            empleados.IdEstado = 2;
            paso = repositorio.Modificar(empleados);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();
            Empleados empleados = repositorio.Buscar(1);
            Assert.IsNotNull(empleados);
        }


        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();
            List<Empleados> lista = new List<Empleados>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }


        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Empleados> repositorio = new RepositorioBase<Empleados>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
