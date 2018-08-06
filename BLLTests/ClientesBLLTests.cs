using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class ClientesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Clientes clientes = new Clientes();
            bool paso;
            clientes.ClienteId = 1;
            clientes.Direccion = "SFM";
            clientes.Email = "Alexandersamuel08@gmail.com";
            clientes.Nombres = "Samuel Alexander Reyes";
            clientes.Sexo = Clientes.Genero.Masculino;
            clientes.Cedula = "111-1111111-1";
            clientes.MaximoCredicto = 0;
            clientes.Telefono = "111-111-1111";
            clientes.FechaNacimiento = DateTime.MaxValue;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Clientes clientes = new Clientes();
            bool paso;
            clientes.ClienteId = 1;
            clientes.Direccion = "SFM";
            clientes.Email = "Alexandersamuel08@gmail.com";
            clientes.Nombres = "Samuel Alexander Reyes";
            clientes.Sexo = Clientes.Genero.Masculino;
            clientes.Cedula = "111-1111111-1";
            clientes.MaximoCredicto = 0;
            clientes.Telefono = "111-111-1111";
            clientes.FechaNacimiento = DateTime.MaxValue;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 2;
            bool paso;
            paso = ClientesBLL.Eliminar(id);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Clientes suplidor = new Clientes();
            int id = 1;
            suplidor = ClientesBLL.Buscar(id);
            Assert.IsNotNull(suplidor);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var clientes = ClientesBLL.GetList(x => true);
            Assert.IsNotNull(clientes);
        }
    }
}