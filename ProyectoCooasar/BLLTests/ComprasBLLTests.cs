using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoCooasar.DAL;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class ComprasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Contexto db = new Contexto();
            Compras Compra = new Compras();
            Compra.CompraId = 0;
            Compra.Fecha = DateTime.Now;
            Compra.ProveedorId = 1;
            Compra.Balance = 1000;
            Compra.Itbis = 18;


            Compra.DetalleCompra.Add(new ComprasDetalle()
            {
                Id = 0,
                CompraId = 1,
                Cantidad = 10,
                ProductoId = 1,
                Precio = 100,
                Subtotal = 1000
            }
            );

            Assert.IsTrue(ComprasBLL.Guardar(Compra));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Contexto db = new Contexto();
            Compras Compra = new Compras();
            Compra.CompraId = 1;
            Compra.Fecha = DateTime.Now;
            Compra.ProveedorId = 1;
            Compra.Balance = 2000;
            Compra.Itbis = 18;


            Compra.DetalleCompra.Add(new ComprasDetalle()
            {
                Id = 0,
                CompraId = 1,
                Cantidad = 20,
                ProductoId = 2,
                Precio = 50,
                Subtotal = 1000
            }
            );

            Assert.IsTrue(ComprasBLL.Modificar(Compra));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNotNull(ComprasBLL.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.IsNotNull(ComprasBLL.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(ComprasBLL.Eliminar(1));

        }
    }
}