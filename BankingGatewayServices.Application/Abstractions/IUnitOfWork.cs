using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Application.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<TEntity> baseRepository<TEntity>();
        Task<int> Commit();
    }
}
