using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compras
    {
        [Key]
        public int CompraId { get; set; }
        public DateTime Fecha { get; set; }
        public int ProveedorId  { get; set; }
        public decimal Balance { get; set; }
        public int Itbis { get; set; }
        public int UsuarioId { get; set; }

        public virtual List<ComprasDetalle> DetalleCompra { get; set; }

        public Compras()
        {
            CompraId = 0;
            Fecha = DateTime.Now;
            ProveedorId = 0;
            Balance = 0;
            Itbis = 0;
            UsuarioId = 0;
            DetalleCompra = new List<ComprasDetalle>();
        }

    }
}
