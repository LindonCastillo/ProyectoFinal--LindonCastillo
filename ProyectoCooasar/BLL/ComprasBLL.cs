using ProyectoCooasar.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ComprasBLL
    {
        public static bool Guardar(Inscripcion inscripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Inscripcion i = new Inscripcion();
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            try
            {
                decimal acumulador = 0;
                int estudianteId = 0;
                if (db.Inscripcion.Add(inscripcion) != null)
                {
                    foreach (var item in inscripcion.Detalle)
                    {
                        estudianteId = item.EstudianteId;
                    }
                    var estudiante = db.Estudiante.Find(estudianteId);

                    foreach (var item in inscripcion.Detalle)
                    {
                        acumulador += item.Subtotal;
                    }
                    estudiante.Balance = 0;
                    repositorio.Modificar(estudiante);
                    estudiante.Balance += acumulador;
                    repositorio.Modificar(estudiante);
                    paso = db.SaveChanges() > 0;
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Inscripcion inscripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();

            try
            {
                var anterior = Buscar(inscripcion.InscripcionId);
                foreach (var item in anterior.Detalle)
                {
                    if (!inscripcion.Detalle.Any(d => d.Id == item.Id))
                        db.Entry(item).State = EntityState.Deleted;

                }

                foreach (var item in inscripcion.Detalle)
                {
                    if (item.Id == 0)
                    {
                        db.Entry(item).State = EntityState.Added;
                    }
                    else
                    {
                        db.Entry(item).State = EntityState.Modified;
                    }

                }

                decimal acumulador = 0;
                int estudianteId = 0;

                foreach (var item in inscripcion.Detalle)
                {
                    estudianteId = item.EstudianteId;
                }
                var estudiante = db.Estudiante.Find(estudianteId);

                foreach (var item in inscripcion.Detalle)
                {
                    acumulador += item.Subtotal;
                }
                estudiante.Balance = 0;
                repositorio.Modificar(estudiante);
                estudiante.Balance += acumulador;
                repositorio.Modificar(estudiante);

                db.Entry(inscripcion).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }


        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();


            try
            {
                var eliminar = db.Inscripcion.Find(id);

                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }


        public static Inscripcion Buscar(int id)
        {
            Contexto db = new Contexto();
            Inscripcion inscripcion = new Inscripcion();

            try
            {
                inscripcion = db.Inscripcion.Find(id);
                if (inscripcion != null)
                {
                    inscripcion.Detalle.Count();
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return inscripcion;
        }

        public static List<Compras> GetList(Expression<Func<Inscripcion, bool>> inscripcion)
        {
            List<Inscripcion> lista = new List<Inscripcion>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Inscripcion.Where(inscripcion).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return lista;
        }
    }
}
