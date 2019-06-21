using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea6.BLL;
using Tarea6.Entidades;

namespace Tarea6Tests.BLL
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
            personas.Nombre = "d";
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
                IdPersona = 1,
                Dni = 1,
                Nombre = "juan",
                Materno = "ma",
                Paterno = "pa",
                FechaNacimiento = DateTime.Now,
                Telefono = "213422",
                Correo = "edhej@",
                Sexo ="M",
                Direccion = "macoris",
                IdTipoPersona = 1
            };

            Assert.IsTrue(db.Modificar(persona));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Assert.IsNotNull(db.Buscar(3));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Assert.IsTrue(db.Eliminar(1));
        }


        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Personas> db = new RepositorioBase<Personas>();

            Assert.IsNotNull(db.GetList(p => true));

        }

    }
}
