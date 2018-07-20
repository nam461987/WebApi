using DataModel.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.UnitOfWork
{
    public interface IUnitOfWork
    {
        GenericRepository<User> UserRepository { get; }
        GenericRepository<Product> ProductRepository { get; }
        GenericRepository<Token> TokenRepository { get; }

        /// <summary>
        /// Save method.
        /// </summary>
        void Save();
    }
}
