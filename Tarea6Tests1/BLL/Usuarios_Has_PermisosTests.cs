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
    public class Usuarios_Has_PermisosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Usuarios_Has_Permisos usuarios = new Usuarios_Has_Permisos()
            {
                IdUsuario = 1,
                IdPermiso = 1
            };

            RepositorioBase<Usuarios_Has_Permisos> repositorio = new RepositorioBase<Usuarios_Has_Permisos>();
            bool paso = false;
            paso = repositorio.Guardar(usuarios);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Usuarios_Has_Permisos> repositorio = new RepositorioBase<Usuarios_Has_Permisos>();
            bool paso = false;
            Usuarios_Has_Permisos usuarios = repositorio.Buscar(1);
            usuarios.IdPermiso = 2;
            paso = repositorio.Modificar(usuarios);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Usuarios_Has_Permisos> repositorio = new RepositorioBase<Usuarios_Has_Permisos>();
            Usuarios_Has_Permisos usuarios = repositorio.Buscar(1);
            Assert.IsNotNull(usuarios);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Usuarios_Has_Permisos> repositorio = new RepositorioBase<Usuarios_Has_Permisos>();
            List<Usuarios_Has_Permisos> lista = new List<Usuarios_Has_Permisos>();
            lista = repositorio.GetList(u => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Usuarios_Has_Permisos> repositorio = new RepositorioBase<Usuarios_Has_Permisos>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }

    }
}
