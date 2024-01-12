using PostsUser.Models;
using System.Linq.Expressions;

namespace PostsUser.Repositories.Interfaces
{
    public interface IRepository<T> : IDisposable where T : Model
    {
        Task AddAsync(T entity);
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);

        Task<IEnumerable<T>>
            SearchAsync(Expression<Func<T, bool>> predicate);
    }
}
