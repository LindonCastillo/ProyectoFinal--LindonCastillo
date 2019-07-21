using Entidades;
using ProyectoCooasar.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PagosBLL
    {
        public static bool Guardar(Pagos pagos)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {

                if (db.Pago.Add(pagos) != null)
                {
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

        public static bool Modificar(Pagos pagos)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var anterior = Buscar(pagos.PagoId);
                foreach (var item in anterior.DetallePagos)
                {
                    if (!pagos.DetallePagos.Any(d => d.Id == item.Id))
                        db.Entry(item).State = EntityState.Deleted;

                }

                foreach (var item in pagos.DetallePagos)
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

                db.Entry(pagos).State = EntityState.Modified;
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
                var eliminar = db.Pago.Find(id);

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


        public static Pagos Buscar(int id)
        {
            Contexto db = new Contexto();
            Pagos pagos = new Pagos();

            try
            {
                pagos = db.Pago.Find(id);
                if (pagos != null)
                {
                    pagos.DetallePagos.Count(); 
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

            return pagos;
        }

        public static List<Pagos> GetList(Expression<Func<Pagos, bool>> pagos)
        {
            List<Pagos> lista = new List<Pagos>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Pago.Where(pagos).ToList();
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
