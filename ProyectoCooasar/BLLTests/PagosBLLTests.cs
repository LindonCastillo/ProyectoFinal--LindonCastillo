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
    public class PagosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Contexto db = new Contexto();
            Pagos Pago = new Pagos();
            Pago.PagoId = 0;
            Pago.Fecha = DateTime.Now;
            Pago.PagoTotal = 1000;

            Pago.DetallePagos.Add(new PagosDetalle()
            {
                Id = 0,
                PagoId = 1,
                CompraId = 1,
                TipoPaga= "Cheque",
                Pago = 1000

            }
            );

            Assert.IsTrue(PagosBLL.Guardar(Pago));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Contexto db = new Contexto();
            Pagos pago = new Pagos();
            pago.PagoId = 1;
            pago.Fecha = DateTime.Now;
            pago.PagoTotal = 2000;

            pago.DetallePagos.Add(new PagosDetalle()
            {
                Id = 1,
                PagoId = 1,
                CompraId = 1,
                TipoPaga = "Efecto",
                Pago = 1000

            }
            );

            Assert.IsTrue(PagosBLL.Modificar(pago));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.IsNotNull(PagosBLL.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.IsNotNull(PagosBLL.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(PagosBLL.Eliminar(1));

        }
    }
}