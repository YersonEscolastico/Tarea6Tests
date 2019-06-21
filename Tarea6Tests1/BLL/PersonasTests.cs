using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tarea6.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea6.Entidades;

namespace Tarea6.BLL.Tests
{
    [TestClass()]
    public class PersonasTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Personas personas = new Personas();

            personas.IdPersona = 1;
            personas.Dni = 1;
            personas.Nombre = "h";
            personas.Materno = "f";
            personas.Paterno = "dke";
            personas.FechaNacimiento = DateTime.Now;
            personas.Telefono = "292838";
            personas.Correo = "kfjw@";
            personas.Sexo = "M";
            personas.IdImagen = 1;
            personas.Direccion = "djsk";
            personas.IdTipoPersona = 1;

            RepositorioBase<Personas> repositorio = new RepositorioBase<Personas>();
            bool paso = false;
            paso = repositorio.Guardar(personas);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();
            Personas persona = new Personas()
            {
                IdPersona = 4,
                Dni = 1,
                Nombre = "n",
                Materno = "d",
                Paterno = "p",
                FechaNacimiento = DateTime.Now,
                Telefono = "23123",
                Correo = "Paa@",
                Sexo = "M",
                Direccion = "hfh",
                IdTipoPersona = 1
            };

            Assert.IsTrue(db.Modificar(persona));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Assert.IsNotNull(db.Buscar(2));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Assert.IsNotNull(db.GetList(p => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Assert.IsTrue(db.Eliminar(3));
        }


    }
}
