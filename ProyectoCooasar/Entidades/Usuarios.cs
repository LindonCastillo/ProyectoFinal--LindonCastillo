using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCooasar.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        [Browsable(false)]
        public string Clave { get; set; }
        public string Permiso { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombre = string.Empty;
            Email = string.Empty;
            Usuario = string.Empty;
            Clave = string.Empty;
            Permiso = string.Empty;
            FechaIngreso = DateTime.Now;
        }
    }
}
