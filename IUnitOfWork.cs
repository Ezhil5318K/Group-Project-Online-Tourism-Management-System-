using System;
using System.Collections.Generic;
using System.Text;
using Tourism.Model;

namespace Tourism.Persistence
{
    public interface IUnitOfWork:IDisposable
    {
        Repository<User> UserRepository { get; }
        int Save();
    }
}
