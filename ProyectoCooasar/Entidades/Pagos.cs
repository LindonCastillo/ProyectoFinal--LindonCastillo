﻿using System;
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
        public int CompraId { get; set; }
        public decimal PagoTotal { get; set; }
        //public int UsuarioId { get; set; }

        public virtual List<PagosDetalle> DetallePagos { get; set; }

        public Pagos()
        {
            PagoId = 0;
            Fecha = DateTime.Now;
            CompraId = 0;
            PagoTotal = 0;

            DetallePagos = new List<PagosDetalle>();
        }
    }
}
