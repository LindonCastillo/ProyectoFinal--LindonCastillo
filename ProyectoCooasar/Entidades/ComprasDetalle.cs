using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ComprasDetalle
    {
        [Key]
        public int Id { get; set; }
        public int CompraId { get; set; }
        public int Cantidad { get; set; }
        public int ProductoId { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
        public decimal Subtotal { get; set; }

        public ComprasDetalle()
        {
            Id = 0;
            CompraId = 0;
            Cantidad = 0;
            ProductoId = 0;
            Producto = string.Empty;
            Precio = 0;
            Subtotal = 0;
        }
    }
}
