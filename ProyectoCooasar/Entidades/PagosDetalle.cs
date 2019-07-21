using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PagosDetalle
    {
        [Key]
        public int Id { get; set; }
        public int PagoId { get; set; }
        public int CompraId { get; set; }
        public string TipoPaga { get; set; }
        public decimal Pago { get; set; }

        public PagosDetalle()
        {
            Id = 0;
            PagoId = 0;
            CompraId = 0;
            TipoPaga = string.Empty;
            Pago = 0;
        }

        public PagosDetalle(int Id, int PagoId, int CompraId, string TipoPaga, int Pago)
        {
            this.Id = Id;
            this.PagoId = PagoId;
            this.CompraId = CompraId;
            this.TipoPaga = TipoPaga;
            this.Pago = Pago;
        }
    }
}
