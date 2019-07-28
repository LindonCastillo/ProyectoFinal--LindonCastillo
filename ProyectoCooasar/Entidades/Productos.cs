using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCooasar.Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int ITBIS { get; set; }
        public int UsuarioId { get; set; }

        public Productos()
        {
            ProductoId = 0;
            Nombre = string.Empty;
            Fecha = DateTime.Now;
            Cantidad = 0;
            PrecioCompra = 0;
            PrecioVenta = 0;
            ITBIS = 0;
            UsuarioId = 0;
        }
    }
}
