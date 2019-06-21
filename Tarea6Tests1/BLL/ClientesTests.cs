﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class Clientestest
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();


            Clientes tipos = new Clientes()
            {
            IdCliente = 0,
            IdPersona = 1,
            IdEstado = 1,
            FechaCreacion = DateTime.Now
        };
            Assert.IsTrue(db.Guardar(tipos));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();

            Clientes clientes = new Clientes()
            {
                IdCliente = 1,
                IdEstado = 2,
                IdPersona = 1,
                FechaCreacion = DateTime.Now
            };

            Assert.IsTrue(db.Modificar(clientes));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}
