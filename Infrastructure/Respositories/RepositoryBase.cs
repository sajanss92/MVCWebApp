using Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Infrastructure.Respositories
{
    public class RepositoryBase<T> : Disposable, IRepository<T> where T : class
    {
        private readonly DbContext m_DataContext;
        private DbSet<T> Dbset
        {
            get { return m_DataContext.Set<T>(); }
        }

        public RepositoryBase(MVCAppContext dbContext)
        {
            m_DataContext = dbContext;
        }

        public virtual T Add(T entity)
        {
            Dbset.Add(entity);
            m_DataContext.SaveChanges();
            return entity;
        }

        public virtual void Update(T entity)
        {
            Dbset.Attach(entity);
            m_DataContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            Dbset.Remove(entity);
            m_DataContext.SaveChanges();
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = Dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                Dbset.Remove(obj);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return Dbset.ToList();
        }

        public T GetSingle(Expression<Func<T, bool>> where)
        {
            return Dbset.AsQueryable().Where(where).FirstOrDefault<T>();

        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return Dbset.Where(where).ToList();
        }

        public int GetCount(Expression<Func<T, bool>> where)
        {
            return Dbset.Where(where).Count<T>();
        }

        public virtual T Get(Object Id)
        {
            return Dbset.Find(Id);
        }
    }
}
