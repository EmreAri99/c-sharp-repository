using AFirması.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AFirması.core.Dal
{
    public interface IRepository<T> where T : class, IEntity
    {
        IQueryable<T> GetAll();

        IQueryable<T> GetEx(Expression<Func<T, bool>> predicate);

        T GetById (int id);

        void Add (T entity);

        void Update (T entity);

        void Delete (T entity);

        int save();
    }
}
