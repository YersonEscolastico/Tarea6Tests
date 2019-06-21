using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tarea6.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea6.Entidades;


namespace Tarea6Tests1.BLL
{

    [TestClass()]
    public class TipoPersonasTest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<TipoPersonas> db = new RepositorioBase<TipoPersonas>();


            TipoPersonas tipos = new TipoPersonas()
            {
                TipoPersonaId = 0,
                IdPersona = 0,
                Nombre = "Yersom"
            };
            Assert.IsTrue(db.Guardar(tipos));
        }

        [TestMethod()]
            public void ModificarTest()
            {
                RepositorioBase<TipoPersonas> db = new RepositorioBase<TipoPersonas>();
                TipoPersonas tipos = new TipoPersonas()
                {
                    TipoPersonaId = 2,
                    IdPersona = 1,
                    Nombre = "hie"
                };

                Assert.IsTrue(db.Modificar(tipos));

            }

            [TestMethod()]
            public void BuscarTest()
            {
                RepositorioBase<Personas> db = new RepositorioBase<Personas>();

                Assert.IsNotNull(db.Buscar(1));

            }

        [TestMethod()]
            public void GetListTest()
            {
                RepositorioBase<TipoPersonas> db = new RepositorioBase<TipoPersonas>();

                Assert.IsNotNull(db.GetList(t => true));

            }

            [TestMethod()]
            public void EliminarTest()
            {
                RepositorioBase<TipoPersonas> db = new RepositorioBase<TipoPersonas>();

                Assert.IsTrue(db.Eliminar(3));
            }

        }
    }
