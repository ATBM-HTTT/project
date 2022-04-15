using DA_PhanHe1.Helper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DA_PhanHe1
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _dataContext;

        public BaseRepository(AppDbContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Delete(T entity)
        {
            _dataContext.Set<T>().Remove(entity);
        }

        public T GetById(object id)
        {
            return _dataContext.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _dataContext.Set<T>().Add(entity);
        }

        public IList<T> GetList()
        {
            return _dataContext.Set<T>().ToList();
        }

        public async Task<IList<T>> GetListAsync()
        {
            return await _dataContext.Set<T>().ToListAsync();
        }

        public IList<T> GetList(Expression<Func<T, bool>> expression)
        {
            return _dataContext.Set<T>().Where(expression).ToList();
        }

        public T Find(Expression<Func<T, bool>> expression)
        {
            return _dataContext.Set<T>().Where(expression).SingleOrDefault();
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> expression)
        {
            return await _dataContext.Set<T>().Where(expression).SingleOrDefaultAsync();
        }

        public async Task<IList<T>> GetListAsync(Expression<Func<T, bool>> expression)
        {
            return await _dataContext.Set<T>().Where(expression).ToListAsync();
        }

        public void Update(T entity)
        {
            _dataContext.Entry<T>(entity).State = EntityState.Modified;
        }

        public Task SaveChangesAsync()
        {
            return _dataContext.SaveChangesAsync();
        }
    }
}
