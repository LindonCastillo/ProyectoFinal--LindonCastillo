using ProyectoCooasar.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCooasar.BLL
{
    public class RepositorioBase<T> : IDisposable, IRepository<T> where T : class
    {
        internal Contexto contexto;


        public RepositorioBase()
        {
            contexto = new Contexto();
        }
        public virtual bool Guardar(T entity)
        {
            bool paso = false;

            try
            {
                if (contexto.Set<T>().Add(entity) != null)
                    paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public virtual bool Modificar(T entity)
        {
            bool paso = false;

            try
            {

                contexto.Entry(entity).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }
        public T Buscar(int id)
        {
            T entity;

            try
            {
                entity = contexto.Set<T>().Find(id);

            }
            catch (Exception)
            {
                throw;
            }

            return entity;
        }
        public List<T> GetList(Expression<Func<T, bool>> expression)
        {
            List<T> lista;

            try
            {
                lista = contexto.Set<T>().Where(expression).ToList();

            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }
        public bool Eliminar(int id)
        {
            bool paso = false;
            T entity;

            try
            {
                entity = contexto.Set<T>().Find(id);
                contexto.Entry(entity).State = EntityState.Deleted;
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }
        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
