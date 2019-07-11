using ProyectoCooasar.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCooasar.DAL
{
        public class Contexto : DbContext
        {
            public DbSet<Usuarios> Usuario { get; set; }
            public Contexto() : base("ConStr")
            { }
        }
}
