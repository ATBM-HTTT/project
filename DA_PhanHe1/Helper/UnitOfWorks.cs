using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DA_PhanHe1.Interfaces;
using DA_PhanHe1.User;

namespace DA_PhanHe1.Helper
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool _disposed;
        private readonly AppDbContext _dataContext;
        private IUserRepository _userRepository;

        public UnitOfWork()
        {
            _dataContext = new AppDbContext();
        }

        //database transaction
        public void BeginTransaction()
        {
            _dataContext.Database.BeginTransaction();
        }

        public IUserRepository User => _userRepository ?? (_userRepository = new UserRepository(_dataContext));

        public void SaveChanges()
        {
            _dataContext.SaveChanges();
        }

        protected void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                    _dataContext.Dispose();
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
