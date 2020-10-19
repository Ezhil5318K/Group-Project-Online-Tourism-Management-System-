using System;
using System.Collections.Generic;
using System.Text;
using Tourism.Model;

namespace Tourism.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TourismContext _context;
        public Repository<User> UserRepository { get; }
        public UnitOfWork(TourismContext context)
        {
            this._context = context;
            this.UserRepository = new Repository<User>(this._context);
        }
        public int Save()
        {
            return this._context.SaveChanges();
        }
        public void Dispose()
        {
            this._context.Dispose();
        }
        

    }
        
        
}
