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
    public class ComprasBLL
    {
        public static bool Guardar(Compras compra)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Compra.Add(compra) != null)
                    paso = db.SaveChanges() > 0;
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

        public static bool Modificar(Compras compras)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var anterior = Buscar(compras.CompraId);
                foreach (var item in anterior.DetalleCompra)
                {
                    if (!compras.DetalleCompra.Any(d => d.Id == item.Id))
                        db.Entry(item).State = EntityState.Deleted;

                }

                db.Entry(compras).State = EntityState.Modified;
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
                var eliminar = db.Compra.Find(id);

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


        public static Compras Buscar(int id)
        {
            Contexto db = new Contexto();
            Compras Compra = new Compras();

            try
            {
                Compra = db.Compra.Find(id);
                if (Compra != null)
                {
                    Compra.DetalleCompra.Count();
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

            return Compra;
        }

        public static List<Compras> GetList(Expression<Func<Compras, bool>> compra)
        {
            List<Compras> lista = new List<Compras>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Compra.Where(compra).ToList();
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
