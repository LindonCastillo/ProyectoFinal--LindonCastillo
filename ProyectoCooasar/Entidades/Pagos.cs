using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pagos
    {
        [Key]
        public int PagoId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal PagoTotal { get; set; }
        //public int UsuarioId { get; set; }

        public virtual List<PagosDetalle> DetallePagos { get; set; }

        public Pagos()
        {
            PagoId = 0;
            Fecha = DateTime.Now;
            PagoTotal = 0;

            DetallePagos = new List<PagosDetalle>();
        }

        public int getId()
        {
            int id = 0;
            foreach (var item in DetallePagos)
            {
                id = item.CompraId;
            }

            return id;
        }
    }
}
