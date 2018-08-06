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
    public class ArticuloBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Articulos articulo = new Articulos();
            articulo.IdArticulo = 2;
            articulo.NombreArticulo = "Acetaminofen";
            articulo.PrecioCompra = 50;
            articulo.PrecioVenta = 100;
            articulo.Existencia = 10;
            articulo.ITBIS = 0;
            articulo.FechaIngreso = DateTime.Now;
            articulo.CategoriaId = 1;
            

            paso = ArticuloBLL.Guardar(articulo);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Articulos articulo = new Articulos();
            articulo.IdArticulo = 2;
            articulo.NombreArticulo = "Aspirina";
            articulo.PrecioCompra = 10;
            articulo.PrecioVenta = 120;
            articulo.Existencia = 50;
            articulo.ITBIS = 18;
            articulo.FechaIngreso = DateTime.Now;
            articulo.CategoriaId = 1;


            paso = ArticuloBLL.Guardar(articulo);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            int id = 2;
            paso = ArticuloBLL.Eliminar(id);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Articulos articulo = new Articulos();
            int id = 1;
            articulo = ArticuloBLL.Buscar(id);
            Assert.IsNotNull(articulo);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var articulo = ArticuloBLL.GetList(x => true);
            Assert.IsNotNull(articulo);
        }
    }
}