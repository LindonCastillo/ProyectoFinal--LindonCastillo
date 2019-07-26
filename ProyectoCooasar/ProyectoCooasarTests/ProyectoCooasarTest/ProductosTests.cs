using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoCooasar.BLL;
using ProyectoCooasar.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCooasar.Entidades.Tests
{
    [TestClass()]
    public class ProductosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Productos> test = new RepositorioBase<Productos>();
            Productos productos = new Productos();
            productos.ProductoId = 0;
            productos.Nombre = "Pala";
            productos.Fecha = DateTime.Now;
            productos.Cantidad = 0;
            productos.PrecioCompra = 20;
            productos.PrecioVenta = 25;
            productos.ITBIS = 18;

            Assert.IsTrue(test.Guardar(productos));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Productos> test = new RepositorioBase<Productos>();
            Productos productos = new Productos();
            productos.ProductoId = 1;
            productos.Nombre = "Pala Trumped";
            productos.Fecha = DateTime.Now;
            productos.Cantidad = 50;
            productos.PrecioCompra = 20;
            productos.PrecioVenta = 30;
            productos.ITBIS = 18;

            Assert.IsTrue(test.Modificar(productos));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Productos> test = new RepositorioBase<Productos>();

            Assert.IsNotNull(test.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Productos> test = new RepositorioBase<Productos>();

            Assert.IsNotNull(test.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Productos> test = new RepositorioBase<Productos>();

            Assert.IsTrue(test.Eliminar(1));
        }
    }
}