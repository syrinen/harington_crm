using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dao
{
    public class GenericDAO <T> : IDisposable where T : class
    {
        private DALContext db = null;
        private DbSet<T> entitySet = null;

        public GenericDAO() 
        {
            db = new DALContext();
            entitySet = db.Set<T>();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }            
            this.entitySet.Remove(entity);
        }


        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            this.entitySet.Add(entity);
        }

        public void Update(T entity)
        {
            this.entitySet.Attach(entity);
            this.db.Entry(entity).State = System.Data.Entity.EntityState.Modified;            
        }

        public T FindBy(Expression<Func<T, bool>> expression)
        {
            var result = from r in this.entitySet
                         .Where(expression.Compile())
                         select r;
            var list = result.ToList();
            if (list.Count != 0)
                return list[0];

            return null;

        }

        public virtual IEnumerable<T> GetAll()
        {
            return this.entitySet.AsEnumerable();
        }

        public void SaveChanges()
        {
            this.db.SaveChanges();
        }

        protected DALContext Context 
        {
            get
            {
                return this.db;
            }
        }

        protected DbSet<T> Set
        {
            get
            {
                return this.entitySet;
            }
        }

        public void Dispose()
        {
            this.db.Dispose();
        }
    }
}
