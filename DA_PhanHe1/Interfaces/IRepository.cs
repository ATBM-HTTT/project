using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DA_PhanHe1
{
    public interface IRepository<T> where T : class
    {
        T GetById(object id);
        IList<T> GetList();
        Task<IList<T>> GetListAsync();
        T Find(Expression<Func<T, bool>> expression);
        Task<T> FindAsync(Expression<Func<T, bool>> expression);
        IList<T> GetList(Expression<Func<T, bool>> expression);
        Task<IList<T>> GetListAsync(Expression<Func<T, bool>> expression);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task SaveChangesAsync();
    }
}
