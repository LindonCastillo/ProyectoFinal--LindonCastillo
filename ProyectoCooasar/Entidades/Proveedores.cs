using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedores
    {
        [Key]
        public int ProveedorId { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string RNC { get; set; }
        public string Direccion { get; set; }
        public string Tipo { get; set; }
        public string TipoMoneda { get; set; }
        //public int UsuarioId { get; set; }
        public Proveedores()
        {
            ProveedorId = 0;
            Fecha = DateTime.Now;
            Nombre = string.Empty;
            Telefono = string.Empty;
            RNC = string.Empty;
            Direccion = string.Empty;
            Tipo = string.Empty;
            TipoMoneda = string.Empty;
            //UsuarioId = 0;
        }
    }
}
