using Microsoft.EntityFrameworkCore;
using PostsUser.Context;
using PostsUser.Models;
using PostsUser.Repositories.Interfaces;
using System.Linq.Expressions;

namespace PostsUser.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Model
    {
        protected readonly AppDbContext _appDbContext;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(AppDbContext db)
        {
            _appDbContext = db;
            _dbSet = db.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> SearchAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.AsNoTracking().Where(predicate).ToListAsync();
        }
        public async Task<TEntity> GetByIdAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            return entity;
        }
        public async Task<List<TEntity>> GetAllAsync()
        {
            var entity = await _dbSet.ToListAsync();
            return entity;
        }
        public async Task AddAsync(TEntity entity)
        {
            _dbSet.Add(entity);
            await _appDbContext.SaveChangesAsync();
        }
        public async Task UpdateAsync(TEntity entity)
        {
            _dbSet.Update(entity);
            await _appDbContext.SaveChangesAsync();

        }
        public async Task DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            _dbSet.Remove(entity);
            await _appDbContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            _appDbContext?.Dispose();
        }
    }
}
