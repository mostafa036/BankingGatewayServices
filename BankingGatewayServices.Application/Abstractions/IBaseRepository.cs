using System.Linq.Expressions;

namespace BankingGatewayServices.Application.Abstractions
{
    public interface IBaseRepository<T>
    {
        Task<T> AddAsync(T entity);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(int id);
        IQueryable<T> Include(Expression<Func<T, object>> include);
        Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
    }
}
